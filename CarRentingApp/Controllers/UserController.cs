using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarRentingApp.Models;
using CarRentingApp.Providers;
namespace CarRentingApp.Controllers
{
    public class UserController : ApiController
    {   //Add User
        [HttpPost]
        [Route("api/addUser")]
        public void addUser([FromBody]User value)
        {
            Security secure = new Security();
            value.password = secure.HashSHA1(value.password);
            Provider prov = new Provider();
            prov.addUser(value);
        }

        //UpdateUser
        [HttpPost]
        [Route("api/updateUser")]
        public void updateUser([FromBody]User value)
        {
            Security secure = new Security();
            value.password = secure.HashSHA1(value.password);
            Provider prov = new Provider();
            prov.updateUser(value);
        }
        //GET USERS
        [HttpGet]
        [Route("api/getUsers")]
        public IEnumerable<User> GetUsers()
        {
            Provider up = new Provider();
            return up.getUsers();
        }

        // DELETE USER
        [HttpPost]
        [Route("api/deleteUser")]
        public void DeleteUser([FromBody]User value)
        {
            Provider up = new Provider();
            up.deleteUser(value);
        }
        //Add Car
        [HttpPost]
        [Route("api/addCar")]
        public void addCar([FromBody]Car value)
        {
            Provider prov = new Provider();
            prov.addCar(value);
        }
        //Update Car
        [HttpPost]
        [Route("api/updateCar")]
        public void updateCar([FromBody]Car value)
        {
            Provider prov = new Provider();
            prov.updateCar(value);
        }
        //GET Cars
        [HttpGet]
        [Route("api/getCars")]
        public IEnumerable<Car> GetCars()
        {
            Provider up = new Provider();
            return up.getCars();
        }

        // DELETE Car
        [HttpPost]
        [Route("api/deleteCar")]
        public void DeleteCar([FromBody]Car value)
        {
            Provider up = new Provider();
            up.deleteCar(value);
        }
        //GET CarLoc
        [HttpGet]
        [Route("api/getCarLoc")]
        public IEnumerable<Car> getCarLoc([FromUri] String location)
        {
            Provider up = new Provider();
            return up.getCarLoc(location);
        }
        //GET CarByID
        [HttpGet]
        [Route("api/getCarById")]
        public Car getCarById([FromUri] int id)
        {
            Provider up = new Provider();
            return up.getCarById(id);
        }
        //Add Contract
        [HttpPost]
        [Route("api/addContract")]
        public void addContract([FromBody]Contract value)
        {
            Provider prov = new Provider();
            prov.addContract(value);
        }
        //Update Contract
        [HttpPost]
        [Route("api/updateContract")]
        public void updateContract([FromBody]Contract value)
        {
            Provider prov = new Provider();
            prov.updateContract(value);
        }
        //GET Contracts
        [HttpGet]
        [Route("api/getContracts")]
        public IEnumerable<Contract> getContracts()
        {
            Provider up = new Provider();
            return up.getContracts();
        }
        [HttpGet]
        [Route("api/Login")]
        public User Login([FromUri]string[] data)
        {
            Provider up = new Provider();
            User user = up.GetUser(data[0]);
            if (user != null)
            {
                Security secure = new Security();
                if (secure.VerifyHash(data[1], user.password))
                {
                    return user;
                }
            }
            return user;
        }

        //Returned
        [HttpPost]
        [Route("api/returned")]
        public void returned([FromBody]Contract value)
        {
            Provider prov = new Provider();
            prov.returned(value);
        }
    
    }
}
