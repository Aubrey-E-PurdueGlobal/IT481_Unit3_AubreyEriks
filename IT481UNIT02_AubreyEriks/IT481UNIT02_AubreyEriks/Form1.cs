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

namespace IT481UNIT02_AubreyEriks
{


    public partial class Form1 : Form
    {
        private DB db;
        private string user;
        private string password;
        private string server;
        private string database;

        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* database = new DB("Server = DESKTOP-T0STA45\\SQLEXPRESS; " +
                                     "Trusted_Connection=true;" +
                                     "Database=Northwind;" +
                                     "User Instance=false;" +
                                     "Connection timeout=30");

             */

            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            database = textBox3.Text;
            server = textBox4.Text;

            if (user.Length == 0 || password.Length == 0 || server.Length == 0 || database.Length == 0)
            {
                isValid = false;
                MessageBox.Show("You must enter username, password, server, and database values.");
            }

            if (isValid)
            {
                db = new DB("Server = " + server + "\\SQLEXPRESS;" +
                            "Trusted_Connection=true;" +
                            "Database = " + database + ";" +
                            "User Id = " + user + ";" +
                            "Password = " + password + ";");

                 MessageBox.Show("Connection information sent");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = db.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = db.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = db.getOrderCount();
            MessageBox.Show(count, "Order Count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string names = db.getCustomerID();
            MessageBox.Show(names, "CustomerID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = db.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = db.getEmployeeLastName();
            MessageBox.Show(names, "Employee Last Name");
        }

        //this label8 function was a mistake from double clicking the label but
        //visual studio won't let me remove it
        //I will ask about this next class.
    private void label8_Click(object sender, EventArgs e)
        {
        }

    


    }
}
