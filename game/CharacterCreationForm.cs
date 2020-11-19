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

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            pbCharacter.ImageLocation = @"";
        }

        private void cbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbS.Text == "<Reset>")
            {
                str = 0;
               // Reset();
                cbS.Text = "Strength";
            }
        }

        private void pbCharacter_Click(object sender, EventArgs e)
        {

        }


       private void cbChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChar.Text == "Hustler")
            {
                pbCharacter.Image = Properties.Resources.hustler;
            }
            if (cbChar.Text == "Bruiser")
            {
                pbCharacter.Image = Properties.Resources.bruiser;
            }
            if (cbChar.Text == "Assassin")
            {
                pbCharacter.Image = Properties.Resources.assassin;
            }
            if (cbChar.Text == "Cyborg")
            {
               // pbCharacter.Image = Properties.Resources.cyborg;
            }
                pbCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
