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
using System.Threading;

namespace Employer
{
    public partial class EmployerForm : Form
    {
        bool first ;
        int lastId = 0;
        IList<Contract> cntr = new List<Contract>();
        IList<Contract> cntr2 = new List<Contract>();
        public EmployerForm()
        {
            InitializeComponent();
            this.first = true;
            Thread thread = new Thread(new ThreadStart(checkCustomer));
            thread.Start();

        }
        public void checkCustomer()
        {
            
            while (true)
            {
                 HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getContracts").Result;

            if (response.IsSuccessStatusCode)
            {
                if(first)
                {
                    var contracts = response.Content.ReadAsAsync<IEnumerable<Contract>>().Result;
                    cntr=contracts.Cast<Contract>().ToList();
                    lastId=cntr.Last<Contract>().idcontract;
                    this.first = false;
                }
                else
                {
                    var contracts2=response.Content.ReadAsAsync<IEnumerable<Contract>>().Result;
                    cntr2 = contracts2.Cast<Contract>().ToList();
                    if (lastId < contracts2.Last<Contract>().idcontract)
                        MessageBox.Show("New customer rented a car: Customer Name  = " + contracts2.Last<Contract>().customerName + "Car id = " + contracts2.Last<Contract>().idcar);
                    cntr2.Add(contracts2.Last<Contract>());
                    lastId = cntr2.Last<Contract>().idcontract;
                }
                
            }
            System.Threading.Thread.Sleep(500);
            }
           
        }
        private void viewBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getContracts").Result;

            if (response.IsSuccessStatusCode)
            {
                var contracts = response.Content.ReadAsAsync<IEnumerable<Contract>>().Result;
                dataGridView1.DataSource = contracts;
            }
        }

        private void contractBtn_Click(object sender, EventArgs e)
        {
            Contract c = new Contract();
            c.idcontract = Convert.ToInt32(contractIDTxt.Text);
            c.finished = true;
            c.returned = false;
            c.contractDate = DateTime.Now;
            c.payment = Convert.ToDouble(pay.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/updateContract", c).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Contract c = new Contract();

            c.idcontract = Convert.ToInt32(contractIDTxt.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsJsonAsync("api/returned", c).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }

        }

        private void EmployerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
