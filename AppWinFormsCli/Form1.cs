using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinFormsCli
{
    public partial class Form1 : Form
    {
        private Button btn;
        public Form1()
        {
            InitializeComponent();
            btn = new Button();
            btn.Size = new Size(100, 60);
            btn.Location = new Point(30, 30);
            btn.Text = "Click Me";
            this.Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá .Net Core WinForms");
        }

    }
}
