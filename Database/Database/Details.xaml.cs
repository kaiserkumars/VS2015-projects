using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Student
        {
            public string fname { get; set; }
            public string lname { get; set; }
            public string branch { get; set; }
            public string roll { get; set; }
            public string email { get; set; }
            public string mobile { get; set; }

        }

        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        int Index = 0;

        List<Student> FormData { get; set; }
        int record_counter;

        public MainWindow()
        {
            InitializeComponent();
            //recordCount(); //checking the number of records         
            DataRetrieve();  //calling the data retrieval method    
        }

        public void DataRetrieve()  //to retrieve data to list
        {



            List<Student> dbData = new List<Student>();
            /*** Here we have used List to store all the data of database at once, 
                 so that we don’t have to call the database again and again. ***/
            string Query = "SELECT * FROM studentdetails WHERE 1";
            //connection = new MySqlConnection();
            //connection.ConnectionString = @"datasource=localhost;port=3306;username=root;password=;database=student;";
            // command = new MySqlCommand(Query, connection);
            //connection.Open();
            makeConnection(Query);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student newStudent = new Student();
                newStudent.fname = reader["FirstName"].ToString();
                newStudent.lname = reader["LastName"].ToString();
                newStudent.branch = reader["Branch"].ToString();
                newStudent.roll = reader["RollNumber"].ToString();
                newStudent.email = reader["Email"].ToString();
                newStudent.mobile = reader["MobileNumber"].ToString();
                dbData.Add(newStudent);

                /**
                Here "FirstName", "LastName"..... are columns names of table studentdetails **/

            }

            connection.Close();
            this.FormData = dbData;
            BindData(Index);
        }

        private void makeConnection(string Query) //function to make connection to database
        {
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = @"datasource=localhost;port=3306;username=root;password=;database=student;";
                command = new MySqlCommand(Query, connection);
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BindData(int Index)                //To bind the form Labels to the data from List
        {
            fname_tb.Text = FormData[Index].fname;
            lname_tb.Text = FormData[Index].lname;
            branch_tb.Text = FormData[Index].branch;
            roll_tb.Text = FormData[Index].roll;
            email_tb.Text = FormData[Index].email;
            mob_tb.Text = FormData[Index].mobile;
        }
    }
}
