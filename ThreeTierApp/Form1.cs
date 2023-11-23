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
            string connectionString = cs.ConnectionString;
            businessLayer = new BusinessLayer(connectionString);

            LoadStudentsData(); // Load students data initially
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

        }




        // ... (other methods and event handlers)
    }
}

