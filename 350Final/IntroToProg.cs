using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _350Final
{
    class IntroToProg
    {
        public int TotalScore;
        public static int[] Scores = new int[4];

        public string LetterGrade
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

        public void SetScores(int a1, int a2, int a3, int a4)
        {
            Scores[0] = a1;
            Scores[1] = a2;
            Scores[2] = a3;
            Scores[3] = a4;
        }

        public void SetTotal()
        {
            this.TotalScore = 0;
            foreach (var i in Scores)
            {
                this.TotalScore += i;
            }
        }


        public IntroToProg(MainWindow Window)
        {
            var a1 = Convert.ToInt32(Window.txtAssign1.Text);
            var a2 = Convert.ToInt32(Window.txtAssign2.Text);
            var a3 = Convert.ToInt32(Window.txtAssign3.Text);
            var a4 = Convert.ToInt32(Window.txtAssign4.Text);
            this.SetScores(a1, a2, a3, a4);
        }
    }
}
