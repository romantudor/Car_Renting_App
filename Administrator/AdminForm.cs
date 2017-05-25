using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using CarRentingApp.Models;
using Microsoft.VisualBasic;
using System.IO;

namespace Administrator
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private User retrieve()
        {
            User ret = new User();
            ret.username = usernameTxt.Text;
            ret.fullname = fullnameTxt.Text;
            ret.password = passwordTxt.Text;
            string type = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (type == "Administrator")
                ret.type = 1;
            else if (type == "Employee")
                ret.type = 2;
            else ret.type = 3;
            return ret;
        }
        private Car retrieveC()
        {
            Car car = new Car();
            
            car.manufacturer = manufacturerTxt.Text;
            car.model = modelTxt.Text;
            car.location = locationTxt.Text;
            car.fuel = comboBox1.GetItemText(comboBox2.SelectedItem);
            car.engine=Convert.ToDouble(engineTxt.Text);
            car.year = dateTimePicker1.Value;
          
            openFileDialog1.ShowDialog();
            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            Image img = Image.FromFile(path);
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            pictureBox1.Image = img;
            car.imageSize = arr.Length;
            car.photo = arr;
            return car;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser = retrieve();


            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/addUser", newUser).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser = retrieve();
            newUser.iduser = Convert.ToInt32(useridTxt.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/updateUser", newUser).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getUsers").Result;

            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                dataGridView1.DataSource = users;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.iduser = Convert.ToInt32(useridTxt.Text);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/deleteUser", newUser).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

  
        private void button1_Click_1(object sender, EventArgs e)
        {/*
            openFileDialog1.ShowDialog();
            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            Image img = Image.FromFile(path);
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            pictureBox1.Image = img;
            carPath = path;*/
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car = retrieveC();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/addCar", car).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void updateCarBtn_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car = retrieveC();
            car.idcar = Convert.ToInt32(caridTxt.Text);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/updateCar", car).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void deleteCarBtn_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.idcar = Convert.ToInt32(caridTxt.Text);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/deleteCar", car).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void viewCarBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getCars").Result;

            if (response.IsSuccessStatusCode)
            {
                var cars = response.Content.ReadAsAsync<IEnumerable<Car>>().Result;
                dataGridView2.DataSource = cars;
            }
        }

        private void imageBtn_Click(object sender, EventArgs e)
        {
            int idcar = Convert.ToInt32(caridTxt.Text);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getCars").Result;

            if (response.IsSuccessStatusCode)
            {
                var cars = response.Content.ReadAsAsync<IEnumerable<Car>>().Result;
                foreach (Car cr in cars)
                {
                    if (cr.idcar == idcar)
                    {
                        Image rImage = null;

                        MemoryStream ms;
                        ms = new MemoryStream(cr.photo);
                        rImage = new Bitmap(ms);
                        pictureBox1.Image = rImage;

                    }
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employees_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
