using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cars_Sales.CarModels
{
    public partial class FormAddModel : Form
    {
        private Main mainForm;

        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormAddModel(Main main)
        {
            InitializeComponent();
            mainForm = main;

        }
    }
}
