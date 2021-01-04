using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Room3 : Form
    {
        Class1 something;
        public Room3(Class1 f)
        {
            InitializeComponent();
            something = f;
            strengthlbl.Text = "" + something.str;
            agilitylbl.Text = "" + something.agl;
            charismalbl.Text = "" + something.chr;
            witlbl.Text = "" + something.wit;
            lucklbl.Text = "" + something.luck;
            healthlbl.Text = "" + something.health;

            if (something.picture == "a")
            {
                pb.Image = Properties.Resource1.assassin;
            }
            if (something.picture == "b")
            {
                pb.Image = Properties.Resource1.bruiser;
            }
            if (something.picture == "c")
            {
                pb.Image = Properties.Resource1.cyborg;
            }
            if (something.picture == "h")
            {
                pb.Image = Properties.Resource1.hustler;
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void yesbtn_Click_1(object sender, EventArgs e)
        {
            if (something.str >= 4)
            {
                introtxt.Text = "You successfully give the guard a hard slug to the face. Now that the guard is dealt with, the box is left to your devices.";
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                introtxt.Text = "You punch the guard only to sprain your wrist. The guard has hardly even felt your punch. He then kicks you back. Looks like you're not getting access to the box this time. -3 Health";

                int i;
                i = something.health - 3;
                healthlbl.Text = "" + i;
                i = something.health;
                healthlbl.Text = "" + something.health;
            }

            //private void pictureBox1_Click(object sender, EventArgs e)
            {

            }
        }
        private void nobtn_Click(object sender, EventArgs e)
        {
            if (something.agl >= 2)
            {
                introtxt.Text = "You slip past the guard without him noticing. Now that the guard is dealt with, the box is left to your devices.";
                button3.Visible = true;
                button4.Visible = true;
                
            }
            else
            {
                introtxt.Text = "The guard notices you and quickly pushes you away. Looks like you're not getting access to the box this time. -2 Health";

                int i;
                i = something.health - 2;
                healthlbl.Text = "" + i;
                i = something.health;
                healthlbl.Text = "" + something.health;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (something.luck >= 5)
            {
                introtxt.Text = "The guard's head starts nodding off and he falls asleep. Now that the guard is dealt with, the box is left to your devices.";
                button3.Visible = true;
                button4.Visible = true;
                
            }
            else
            {
                introtxt.Text = "Nothing happens.";

               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (something.chr >= 4)
            {
                introtxt.Text = "You successfully convince the guard that you are the one who was supposed to recieve the box.  Now that the guard is dealt with, the box is left to your devices.";
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                introtxt.Text = "The guard calls your bluff. Looks like you're not getting access to the box this time.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            bool variable = rand.Next(2) == 1;
                if (variable == false)
                {
                    introtxt.Text = "A snake pops out and bites you. -5 Health";
                    int i;
                    i = something.health - 5;
                    i = something.health;
                    healthlbl.Text = "" + something.health;
                    button5.Visible = true;
                if (something.health <= 0)
                    {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                  }
                    button5.Visible = true;
                }
                else
                {
                    introtxt.Text = "You look into the box, anticipation flowing through you, only to find nothing.";
                    button5.Visible = true;
                }      
                    
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BossRoom n = new BossRoom(something);
            n.Show();
            this.Hide();
        }
    }
}
