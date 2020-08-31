namespace Books2021
{
    partial class frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbtitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.Controlador_Tempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Trebuchet MS", 102F);
            this.lbtitle.ForeColor = System.Drawing.Color.Black;
            this.lbtitle.Location = new System.Drawing.Point(213, 116);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(441, 172);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Book\'s";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(248, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 10);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Build 2020.v2 0.10";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.lb_info.ForeColor = System.Drawing.Color.Black;
            this.lb_info.Location = new System.Drawing.Point(246, 272);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 26);
            this.lb_info.TabIndex = 3;
            // 
            // Controlador_Tempo
            // 
            this.Controlador_Tempo.Tick += new System.EventHandler(this.Controlador_Tempo_Tick);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(888, 490);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Splash";
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Timer Controlador_Tempo;

    }
}

