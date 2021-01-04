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
    public partial class intro_room : Form
    {
        Class1 something;
        public intro_room(Class1 f)
        {
            InitializeComponent();
            something = f;
            strengthlbl.Text = "" + something.str;
            agilitylbl.Text = "" + something.agl;
            charismalbl.Text = "" + something.chr;
            witlbl.Text = "" + something.wit;
            lucklbl.Text = "" + something.luck;

            if (something.picture == "a")
            {
                playerpb.Image = Properties.Resource1.assassin;
            }
            if (something.picture == "b") 
            {
                playerpb.Image = Properties.Resource1.bruiser;
            }
            if (something.picture == "c") 
            {
                playerpb.Image = Properties.Resource1.cyborg;
            }
            if (something.picture == "h") 
            {
                playerpb.Image = Properties.Resource1.hustler;
            }
            playerpb.SizeMode = PictureBoxSizeMode.StretchImage;

            healthlbl.Text = "" + something.health;

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Nothing Changes." + " Do you exit?";
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            Room2 n = new Room2(something);
            n.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
