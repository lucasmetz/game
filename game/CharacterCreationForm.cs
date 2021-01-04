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
    public partial class CharacterCreation : Form
    {
        int str;
        int agl;
        int chr;
        int wit;
        int luck;
        string name;
        string picture;
        int health = 10;
        Class1 something;
        
        public CharacterCreation()
        {
            InitializeComponent();
            something = new Class1();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            pbCharacter.ImageLocation = @"";
        }

        private void pbCharacter_Click(object sender, EventArgs e)
        {

        }


       private void cbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChar.Text == "Hustler")
            {
                pbCharacter.Image = Properties.Resource1.hustler;
                picture = "h";
            }
            if (cbChar.Text == "Bruiser")
            {
                pbCharacter.Image = Properties.Resource1.bruiser;
                picture = "b";

            }
            if (cbChar.Text == "Assassin")
            {
                pbCharacter.Image = Properties.Resource1.assassin;
                picture = "a"; 
            }
            if (cbChar.Text == "Cyborg")
            {
                pbCharacter.Image = Properties.Resource1.cyborg;
                picture = "c";
            }
                pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;

            
        }

        private void cbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = Convert.ToInt32(cbS.Text);
        }
        private void nametxt_TextChanged(object sender, EventArgs e)
        {
            nametxt.Text = name;
        }
        private void cbA_SelectedIndexChanged(object sender, EventArgs e)
        {
            agl = Convert.ToInt32(cbA.Text);
        }
        private void cbC_SelectedIndexChanged(object sender, EventArgs e)
        {
            chr = Convert.ToInt32(cbC.Text);
        }
        private void cbW_SelectedIndexChanged(object sender, EventArgs e)
        {
            wit = Convert.ToInt32(cbW.Text);
        }
        private void cbL_SelectedIndexChanged(object sender, EventArgs e)
        {
            luck = Convert.ToInt32(cbL.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            something.str = str;
            something.agl = agl;
            something.chr = Convert.ToInt32(cbC.Text);
            something.wit = Convert.ToInt32(cbW.Text);
            something.luck = Convert.ToInt32(cbL.Text);
            something.name = nametxt.Text;
            something.picture = picture;
            something.health = 10;
            intro_room n = new intro_room(something);
            n.Show();
            this.Hide();
        }


    }
}
