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
    public partial class YouLost_Form : Form
    {
        public YouLost_Form()
        {
            InitializeComponent();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playing_Scene newGame = new Playing_Scene();
            newGame.Show();
        }

        private void btn_NO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
