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
    public partial class winscreen : Form
    {
        Class1 something;
        public winscreen(Class1 f)
        {
            InitializeComponent();
            something = f;
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void winscreen_Load(object sender, EventArgs e)
        {
            score.Text = "Score: " + something.i;

        }
    }
}
