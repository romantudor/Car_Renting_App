using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Drawing;
using CarRentingApp.Models;
namespace CarRentingApp.Providers
{
    public class Provider
    {
          private string connString;

        public Provider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        }
        public void addUser(User us)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO rentdatabase.user(username,password,fullName,type) VALUES(@username,@pass,@full,@type)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@username", us.username);
                cmd.Parameters.AddWithValue("@pass", us.password);
                cmd.Parameters.AddWithValue("@type", us.type);
                cmd.Parameters.AddWithValue("@full", us.fullname);
                cmd.ExecuteNonQuery();
            }
        }
        public void updateUser(User us)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE rentdatabase.user SET username=@username, password=@pass,fullName=@full, type=@type  WHERE iduser = @id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", us.iduser);
                cmd.Parameters.AddWithValue("@username", us.username);
                cmd.Parameters.AddWithValue("@pass", us.password);
                cmd.Parameters.AddWithValue("@type", us.type);
                cmd.Parameters.AddWithValue("@full", us.fullname);

                cmd.ExecuteNonQuery();
            }
        }
        public IList<User> getUsers()
        {
            IList<User> userList = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM rentdatabase.user";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.iduser = reader.GetInt32("iduser");
                        user.username = reader.GetString("username");
                        user.password = reader.GetString("password");
                        user.type = reader.GetInt32("type");
                        user.fullname = reader.GetString("fullName");
                        userList.Add(user);
                    }
                }
            }
            return userList;
        }
        public void deleteUser(User us)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM rentdatabase.user WHERE iduser = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", us.iduser);
                cmd.ExecuteNonQuery();
            }
        }
        public void addCar(Car car)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO rentdatabase.car(manufacturer,model,location,year,engine,fuel,image,imageSize) VALUES(@man,@mod,@loc,@year,@eng,@fuel,@img,@size)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@man", car.manufacturer);
                cmd.Parameters.AddWithValue("@mod", car.model);
                cmd.Parameters.AddWithValue("@loc", car.location);
                cmd.Parameters.AddWithValue("@year", car.year);
                cmd.Parameters.AddWithValue("@eng", car.engine);
                cmd.Parameters.AddWithValue("@fuel", car.fuel);
                cmd.Parameters.AddWithValue("@img", car.photo);
                cmd.Parameters.AddWithValue("@size", car.imageSize);

                cmd.ExecuteNonQuery();
            }
        }
        public void updateCar(Car car)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE rentdatabase.car SET manufacturer=@man,model=@mod,location=@loc,year=@year,engine=@eng,fuel=@fuel,image=@image,imageSize=@size WHERE idcar = @id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", car.idcar);
                cmd.Parameters.AddWithValue("@man", car.manufacturer);
                cmd.Parameters.AddWithValue("@mod", car.model);
                cmd.Parameters.AddWithValue("@loc", car.location);
                cmd.Parameters.AddWithValue("@year", car.year);
                cmd.Parameters.AddWithValue("@eng", car.engine);
                cmd.Parameters.AddWithValue("@fuel", car.fuel);
                cmd.Parameters.AddWithValue("@size", car.imageSize);
                cmd.Parameters.AddWithValue("@image", car.photo);

                cmd.ExecuteNonQuery();
            }
        }
        public IList<Car> getCars()
        {
            IList<Car> carList = new List<Car>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM rentdatabase.car";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.idcar = reader.GetInt32("idcar");
                        car.manufacturer = reader.GetString("manufacturer");
                        car.model = reader.GetString("model");
                        car.location = reader.GetString("location");
                        car.fuel = reader.GetString("fuel");
                        car.engine = reader.GetDouble("engine");
                        car.year = reader.GetDateTime("year");

                        byte[] rawData;
                        
                        UInt32 FileSize;
                        
                        FileSize = reader.GetUInt32("imageSize");

                        rawData = new byte[FileSize];

                        reader.GetBytes(reader.GetOrdinal("image"), 0, rawData, 0, (Int32)FileSize);
                        car.photo = rawData;
                        carList.Add(car);
                    }
                }
            }
            return carList;
        }
        public void deleteCar(Car car)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM rentdatabase.car WHERE idcar = @id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", car.idcar);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<Car> getCarLoc(String location)
        {
            IList<Car> carList = new List<Car>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM rentdatabase.car WHERE location=@loc";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@loc", location);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.idcar = reader.GetInt32("idcar");
                        car.manufacturer = reader.GetString("manufacturer");
                        car.model = reader.GetString("model");
                        car.location = reader.GetString("location");
                        car.fuel = reader.GetString("fuel");
                        car.engine = reader.GetDouble("engine");
                        car.year = reader.GetDateTime("year");

                        byte[] rawData;

                        UInt32 FileSize;

                        FileSize = reader.GetUInt32("imageSize");

                        rawData = new byte[FileSize];

                        reader.GetBytes(reader.GetOrdinal("image"), 0, rawData, 0, (Int32)FileSize);
                        car.photo = rawData;
                        carList.Add(car);
                    }
                }
            }
            return carList;
        }
        public Car getCarById(int id)
        {
            Car car = new Car();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM rentdatabase.car WHERE idcar=@id";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        car.idcar = reader.GetInt32("idcar");
                        car.manufacturer = reader.GetString("manufacturer");
                        car.model = reader.GetString("model");
                        car.location = reader.GetString("location");
                        car.fuel = reader.GetString("fuel");
                        car.engine = reader.GetDouble("engine");
                        car.year = reader.GetDateTime("year");

                        byte[] rawData;

                        UInt32 FileSize;

                        FileSize = reader.GetUInt32("imageSize");

                        rawData = new byte[FileSize];

                        reader.GetBytes(reader.GetOrdinal("image"), 0, rawData, 0, (Int32)FileSize);
                        car.photo = rawData;
                    }
                }
            }
            return car;
        }
        public void addContract(Contract cntr)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO rentdatabase.contract(idcar,iduser,customerName,customerPNC,rentDate,returnDate,finished,returned) VALUES(@idcar,@iduser,@name,@pnc,@rent,@return,@fin,@ret)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@idcar", cntr.idcar);
                cmd.Parameters.AddWithValue("@iduser", cntr.iduser);
                cmd.Parameters.AddWithValue("@name", cntr.customerName);
                cmd.Parameters.AddWithValue("@pnc", cntr.customerPnc);
                cmd.Parameters.AddWithValue("@return", cntr.returnDate);
                cmd.Parameters.AddWithValue("@rent", cntr.rentDate);
                cmd.Parameters.AddWithValue("@fin", false);
                cmd.Parameters.AddWithValue("@ret", true);
                cmd.ExecuteNonQuery();
            }
        }
        public IList<Contract> getContracts()
        {
            IList<Contract> contracts = new List<Contract>();
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM rentdatabase.contract";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Contract c = new Contract();
                        c.idcontract = reader.GetInt32("idcontract");
                        c.iduser = reader.GetInt32("iduser");
                        c.idcar = reader.GetInt32("idcar");
                        c.finished = reader.GetBoolean("finished");
                        c.returned = reader.GetBoolean("returned");
                        c.customerPnc = reader.GetString("customerPNC");
                        c.customerName = reader.GetString("customerName");
                        c.contractDate = reader.GetDateTime("contractDate");
                        c.payment = reader.GetFloat("payment");
                        c.rentDate = reader.GetDateTime("rentDate");
                        c.returnDate = reader.GetDateTime("returnDate");
                     
                        contracts.Add(c);
                    }
                }
            }
            return contracts;
        }
        public void updateContract(Contract c)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE rentdatabase.contract SET payment=@pay,finished=@fin,contractDate=@cd,returned=@ret WHERE idcontract = @id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@pay", c.payment);
                cmd.Parameters.AddWithValue("@id", c.idcontract);
                cmd.Parameters.AddWithValue("@fin", c.finished);
                cmd.Parameters.AddWithValue("@ret", c.returned);
                cmd.Parameters.AddWithValue("@cd", c.contractDate);
     
                cmd.ExecuteNonQuery();
            }
        }
        public void returned(Contract c)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE rentdatabase.contract SET returned=@ret WHERE idcontract = @id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ret",true);
                cmd.Parameters.AddWithValue("@id", c.idcontract);


                cmd.ExecuteNonQuery();
            }
        }
        public User GetUser(string userName)
        {

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM user where username=\"" + userName + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.iduser = reader.GetInt32("iduser");
                        user.username = reader.GetString("username");
                        user.password = reader.GetString("password");
                        user.fullname =reader.GetString("fullName");
                        user.type = reader.GetInt32("type");
                        return user;
                   
          
                    }
                }
            }

            return null;
        }

    }
}