using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MicroWave_Player
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
           // string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtpassword + "')";
            string login = ("SELECT * FROM tbl_users WHERE (username= '" + txtUsername + "'and password= '" + txtpassword + "')");
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read() == true)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                new Form1().Show();
                this.Hide();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void viewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
