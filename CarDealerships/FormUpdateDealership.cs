using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cars_Sales.CarDealerships
{
    public partial class FormUpdateDealership : Form
    {
        public FormUpdateDealership(string name, string phone, string email, string working_hours, string services, string address)
        {
            InitializeComponent();
            textBoxName.Text = name; textBoxPhone.Text = phone; textBoxEmail.Text = email;
            textBoxWorkingHours.Text = working_hours; textBoxServices.Text = services; textBoxAddress.Text = address;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            this.Close();
        }
    }
}
