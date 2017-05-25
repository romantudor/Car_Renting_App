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
namespace Customer
{
    public partial class PersonalData : Form
    {
        int idcar;
        int iduser;
        public PersonalData()
        {
            InitializeComponent();
        }
        public PersonalData(int iduser,int idcar)
        {
            InitializeComponent();
            this.idcar = idcar;
            this.iduser = iduser;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Contract cntr = new Contract();
            cntr.customerName = nameTxt.Text;
            cntr.customerPnc = pncTxt.Text;
            cntr.rentDate = rentDate.Value;
            cntr.returnDate = returnDate.Value;
            cntr.returned = false;
            cntr.idcar = this.idcar;
            cntr.iduser = this.iduser;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64317/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/addContract", cntr).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }
    }
}
