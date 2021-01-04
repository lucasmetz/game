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
    
    public partial class Room4 : Form
    {
        Class1 something;
        public Room4(Class1 f)
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



        private void introtxt_Click(object sender, EventArgs e)
        {

        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            if (something.wit >= 5)
            {
                introtxt.Text = "As you sort through the terminal you eventually find a specially marked chip. You pop it out and take it, might come in handy.";
                button1.Visible = true;
                something.chip = true;
            }
            else
            {
                introtxt.Text = "You don't regonize or understand most of the things in the terminal. You decide its best to leave it alone.";
                button1.Visible = true;
                something.chip = false;
            }
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            if (something.str >= 5)
            {
                introtxt.Text = "You pick up the gargantuan club. This could come in handy.";
               button1.Visible = true;
                something.club = true;
            }
            else
            {
                introtxt.Text = "You struggle against the weight of the bludgeon. You heave and ho, but you are unable to lift it.";
                button1.Visible = true;
                something.club = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room3 n = new Room3(something);
            n.Show();
            this.Hide();
        }
    }
}
