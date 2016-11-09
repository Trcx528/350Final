using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _350Final
{
    class IntroToProg
    {
        public static int TotalScore;
        public static int[] Scores = new int[4];

        public static string LetterGrade
        {
            get
            {
                SetTotal();
                if (TotalScore >= 390)
                    return "A";

                //if we're here total must be under 390
                if (TotalScore >= 380)
                    return "B";

                if (TotalScore >= 350)
                    return "C";

                return "F";
            }
        }

        public static void SetScores(TextBox a1, TextBox a2, TextBox a3, TextBox a4)
        {
            // we really should be validating the text first to make sure that it is a number
            // but this method is only called after validation so it shouldn't be a problem
            Scores[0] = Convert.ToInt32(a1.Text);
            Scores[1] = Convert.ToInt32(a2.Text);
            Scores[2] = Convert.ToInt32(a3.Text);
            Scores[3] = Convert.ToInt32(a4.Text);
        }

        public static void SetTotal()
        {
            TotalScore = 0;
            foreach (var i in Scores)
            {
                TotalScore += i;
            }
        }
    }
}
