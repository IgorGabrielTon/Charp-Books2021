using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Books2021.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            img_Error01.Visible = false;
            img_error_02.Visible = false;
            img_ok01.Visible = false;
            img_ok02.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox1.Text.Length <= 2)
            {
                panel2.BackColor = Color.Red;
                label4.Text = "Digite o seu nome corretamente!";
                img_Error01.Visible = true;
            }
            if (textBox2.Text.Equals("") || textBox2.Text.Length <= 2)
            {
                panel3.BackColor = Color.Red;
                label5.Text = "Digite a sua senha corretamente!";
                img_error_02.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            panel2.BackColor = Color.Black;
            if (textBox1.Text.Length >= 3)
            {
                img_ok01.Visible = true;
            }
            else
            {
                img_ok01.Visible = false;
                img_Error01.Visible = false;
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            panel3.BackColor = Color.Black;
            if (textBox2.Text.Length >= 3)
            {
                img_ok02.Visible = true;
            }
            else
            {
                img_ok02.Visible = false;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Acesso_rapido.acesso_inst ai = new Books2021.Acesso_rapido.acesso_inst();
            ai.Show();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            img_Error01.Visible = false;
            img_error_02.Visible = false;
            img_ok01.Visible = false;
            img_ok02.Visible = false;
        }
    }
}
