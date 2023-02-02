using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammurabi_Attempt_2
{
    public partial class High_Score_Pop_Up : Form
    {
        public High_Score_Pop_Up()
        {
            InitializeComponent();

            LblScorePopUp.Text = "Score: " + GlobalVariables.score;
            if (GlobalVariables.score > 100)
            {
                Lblgoodbad.Text = "Your kingdom has thrived!";
            }
            if (GlobalVariables.score >= 50 && GlobalVariables.score <= 99)
            {
                Lblgoodbad.Text = "Your kingdom has survived!";
            }
            if (GlobalVariables.score >= 0 && GlobalVariables.score <= 49)
            {
                Lblgoodbad.Text = "Your kingdom has weakened!";
            }
            if (GlobalVariables.score < 0)
            {
                Lblgoodbad.Text = "Your kingdom is in ruins!";
            }


        }
        private void BtnNameSubmit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
