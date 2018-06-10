using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookBook
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;
        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CookBook.Properties.Settings.cookbookConnectionString"].ConnectionString;

        }

       

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe",connection))
            {
                //connection.Open(); //we don't need it because SqlDataAdapter will take care of it
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);
                
                ListRecipe.DisplayMember = "Name ";
                ListRecipe.ValueMember = "Id";
                ListRecipe.DataSource = recipeTable;
                //DataRowView drv = (DataRowView)ListRecipe.SelectedItem;
                //String valueOfItem = drv["Name "].ToString();
            }
            
        }

        private void ListRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ListRecipe.SelectedValue.ToString());
        }
    }
}
