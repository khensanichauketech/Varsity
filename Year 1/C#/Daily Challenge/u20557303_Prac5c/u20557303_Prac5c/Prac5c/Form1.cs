using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac5c
{
    public partial class u20557303 : Form
    {
        public u20557303()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        string[] gymChallenges = 
        {
            "The Triple Threat!\n(Complete 3 gym sessions in a single week)",
            "Weight for it...\n(Hit a new Personal Best on any compound lift)",
            "Early Bird Gains!\n(Check-in at the gym before 07:30 AM)",
            "Iron Volume!\n(Complete a total of 50 working sets in one week)"
        };

        string[] chessChallenges =
        {
            "Chess Hat-Trick!\n(Win 3 games in a row)",
            "Defence mastermind!\n(Make 20 moves without losing a piece)",
            "That tastes like promotion!\n(Promote a pawn to a queen)",
            "Attacking prowess!\n(Check the opponent's king in less than 20 moves!)"
        };

        string[] runningChallenges =
        {
            "The Streak Starter!\n(Run 3 days in a row)",
            "The Negative Split!\n(Run the second half of your route faster than the first)",
            "Dawn Patrol!\n(Complete a run before 7:00 AM)",
            "Pavement Crusher!\n(Log a total of 20km in a single week)"
        };

        private void cbxTodaysActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //START
            rtbOutput.Clear(); //Clearing the rich text box
            btnRevealChallenge.Enabled = true;
            //END
        }

        private void btnRevealChallenge_Click(object sender, EventArgs e)
        {
            //START

            //Declaring the variables
            int pick = rnd.Next(0, 4);
            string challenge;

            if (cbxTodaysActivity.Text == "Go to the gym")
            {
                challenge = gymChallenges[pick];
                rtbOutput.Text = challenge;
            }
            else if (cbxTodaysActivity.Text == "Play chess")
            {
                challenge = chessChallenges[pick];
                rtbOutput.Text = challenge;
            }
            else if (cbxTodaysActivity.Text == "Go for a run")
            {
                challenge = runningChallenges[pick];
                rtbOutput.Text = challenge;
            }
            //END
        }

    }
}
