using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierApp
{
    public partial class Form1 : Form
    {
        private readonly BusinessLayer businessLayer;
        private DataTable currentDataTable;
        private readonly string connectionString;

        public Form1()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            //cs.DataSource = "(local)";
            //cs.InitialCatalog = "College1en";
            //cs.UserID = "sa";
            //cs.Password = "sysadm";
            cs.DataSource = "(localdb)\\mssqllocaldb";
            cs.InitialCatalog = "College1en";
            cs.IntegratedSecurity = true; // Using windows authentication

            InitializeComponent();

            // Use the connection string built with SqlConnectionStringBuilder
            connectionString = cs.ConnectionString;
            businessLayer = new BusinessLayer(connectionString);
        }
        private void LoadStudentsData()
        {
            currentDataTable = businessLayer.GetStudents();
            dataGridView1.DataSource = currentDataTable;
        }

        private void LoadCoursesData()
        {
            currentDataTable = businessLayer.GetCourses();
            dataGridView1.DataSource = currentDataTable;
        }

        private void LoadProgramsData()
        {
            currentDataTable = businessLayer.GetPrograms();
            dataGridView1.DataSource = currentDataTable;
        }

        private void btnShowCourses_Click(object sender, EventArgs e)
        {
            LoadCoursesData();
        }

        private void btnShowPrograms_Click(object sender, EventArgs e)
        {
            LoadProgramsData();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                bool shouldExit = true;

                try
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        shouldExit = false;

                        MessageBox.Show("Connection successful. State: " + connection.State);
                    }
                    else
                    {
                        MessageBox.Show("Connection failed. State: " + connection.State);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                if (shouldExit)
                {
                    // Exit the application if connection is not established
                    Environment.Exit(1);
                }
            }
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            LoadStudentsData(); // Load students data
        }




        // ... (other methods and event handlers)
    }
}

