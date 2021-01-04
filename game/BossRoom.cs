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
    public partial class BossRoom : Form
    {
        Class1 something;
        public BossRoom(Class1 f)
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

        private void yesbtn_Click(object sender, EventArgs e)
        {
            if(something.str >= 5)
            {
                introtxt.Text = "You rush at the machine, taking a hit, but you rip off part of the machines armor. You can see its about to do a flurry rush. -1 Health";
                int i;
                i = something.i - 1;
                i = something.i;
                healthlbl.Text = "" + something.i;
                if (something.i <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                if (something.club == true)
                {
                    bldB.Visible = true;
                }
                else something.club = false;
                {
                    bldB.Visible = false;
                }
                if (something.chip == true)
                {
                    chpB.Visible = true;
                }
                else something.chip = false;
                {
                    chpB.Visible = false;
                }
            }
            else
            {
                introtxt.Text = "You try and rush down the machine but you get flung back. -5 Health";
                int i;
                i = something.i - 5;
                i = something.i;
                healthlbl.Text = "" + something.i;
                if (something.i <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            if (something.agl >= 4)
            {
                introtxt.Text = "You slide under the machine and pull out some wires. You can see its about to do a flurry rush.";
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                if (something.club == true)
                {
                    bldB.Visible = true;
                }
                else something.club = false;
                {
                    bldB.Visible = false;
                }
                if (something.chip == true)
                {
                    chpB.Visible = true;
                }
                else something.chip = false;
                {
                    chpB.Visible = false;
                }
            }
            else
            {
                introtxt.Text = "You try to slide under the machine but it stops you with its foot. -2 Health";
                int i;
                i = something.i - 2;
                i = something.i;
                healthlbl.Text = "" + something.i;
                if (something.i <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (something.luck >= 5)
            {
                introtxt.Text = "You flail about wildly and happen to land a hit. You can see its about to do a flurry rush.";
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true; 
                button6.Visible = true; 
                button7.Visible = true;
                if (something.club == true)
                {
                    bldB.Visible = true;
                }
                else something.club = false;
                {
                    bldB.Visible = false;
                }
                if (something.chip == true)
                {
                    chpB.Visible = true;
                }
                else something.chip = false;
                {
                    chpB.Visible = false;
                }
            }
            else
            {
                introtxt.Text = "You try to land a hit in your flurry of blows, but the machine sees through all your moves and zaps you with one of its electric cannons. -6 Health";
                int i;
                i = something.i - 6;
                i = something.i;
                healthlbl.Text = "" + something.i;
                if (something.i <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (something.chr >= 3)
            {
                introtxt.Text = "You are able to momentarily keep the machine at bay with commands. You can see its about to do a flurry rush.";
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                if (something.club == true)
                {
                    bldB.Visible = true;
                }
                else something.club = false;
                {
                    bldB.Visible = false;
                }
                if (something.chip == true)
                {
                    chpB.Visible = true;
                }
                else something.chip = false;
                {
                    chpB.Visible = false;
                }
            }
            else
            {
                introtxt.Text = "You try to give the machine commands to stop it but it doesn't listen. -2 Health";
                int i;
                i = something.health - 2;
                i = something.health;
                healthlbl.Text = "" + something.i;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (something.agl >= 5)
            {
                introtxt.Text = "You dodge past all of the attacks, then you leap and hit the machine in it's eye. It then shuts down.";
                winscreen n = new winscreen(something);
                n.Show();
                this.Hide();
            }
            else
            {
                introtxt.Text = "You attempt to dodge past all the attacks but you're too slow.";
                int i;
                i = something.health - 10;
                i = something.health;
                healthlbl.Text = "" + something.health;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (something.wit >= 5)
            {
                introtxt.Text = "You hide behind cover and hack into the machines mainframe and input a total shutdown.";
                winscreen n = new winscreen(something);
                n.Show();
                this.Hide();
            }
            else
            {
                introtxt.Text = "You attempt to hide and hack the machine but your efforts ar in vain.";
                int i;
                i = something.health - 10;
                i = something.health;
                healthlbl.Text = "" + something.health;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (something.luck >= 5)
            {
                introtxt.Text = "Miraclasly, the machine's old parts start to fall apart and the machine malfunctions.";
                winscreen n = new winscreen(something);
                n.Show();
                this.Hide();
            }
            else
            {
                introtxt.Text = "You attempt to dodge past all the attacks but you're too slow.";
                int i;
                i = something.health - 10;
                i = something.health;
                healthlbl.Text = "" + something.health;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (something.chr >= 5)
            {
                introtxt.Text = "You start barrading the old machine with so many commands, that it can't compute. It self destructs";
                winscreen n = new winscreen(something);
                n.Show();
                this.Hide();
            }
            else
            {
                introtxt.Text = "You attempt to shout commands at the machine but you fail to come up with commands on the spot.";
                int i;
                i = something.health - 10;
                i = something.health;
                healthlbl.Text = "" + something.health;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (something.agl >= 5)
            {
                introtxt.Text = "You grab onto the chasis of the machine and you begin a whirlwind of attacks. After many crushing blows it shuts down.";
                winscreen n = new winscreen(something);
                n.Show();
                this.Hide();
            }
            else
            {
                introtxt.Text = "You attempt to grab onto the machine but it easly flings you off.";
                int i;
                i = something.health - 10;
                i = something.health;
                healthlbl.Text = "" + something.health;
                if (something.health <= 0)
                {
                    DeathScreen n = new DeathScreen(something);
                    n.Show();
                    this.Hide();
                }
            }
        }

        private void bldB_Click(object sender, EventArgs e)
        {
            introtxt.Text = "You use your bludgeon to desimate the machine, breaking it into pieces.";
            winscreen n = new winscreen(something);
            n.Show();
            this.Hide();
        }

        private void chpB_Click(object sender, EventArgs e)
        {
            introtxt.Text = "You rush to the terminal on the machine and plug the chip in and cause an internal malfunction.";
            winscreen n = new winscreen(something);
            n.Show();
            this.Hide();
        }
    }
}
