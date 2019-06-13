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
    public partial class Form1 : Form
    {
        private Playing_Scene play;
        private Instructions_Form instructions;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            play = new Playing_Scene();
            play.Show();
        }

        private void btn_Instructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructions = new Instructions_Form();
            instructions.Show();
        }
    }
}
