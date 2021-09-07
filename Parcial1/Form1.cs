using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Home : Form
    {
      
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string Nombre = txtName.Text;
            string password = txtPassword.Text;
            
            
           
            if (this.txtName.Text == "Nicobossio" && this.txtPassword.Text == "Nikoebr42")
            {
                Form2 llamar = new Form2();
                llamar.Show();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, revise si estan bien escritos");
            }

            txtName.Clear();
            txtPassword.Clear();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            rtxtContainer.Text = txtName.Text + "-" +  txtPassword.Text;
            txtName.Clear();
            txtPassword.Clear();


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtxtContainer_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

