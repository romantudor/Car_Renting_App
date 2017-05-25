using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using  CarRentingApp.Models;
using Administrator;
using Customer;
using Employer;
namespace LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '☕';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name1 = name.Text;
            String password1 = password.Text;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/Login?data=" + name1 + "&data=" + password1).Result;
            User value = new User();
            if (response.IsSuccessStatusCode)
            {
                value = response.Content.ReadAsAsync<User>().Result;

            }

            if (value.type == 1)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (value.type == 3)
            {
                CustomerForm df = new CustomerForm();
                df.iduser = value.iduser;
                df.Show();
            }
            else if (value.type == 2)
            {
                EmployerForm sf = new EmployerForm();
                sf.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
