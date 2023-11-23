using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private DataTable currentDataTable = new DataTable();
        private SqlDataAdapter sqlDataAdapter;
        private readonly string connectionString;
        private enum STATES
        {
            STUDENTS,
            PROGRAMS,
            COURSES,
            ENROLLMENTS
        }
        private STATES selectedState;
        private bool isSystemUpdating = false;

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

        private void SetupCommand(SqlDataAdapter dataAdapter)
        {
            // Setting up commands for updating the database
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

        }

        // Update the database with changes from the DataTable
        private void CurrentDataTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (isSystemUpdating)
            {
                return;
            }

            sqlDataAdapter.Update(currentDataTable);

            // Refresh data grid view automatically
            switch (selectedState)
            {
                case STATES.STUDENTS:
                    LoadStudentsData(); break;
                case STATES.PROGRAMS:
                    LoadProgramsData(); break;
                case STATES.COURSES:
                    LoadCoursesData(); break;
                case STATES.ENROLLMENTS:
                    LoadEnrollementsData(); break;
                default: break;
            }
        }

        private void LoadStudentsData()
        {
            isSystemUpdating = true;

            sqlDataAdapter = businessLayer.GetStudentsSDA();

            SetupCommand(sqlDataAdapter);

            currentDataTable.Reset();

            currentDataTable = businessLayer.GetStudents();

            // Attach the RowChanged event handler
            currentDataTable.RowChanged += CurrentDataTable_RowChanged;

            //sqlDataAdapter.Fill(currentDataTable); // just for test to make sure duplicate entries get updated automatically

            dataGridView1.DataSource = currentDataTable;

            isSystemUpdating = false;
        }

        private void LoadCoursesData()
        {
            currentDataTable.Reset();
            currentDataTable = businessLayer.GetCourses();
            dataGridView1.DataSource = currentDataTable;
        }

        private void LoadProgramsData()
        {
            currentDataTable.Reset();
            currentDataTable = businessLayer.GetPrograms();
            dataGridView1.DataSource = currentDataTable;
        }

        private void LoadEnrollementsData()
        {
            currentDataTable.Reset();
            currentDataTable = businessLayer.GetEnrollments();
            dataGridView1.DataSource = currentDataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Checking sql connection on form load to make sure it's established
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
            selectedState = STATES.STUDENTS;

            LoadStudentsData(); // Load students data
        }

        private void btnShowPrograms_Click_1(object sender, EventArgs e)
        {
            selectedState = STATES.PROGRAMS;

            LoadProgramsData(); // Load programs data
        }

        private void btnShowCourses_Click(object sender, EventArgs e)
        {
            selectedState = STATES.COURSES;

            LoadCoursesData(); // Load courses data
        }

        private void btnShowEnrollments_Click(object sender, EventArgs e)
        {
            selectedState = STATES.ENROLLMENTS;

            LoadEnrollementsData(); // Load enrollments data
        }

        // ... (other methods and event handlers)
    }
}

