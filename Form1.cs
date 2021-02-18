using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace UserDetailsFormsApp
{
    public partial class Form1 : Form
    {

        //Global Variable - Connection String
        string sqlConDbDetails = ConfigurationManager.ConnectionStrings["userDbConn"].ConnectionString;
        SqlConnection sqlconn;

        public Form1()
        {
            InitializeComponent();
            //Creating Database Connection
            sqlconn = new SqlConnection(sqlConDbDetails);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Opening Database Connection
                sqlconn.Open();

                DbConnCheck.Text = "Connected Successfully";

                //SQL Command for getting USERS details
                string getUserDetailsCmd = "SELECT * FROM USERS; ";
                SqlCommand sqlCmd = new SqlCommand(getUserDetailsCmd, sqlconn);

                //Getting User Details to In Memory Table
                DataTable dtdata = new DataTable();
                dtdata.Load(sqlCmd.ExecuteReader());

                //Displaying User details in GridView
                UserDetailsGridView.DataSource = dtdata;

            }
            catch(Exception exc)
            {
                //Display in label if Connection fails
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            try
            {

                sqlconn.Open();
                DbConnCheck.Text = "Connected Successfully";

                //Query to find User Count
                string userCountQuery = "SELECT COUNT(id) from USERS";
                SqlCommand userCountCmd = new SqlCommand(userCountQuery, sqlconn);

                //Getting and Displaying User Count
                int count = (int)userCountCmd.ExecuteScalar();
                countResultLabel.Text = "User Count is " + count; 
            }
            catch(Exception exc)
            {
                DbConnCheck.Text = "Connection Failed : " + exc.Message;
            }
            finally
            {
                sqlconn.Close();
            }

        }
    }

       
    }
