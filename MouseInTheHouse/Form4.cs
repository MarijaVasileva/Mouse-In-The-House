using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseInTheHouse
{
    public partial class Congratulations_Form : Form
    {
        public Congratulations_Form()
        {
            InitializeComponent();
        }

        private void btn_YES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playing_Scene playAgain = new Playing_Scene();
            playAgain.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
