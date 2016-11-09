using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _350Final
{
    public partial class MainWindow : Window
    {
        private bool isValid()
        {
            int i;
            if (txtAssign1.Text == "" || !int.TryParse(txtAssign1.Text, out i))
            {
                MessageBox.Show("Please enter a valid value for assigment 1.");
                return false;
            }
            else if (txtAssign2.Text == "" || !int.TryParse(txtAssign2.Text, out i))
            {
                MessageBox.Show("Please enter a valid value for assigment 2.");
                return false;
            }
            else if (txtAssign3.Text == "" || !int.TryParse(txtAssign3.Text, out i))
            {
                MessageBox.Show("Please enter a valid value for assigment 3.");
                return false;
            }
            else if (txtAssign4.Text == "" || !int.TryParse(txtAssign4.Text, out i))
            {
                MessageBox.Show("Please enter a valid value for assigment 4.");
                return false;
            }
            return true;
        }

        public MainWindow()
        {
            InitializeComponent();
            new ColoredValidator(txtAssign1);
            new ColoredValidator(txtAssign2);
            new ColoredValidator(txtAssign3);
            new ColoredValidator(txtAssign4);
        }


        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                IntroToProg.SetScores(txtAssign1, txtAssign2, txtAssign3, txtAssign4);
                lstGrades.Items.Clear();
                foreach (var grade in IntroToProg.Scores)
                {
                    lstGrades.Items.Add(grade);
                }
            }
        }

        private void btnCalcLetterGrade_Click(object sender, RoutedEventArgs e)
        {
            if (isValid()) {
                IntroToProg.SetScores(txtAssign1, txtAssign2, txtAssign3, txtAssign4);
                txtLetterGrade.Text = IntroToProg.LetterGrade;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lstGrades.Items.Clear();
        }
    }
}
