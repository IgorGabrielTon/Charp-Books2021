using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Books2021.componentes.splash;

namespace Books2021
{
    public partial class frm : Form
    {
        private int Contador = 1;
        public frm()
        {
            InitializeComponent();
            Controlador_Tempo.Interval = 980;
            Controlador_Tempo.Start();
            
        }

        private void Controlador_Tempo_Tick(object sender, EventArgs e)
        {
            String a = principalSplash.MsgLabel(Contador);
            if(!a.Equals("end"))
            {
                lb_info.Text = principalSplash.MsgLabel(Contador);
                Contador++;
            }
            if (a.Equals("end"))
            {
                Controlador_Tempo.Stop();
                this.Visible = false;
                Books2021.Login.Login lg = new Books2021.Login.Login();
                lg.Show();
            }
            
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

    }
}
