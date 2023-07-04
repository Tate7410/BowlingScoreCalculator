using BowlingScoreCalculator.ViewModel;
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
using static System.Net.Mime.MediaTypeNames;

namespace BowlingScoreCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BowlingScoreViewModel textBoxEntry;
        public MainWindow()
        {
            InitializeComponent();
            textBoxEntry = new BowlingScoreViewModel();
            
            DataContext = textBoxEntry;
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxEntry.ResetScoring();
            frame1Entry1.Text = null;
            frame1Entry2.Text = null;
            frame2Entry1.Text = null;
            frame2Entry2.Text = null;
            frame3Entry1.Text = null;
            frame3Entry2.Text = null;
            frame4Entry1.Text = null;
            frame4Entry2.Text = null;
            frame5Entry1.Text = null;
            frame5Entry2.Text = null;
            frame6Entry1.Text = null;
            frame6Entry2.Text = null;
            frame7Entry1.Text = null;
            frame7Entry2.Text = null;
            frame8Entry1.Text = null;
            frame8Entry2.Text = null;
            frame9Entry1.Text = null;
            frame9Entry2.Text = null;
            frame10Entry1.Text = null;
            frame10Entry2.Text = null;
            frame10Entry3.Text = null;
        }

        private void frame1Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame1Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame1Entry1.Text != "x" && frame1Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame1Score(frame1Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame1Entry1.Text == "x" || frame1Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
                
        }

        private void frame1Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame1Entry2.Text != "x" || e.Key == Key.Enter && frame1Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame1Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame1Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame1Score(frame1Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame2Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame2Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame2Entry1.Text != "x" && frame2Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame1Score(frame2Entry1.Text);
                textBoxEntry.UpdateFrame2Score(frame2Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame2Entry1.Text == "x" || frame2Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
                
        }

        private void frame2Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame2Entry2.Text != "x" || e.Key == Key.Enter && frame2Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame2Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame2Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame1Score(frame2Entry2.Text);
                textBoxEntry.UpdateFrame2Score(frame2Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
                
        }

        private void frame3Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame3Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame3Entry1.Text != "x" && frame3Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame1Score(frame3Entry1.Text);
                textBoxEntry.UpdateFrame2Score(frame3Entry1.Text);
                textBoxEntry.UpdateFrame3Score(frame3Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame3Entry1.Text == "x" || frame3Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
                
        }

        private void frame3Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame3Entry2.Text != "x" || e.Key == Key.Enter && frame3Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame3Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame3Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame2Score(frame3Entry2.Text);
                textBoxEntry.UpdateFrame3Score(frame3Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame4Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame4Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame4Entry1.Text != "x" && frame4Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame2Score(frame4Entry1.Text);
                textBoxEntry.UpdateFrame3Score(frame4Entry1.Text);
                textBoxEntry.UpdateFrame4Score(frame4Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame4Entry1.Text == "x" || frame4Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame4Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame4Entry2.Text != "x" || e.Key == Key.Enter && frame4Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame4Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame4Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame3Score(frame4Entry2.Text);
                textBoxEntry.UpdateFrame4Score(frame4Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame5Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame5Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame5Entry1.Text != "x" && frame5Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame3Score(frame5Entry1.Text);
                textBoxEntry.UpdateFrame4Score(frame5Entry1.Text);
                textBoxEntry.UpdateFrame5Score(frame5Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame5Entry1.Text == "x" || frame5Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame5Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame5Entry2.Text != "x" || e.Key == Key.Enter && frame5Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame5Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame5Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame4Score(frame5Entry2.Text);
                textBoxEntry.UpdateFrame5Score(frame5Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame6Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame6Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame6Entry1.Text != "x" && frame6Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame4Score(frame6Entry1.Text);
                textBoxEntry.UpdateFrame5Score(frame6Entry1.Text);
                textBoxEntry.UpdateFrame6Score(frame6Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame6Entry1.Text == "x" || frame6Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame6Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame6Entry2.Text != "x" || e.Key == Key.Enter && frame6Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame6Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame6Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame5Score(frame6Entry2.Text);
                textBoxEntry.UpdateFrame6Score(frame6Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame7Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame7Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame7Entry1.Text != "x" && frame7Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame5Score(frame7Entry1.Text);
                textBoxEntry.UpdateFrame6Score(frame7Entry1.Text);
                textBoxEntry.UpdateFrame7Score(frame7Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame7Entry1.Text == "x" || frame7Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame7Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame7Entry2.Text != "x" || e.Key == Key.Enter && frame7Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame7Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame7Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame6Score(frame7Entry2.Text);
                textBoxEntry.UpdateFrame7Score(frame7Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame8Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame8Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame8Entry1.Text != "x" && frame8Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame6Score(frame8Entry1.Text);
                textBoxEntry.UpdateFrame7Score(frame8Entry1.Text);
                textBoxEntry.UpdateFrame8Score(frame8Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame8Entry1.Text == "x" || frame8Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame8Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame8Entry2.Text != "x" || e.Key == Key.Enter && frame8Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame8Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame8Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame7Score(frame8Entry2.Text);
                textBoxEntry.UpdateFrame8Score(frame8Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame9Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame9Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame9Entry1.Text != "x" && frame9Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame7Score(frame9Entry1.Text);
                textBoxEntry.UpdateFrame8Score(frame9Entry1.Text);
                textBoxEntry.UpdateFrame9Score(frame9Entry1.Text);
                textBoxEntry.AdvanceTextBox();
                if (frame9Entry1.Text == "x" || frame9Entry1.Text == "X")
                {
                    textBoxEntry.AdvanceTextBox();
                }
            }
        }

        private void frame9Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && frame9Entry2.Text != "x" || e.Key == Key.Enter && frame9Entry2.Text != "X")
            {
                int test = 0;
                if (int.TryParse(frame9Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame9Entry2.Text != "/")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame8Score(frame9Entry2.Text);
                textBoxEntry.UpdateFrame9Score(frame9Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame10Entry1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame10Entry1.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame10Entry1.Text != "x" && frame10Entry1.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame8Score(frame10Entry1.Text);
                textBoxEntry.UpdateFrame9Score(frame10Entry1.Text);
                textBoxEntry.UpdateFrame10Score(frame10Entry1.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame10Entry2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame10Entry2.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, 'x', or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {

                    if (frame10Entry2.Text != "/" && frame10Entry2.Text != "x" && frame10Entry2.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, 'x', or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame9Score(frame10Entry2.Text);
                textBoxEntry.UpdateFrame10Score(frame10Entry2.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }

        private void frame10Entry3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int test = 0;
                if (int.TryParse(frame10Entry3.Text, out test))
                {
                    if (test < 0 || test > 9)
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                else
                {
                    if (frame10Entry3.Text != "x" && frame10Entry3.Text != "X")
                    {
                        MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                }
                textBoxEntry.canAdvance = true;
                textBoxEntry.UpdateFrame10Score(frame10Entry3.Text);
                textBoxEntry.AdvanceTextBox();
            }
        }
    }
}
