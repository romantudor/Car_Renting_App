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

namespace Customer
{
    public partial class CustomerForm : Form
    {
        public int idcar;
        public int iduser;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getCars").Result;

            if (response.IsSuccessStatusCode)
            {
                var cars = response.Content.ReadAsAsync<IEnumerable<Car>>().Result;
                dataGridView1.DataSource = cars;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/getCarLoc?location=" + locationTxt.Text).Result;
            IList<Car> cars1 = new List<Car>();
            if (response.IsSuccessStatusCode)
            {
                var cars = response.Content.ReadAsAsync<IEnumerable<Car>>().Result;
                dataGridView1.DataSource = cars;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void dataGridView1_RowEnter(object sender,DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Car car = dataGridView1.SelectedRows[0].DataBoundItem as Car;
                if (car != null)
                {
                    int idcar = car.idcar;
                    this.idcar = car.idcar;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:64317/");

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("api/getCarById?id=" + idcar).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var car1 = response.Content.ReadAsAsync<Car>().Result;

                                Image rImage = null;
                                MemoryStream ms;
                                ms = new MemoryStream(car1.photo);
                                rImage = new Bitmap(ms);
                                pictureBox1.Image = rImage;

                    }
                }
            }
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            Form data = new PersonalData(iduser,this.idcar);
            data.Show();
        }

        private void dateBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/getContracts").Result; 
            IList<Car> cars = availableCars();
            IList<Car> finalCars = new List<Car>();
            if (response.IsSuccessStatusCode)
            {
                var contracts = response.Content.ReadAsAsync<IEnumerable<Contract>>().Result;
                foreach (Contract cont in contracts)
                {
                    foreach (Car car in cars)
                    { 
                        if (rent.Value>cont.returnDate)
                        if (cont.idcar==car.idcar)
                                finalCars.Add(car);
                    }
                }
                dataGridView1.DataSource=finalCars;


            }
        }
        private IList<Car> availableCars()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getCars").Result;
            List<Car> crs  = new List<Car>();
            if (response.IsSuccessStatusCode)
            {
                var cars = response.Content.ReadAsAsync<IEnumerable<Car>>().Result;
                crs = cars.Cast<Car>().ToList();
            }
            return crs;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
