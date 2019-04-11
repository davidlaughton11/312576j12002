/*David Laughton
 * April 10 2019
 * Number astric program
 */

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

namespace _312576j12002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //all digits with astrics
            int digit;
            int.TryParse(Textbox.Text, out digit);

            if (digit == 0)
            {
                lblOutput.Content =
                " *  *  * " + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                + Environment.NewLine + "      "
                 + Environment.NewLine + "*        *"
                  + Environment.NewLine + "*        *"
                   + Environment.NewLine + "*        *"
                   + Environment.NewLine + " *  *  * ";
            }
            else if (digit == 1)
            {
                lblOutput.Content =
                 " "   + Environment.NewLine +  "         *"
                 + Environment.NewLine + "         *"
                 + Environment.NewLine + "         *"
                + Environment.NewLine + "      "
                 + Environment.NewLine + "         *"
                  + Environment.NewLine + "         *"
                   + Environment.NewLine + "         *";
            }
            else if (digit == 2)
            {
                lblOutput.Content = "  *  *  * " + Environment.NewLine + "           *"
                 + Environment.NewLine + "           *"
                 + Environment.NewLine + "           *"
                + Environment.NewLine + "  *  *  * "
                 + Environment.NewLine + "*         "
                  + Environment.NewLine + "*         "
                   + Environment.NewLine + "*         "
                   + Environment.NewLine + "  *  *  * ";
            }
            else if (digit == 3)
            {
                lblOutput.Content = "  *  *  * " + Environment.NewLine + "           *"
                + Environment.NewLine + "           *"
                + Environment.NewLine + "           *"
               + Environment.NewLine + "  *  *  * "
                + Environment.NewLine + "           *"
                  + Environment.NewLine + "           *"
                   + Environment.NewLine + "           *"
                  + Environment.NewLine + "  *  *  * ";
            }
            else if (digit == 4)
            {
                lblOutput.Content = " "
                  + Environment.NewLine +     "*        *"
                  + Environment.NewLine + "*        *"
                   + Environment.NewLine + "*        *"
                   + Environment.NewLine + " *  *  * "
                   + Environment.NewLine + "         *"
                  + Environment.NewLine + "         *"
                   + Environment.NewLine + "         *";
            }
            else if (digit == 5)
            {
                lblOutput.Content = "  *  *  * "
                    + Environment.NewLine + "*         "
                 + Environment.NewLine + "*        "
                 + Environment.NewLine + "*        "
                 + Environment.NewLine + "  *  *  * " 
                 + Environment.NewLine + "           *"
                  + Environment.NewLine + "           *"
                   + Environment.NewLine + "           *"
                   + Environment.NewLine + "  *  *  * ";
            }
            else if (digit == 6)
            {
                lblOutput.Content = "  *  *  * "
                    + Environment.NewLine + "*         "
                 + Environment.NewLine + "*        "
                 + Environment.NewLine + "*        "
                 + Environment.NewLine + "  *  *  * "
                 + Environment.NewLine + "*          *"
                  + Environment.NewLine + "*          *"
                   + Environment.NewLine + "*          *"
                   + Environment.NewLine + "  *  *  * ";
            }
            else if (digit == 7)
            {
                lblOutput.Content = "  *  *  * "
                   + Environment.NewLine + "           *"
                + Environment.NewLine + "           *"
                + Environment.NewLine + "           *"
                + Environment.NewLine + "   "
                + Environment.NewLine + "           *"
                 + Environment.NewLine + "           *"
                  + Environment.NewLine + "           *";
            }
            else if (digit == 8)
            {
                 lblOutput.Content =
                " *  *  * " + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                + Environment.NewLine + " *  *  * "
                 + Environment.NewLine + "*        *"
                  + Environment.NewLine + "*        *"
                   + Environment.NewLine + "*        *"
                   + Environment.NewLine + " *  *  * ";
            }
            else if (digit == 9)
            {
                lblOutput.Content =
                " *  *  * " + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                 + Environment.NewLine + "*        *"
                + Environment.NewLine + " *  *  * "
                + Environment.NewLine + "         *"
                 + Environment.NewLine + "         *"
                  + Environment.NewLine + "         *"
                  + Environment.NewLine + "  *  *  * ";
            }
        }

        private void Textbox_KeyUp(object sender, KeyEventArgs e)
        {
            //only one digit allowed
            if (Textbox.Text.Length > 1)
            {
                Textbox.Text = Textbox.Text.Remove(1, Textbox.Text.Length - 1);
            }
        }
    }
}
