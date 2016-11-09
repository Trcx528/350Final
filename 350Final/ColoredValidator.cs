using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace _350Final
{
    class ColoredValidator
    {
        /*
         * For fun I decided to create this validation class.  It is based primarily off off this article: https://baymard.com/blog/inline-form-validation
         * 
         * While it primarily focuses on web, there is no reason we can't apply it's principles to a WPF app
         * 
         * In short it states that:
         *  - Negative/incorrect data should be marked as such after leaving the field, this prevents fields from prematurely marking the contents incorrect
         *  - Positive validation should be used to mark the field as correct as soon at it is valid
         *  
         *  The following code implements these principles, and makes validation failure obvious in advance
         */
        private TextBox box;
        private static Brush Success = Brushes.LightGreen;
        private static Brush Error = Brushes.Salmon;
        private static Brush Default = Brushes.White;

        // pass in a text box and this class will automatically bind to the correct events
        public ColoredValidator(TextBox box)
        {
            this.box = box;
            box.LostFocus += Box_LostFocus;
            box.TextChanged += Box_TextChanged;
        }

        private bool isValid()
        {
            int i;
            return int.TryParse(box.Text, out i); 
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            box.Background = isValid() ? Success : Default;
        }

        private void Box_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            // only mark text that aren't empty as errors
            box.Background = isValid() ? Success : (box.Text == "" ? Default : Error);
        }
    }
}
