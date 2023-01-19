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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da= new OleDbDataAdapter();
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and/or Password fields are empty", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtpassword + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Suuccessfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password dosen't match, Please Re-enter", "Registration Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();

            }

        }

        private void viewPass_CheckedChanged(object sender, EventArgs e)
        {
            if(viewPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
