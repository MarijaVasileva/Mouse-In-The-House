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
    public partial class Playing_Scene : Form
    {
        bool PAUSE;
        private int time = 60;
        private Congratulations_Form youWonForm;
        private YouLost_Form loserForm;
        Point start = new Point();
        Size SIZE = new Size();
        int countCheese;
        int countLives;
        public Playing_Scene()
        {
            InitializeComponent();
            timer1.Interval = 5;
            timer1.Start();
            timer2.Interval = 10;
            timer2.Start();
            


            KeyDown += new KeyEventHandler(Form2_KeyDown);
            start = pb_movingMouse.Location;
            SIZE = pb_movingMouse.Size;
            countLives = 3;
            countCheese = 0;
            PAUSE = false;
            label1.Text = countLives.ToString();


        }
        private bool IsInTouch(PictureBox pb_movingMouse, PictureBox pb)
        {
            if (pb_movingMouse.Bounds.IntersectsWith(pb.Bounds))
            {
                return true;
            }
            else return false;
        }
        private void Playing_Scene_Load(object sender, EventArgs e)
        {
            KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pb_movingMouse.Location.X;
            int y = pb_movingMouse.Location.Y;
            int cekor = 10;
            if (e.KeyCode == Keys.Right)
            {
                if (pb_movingMouse.Location.X <= 230 &&
                    !IsInTouch(pb_movingMouse, pictureBox1) &&
                    !IsInTouch(pb_movingMouse, pictureBox2) &&
                    !IsInTouch(pb_movingMouse, pictureBox3) &&
                    !IsInTouch(pb_movingMouse, pictureBox4) &&
                    !IsInTouch(pb_movingMouse, pictureBox5) &&
                    !IsInTouch(pb_movingMouse, pictureBox6) &&
                    !IsInTouch(pb_movingMouse, pictureBox7) &&
                    !IsInTouch(pb_movingMouse, pictureBox8) &&
                    !IsInTouch(pb_movingMouse, pictureBox9) &&
                    !IsInTouch(pb_movingMouse, pictureBox10) &&
                    !IsInTouch(pb_movingMouse, pictureBox11) &&
                    !IsInTouch(pb_movingMouse, pictureBox12) &&
                    !IsInTouch(pb_movingMouse, pictureBox13))

                {


                    x += cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1)){
                        countCheese++;
                        sirenje1.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2))
                    {
                        countCheese++;
                        sirenje2.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3))
                    {
                        countCheese++;
                        sirenje3.Hide();
                    }

                }
            }
            else if (e.KeyCode == Keys.Left)

            {
                
                if (pb_movingMouse.Location.X >= 44 &&
                    
                    !IsInTouch(pb_movingMouse, pictureBox2) &&
                    !IsInTouch(pb_movingMouse, pictureBox3) &&
                    !IsInTouch(pb_movingMouse, pictureBox4) &&
                    !IsInTouch(pb_movingMouse, pictureBox9) 
                    )
                {
                    x -= cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1))
                    {
                        countCheese++;
                        sirenje1.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2))
                    {
                        countCheese++;
                        sirenje2.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3))
                    {
                        countCheese++;
                        sirenje3.Hide();
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                
                //label1.Text = "prrrrrrrrp";
                if (pb_movingMouse.Location.Y >= 45 &&
                    !IsInTouch(pb_movingMouse, pictureBox1) &&
                    !IsInTouch(pb_movingMouse, pictureBox2) &&
                    !IsInTouch(pb_movingMouse, pictureBox3) &&
                    !IsInTouch(pb_movingMouse, pictureBox4) &&
                    !IsInTouch(pb_movingMouse, pictureBox5) &&
                    !IsInTouch(pb_movingMouse, pictureBox6) &&
                    !IsInTouch(pb_movingMouse, pictureBox7) &&
                    !IsInTouch(pb_movingMouse, pictureBox8) &&
                    !IsInTouch(pb_movingMouse, pictureBox9) &&
                    !IsInTouch(pb_movingMouse, pictureBox10) &&
                    !IsInTouch(pb_movingMouse, pictureBox11) &&
                    !IsInTouch(pb_movingMouse, pictureBox12) &&
                    !IsInTouch(pb_movingMouse, pictureBox13))// &&
                    
                    //!IsInTouch(pb_movingMouse, pictureBox2) ) 
                    
                {
                    y -= cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1))
                    {
                        countCheese++;
                        sirenje1.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2))
                    {
                        countCheese++;
                        sirenje2.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3))
                    {
                        countCheese++;
                        sirenje3.Hide();
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                
                if (pb_movingMouse.Location.Y <= 520 &&
                    !IsInTouch(pb_movingMouse, pictureBox1) &&
                    !IsInTouch(pb_movingMouse, pictureBox2) &&
                    !IsInTouch(pb_movingMouse, pictureBox3) &&
                    !IsInTouch(pb_movingMouse, pictureBox4) &&
                    !IsInTouch(pb_movingMouse, pictureBox5) &&
                    !IsInTouch(pb_movingMouse, pictureBox6) &&
                    !IsInTouch(pb_movingMouse, pictureBox7) &&
                    !IsInTouch(pb_movingMouse, pictureBox8) &&
                    !IsInTouch(pb_movingMouse, pictureBox9) &&
                    !IsInTouch(pb_movingMouse, pictureBox10) &&
                    !IsInTouch(pb_movingMouse, pictureBox11) &&
                    !IsInTouch(pb_movingMouse, pictureBox12) &&
                    !IsInTouch(pb_movingMouse, pictureBox13))
                {
                    y += cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1))
                    {
                        countCheese++;
                        sirenje1.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2))
                    {
                        countCheese++;
                        sirenje2.Hide();
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3))
                    {
                        countCheese++;
                        sirenje3.Hide();
                    }
                }
            }
            pb_movingMouse.Location = new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_movingCat1.Location = new Point(pb_movingCat1.Location.X, pb_movingCat1.Location.Y - 1);
            pb_movingCat2.Location = new Point(pb_movingCat2.Location.X-1, pb_movingCat2.Location.Y);
            if (pb_movingCat1.Location.Y == 10) pb_movingCat1.Location = new Point(pb_movingCat1.Location.X,500);
            if (pb_movingCat2.Location.X == 40) pb_movingCat2.Location = new Point(225, pb_movingCat2.Location.Y);
            if (IsInTouch(pb_movingMouse, pb_movingCat1) || IsInTouch(pb_movingMouse, pb_movingCat2)
                    || IsInTouch(pb_movingMouse, stapica1) || IsInTouch(pb_movingMouse, stapica2)
                    || IsInTouch(pb_movingMouse, stapica3))
            {
                pb_movingMouse.Location = new Point(132,520);
                countLives =countLives-1;
                if (countLives == 0)
                {
                    this.Hide();
                    loserForm = new YouLost_Form();
                    loserForm.Show();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            stapica1.Location = new Point(stapica1.Location.X + 1, stapica1.Location.Y);
            stapica2.Location = new Point(stapica2.Location.X + 1, stapica2.Location.Y);
            stapica3.Location = new Point(stapica3.Location.X - 1, stapica3.Location.Y);
            if (stapica1.Location.X == 225) stapica1.Location = new Point(40, stapica1.Location.Y);
            if (stapica3.Location.X == 40) stapica3.Location = new Point(225, stapica3.Location.Y);
            if (stapica2.Location.X == 225) stapica2.Location = new Point(40, stapica2.Location.Y);
            
        }
    }
}
