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
    public partial class Room2 : Form
    {
        Class1 something;
        public Room2(Class1 f)
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

        
        private void Room2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void strbtn_Click(object sender, EventArgs e)
        {
            if (something.str >= 3)
            {
                introtxt.Text = "You successfully charge the robot and as you beat it down it eventually shuts down.";
                
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                introtxt.Text = "The robot stops you in your tracks and slams its metal fist into your gut. You fly back and hit a wall. -2 Health";
                
                int i;
                i = something.health - 2;
                healthlbl.Text = "" + i;
                i = something.health;
            }
        }

        private void aglbtn_Click(object sender, EventArgs e)
        {
            if (something.agl >= 3)
            {
               introtxt.Text = "You successfully dash behind the robot and you sweep its legs. When it hits the ground you can hear it shut off.";
                
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                introtxt.Text = "You try and dash behind the robot but it sticks its arm out at the last moment and you get slammed into the ground. -2 Health";
                
                int i;
                i = something.health - 2;
                healthlbl.Text = "" + i;
                i = something.health;
            }
        }

        private void chrbtn_Click(object sender, EventArgs e)
        {
            if (something.chr >= 3)
            {
                introtxt.Text = "You successfully calm the robot down before it attacked. It then meanders off.";
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                introtxt.Text = "The robot doesn't listen to your pleas of peace. It delivers a punch to the gut that knocks you down. -2 Health";
                
                int i;
                i = something.health - 2;
                healthlbl.Text = "" + i;
                i = something.health;
            }
        }

        private void witbtn_Click(object sender, EventArgs e)
        {
            if (something.wit >= 3)
            {
                introtxt.Text = "You successfully slip behind the robot and you tear out some vital wires. As sparks shoot out from the robot it shuts down.";
                label3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                introtxt.Text = "You get behind the robot only to realize that you don't know what any of the wires do. Suddenly the robot turns around and whacks your face with the back of its palm. -2 Health";
                
                int i;
                i = something.health - 2;
                healthlbl.Text = "" + i;
                i = something.health;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Room3 n = new Room3(something);
            n.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Room4 n = new Room4(something);
            n.Show();
            this.Hide();
        }
    }
}
