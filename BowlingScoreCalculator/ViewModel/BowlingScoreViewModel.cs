using BowlingScoreCalculator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
// Tathan Allen
namespace BowlingScoreCalculator.ViewModel
{
    public class BowlingScoreViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private SolidColorBrush _backgroundColor1;
        private SolidColorBrush _backgroundColor2;
        private SolidColorBrush _backgroundColor3;
        private SolidColorBrush _backgroundColor4;
        private SolidColorBrush _backgroundColor5;
        private SolidColorBrush _backgroundColor6;
        private SolidColorBrush _backgroundColor7;
        private SolidColorBrush _backgroundColor8;
        private SolidColorBrush _backgroundColor9;
        private SolidColorBrush _backgroundColor10;
        private SolidColorBrush _backgroundColor11;
        private SolidColorBrush _backgroundColor12;
        private SolidColorBrush _backgroundColor13;
        private SolidColorBrush _backgroundColor14;
        private SolidColorBrush _backgroundColor15;
        private SolidColorBrush _backgroundColor16;
        private SolidColorBrush _backgroundColor17;
        private SolidColorBrush _backgroundColor18;
        private SolidColorBrush _backgroundColor19;
        private SolidColorBrush _backgroundColor20;
        private SolidColorBrush _backgroundColor21;

        public bool canAdvance = true;

        private bool _frame1Entry1IsEnabled;
        private bool _frame1Entry2IsEnabled;
        private bool _frame2Entry1IsEnabled;
        private bool _frame2Entry2IsEnabled;
        private bool _frame3Entry1IsEnabled;
        private bool _frame3Entry2IsEnabled;
        private bool _frame4Entry1IsEnabled;
        private bool _frame4Entry2IsEnabled;
        private bool _frame5Entry1IsEnabled;
        private bool _frame5Entry2IsEnabled;
        private bool _frame6Entry1IsEnabled;
        private bool _frame6Entry2IsEnabled;
        private bool _frame7Entry1IsEnabled;
        private bool _frame7Entry2IsEnabled;
        private bool _frame8Entry1IsEnabled;
        private bool _frame8Entry2IsEnabled;
        private bool _frame9Entry1IsEnabled;
        private bool _frame9Entry2IsEnabled;
        private bool _frame10Entry1IsEnabled;
        private bool _frame10Entry2IsEnabled;
        private bool _frame10Entry3IsEnabled;

        public FrameScore frame1;
        public FrameScore frame2;
        public FrameScore frame3;
        public FrameScore frame4;
        public FrameScore frame5;
        public FrameScore frame6;
        public FrameScore frame7;
        public FrameScore frame8;
        public FrameScore frame9;
        public FrameScore frame10;
        public FrameScore totalScore;

        public BowlingScoreViewModel()
        {
            Frame1Entry1IsEnabled = true;
            Frame1Entry2IsEnabled = false;
            Frame2Entry1IsEnabled = false;
            Frame2Entry2IsEnabled = false;
            Frame3Entry1IsEnabled = false;
            Frame3Entry2IsEnabled = false;
            Frame4Entry1IsEnabled = false;
            Frame4Entry2IsEnabled = false;
            Frame5Entry1IsEnabled = false;
            Frame5Entry2IsEnabled = false;
            Frame6Entry1IsEnabled = false;
            Frame6Entry2IsEnabled = false;
            Frame7Entry1IsEnabled = false;
            Frame7Entry2IsEnabled = false;
            Frame8Entry1IsEnabled = false;
            Frame8Entry2IsEnabled = false;
            Frame9Entry1IsEnabled = false;
            Frame9Entry2IsEnabled = false;
            Frame10Entry1IsEnabled = false;
            Frame10Entry2IsEnabled = false;
            Frame10Entry3IsEnabled = false;

            frame1 = new FrameScore();
            frame2 = new FrameScore();
            frame3 = new FrameScore();
            frame4 = new FrameScore();
            frame5 = new FrameScore();
            frame6 = new FrameScore();
            frame7 = new FrameScore();
            frame8 = new FrameScore();
            frame9 = new FrameScore();
            frame10 = new FrameScore();
            totalScore = new FrameScore();
            frame1.FirstRollCompleted = false;
            frame2.FirstRollCompleted = false;
            frame3.FirstRollCompleted = false;
            frame4.FirstRollCompleted = false;
            frame5.FirstRollCompleted = false;
            frame6.FirstRollCompleted = false;
            frame7.FirstRollCompleted = false;
            frame8.FirstRollCompleted = false;
            frame9.FirstRollCompleted = false;
            frame10.FirstRollCompleted = false;
            frame1.SecondRollCompleted = false;
            frame2.SecondRollCompleted = false;
            frame3.SecondRollCompleted = false;
            frame4.SecondRollCompleted = false;
            frame5.SecondRollCompleted = false;
            frame6.SecondRollCompleted = false;
            frame7.SecondRollCompleted = false;
            frame8.SecondRollCompleted = false;
            frame9.SecondRollCompleted = false;
            frame10.SecondRollCompleted = false;
            frame1.UseThirdRoll = false;
            frame2.UseThirdRoll = false;
            frame3.UseThirdRoll = false;
            frame4.UseThirdRoll = false;
            frame5.UseThirdRoll = false;
            frame6.UseThirdRoll = false;
            frame7.UseThirdRoll = false;
            frame8.UseThirdRoll = false;
            frame9.UseThirdRoll = false;
            frame10.UseThirdRoll = false;

            BackgroundColor1 = Brushes.LightGray;
        }

        public void AdvanceTextBox()
        {
            if (canAdvance)
            {
                if (Frame1Entry1IsEnabled)
                {
                    Frame1Entry1IsEnabled = false;
                    Frame1Entry2IsEnabled = true;
                    BackgroundColor1 = Brushes.White;
                    BackgroundColor2 = Brushes.LightGray;
                }
                else if (Frame1Entry2IsEnabled)
                {
                    Frame1Entry2IsEnabled = false;
                    Frame2Entry1IsEnabled = true;
                    BackgroundColor2 = Brushes.White;
                    BackgroundColor3 = Brushes.LightGray;
                }
                else if (Frame2Entry1IsEnabled)
                {
                    Frame2Entry1IsEnabled = false;
                    Frame2Entry2IsEnabled = true;
                    BackgroundColor3 = Brushes.White;
                    BackgroundColor4 = Brushes.LightGray;
                }
                else if (Frame2Entry2IsEnabled)
                {
                    Frame2Entry2IsEnabled = false;
                    Frame3Entry1IsEnabled = true;
                    BackgroundColor4 = Brushes.White;
                    BackgroundColor5 = Brushes.LightGray;
                }
                else if (Frame3Entry1IsEnabled)
                {
                    Frame3Entry1IsEnabled = false;
                    Frame3Entry2IsEnabled = true;
                    BackgroundColor5 = Brushes.White;
                    BackgroundColor6 = Brushes.LightGray;
                }
                else if (Frame3Entry2IsEnabled)
                {
                    Frame3Entry2IsEnabled = false;
                    Frame4Entry1IsEnabled = true;
                    BackgroundColor6 = Brushes.White;
                    BackgroundColor7 = Brushes.LightGray;
                }
                else if (Frame4Entry1IsEnabled)
                {
                    Frame4Entry1IsEnabled = false;
                    Frame4Entry2IsEnabled = true;
                    BackgroundColor7 = Brushes.White;
                    BackgroundColor8 = Brushes.LightGray;
                }
                else if (Frame4Entry2IsEnabled)
                {
                    Frame4Entry2IsEnabled = false;
                    Frame5Entry1IsEnabled = true;
                    BackgroundColor8 = Brushes.White;
                    BackgroundColor9 = Brushes.LightGray;
                }
                else if (Frame5Entry1IsEnabled)
                {
                    Frame5Entry1IsEnabled = false;
                    Frame5Entry2IsEnabled = true;
                    BackgroundColor9 = Brushes.White;
                    BackgroundColor10 = Brushes.LightGray;
                }
                else if (Frame5Entry2IsEnabled)
                {
                    Frame5Entry2IsEnabled = false;
                    Frame6Entry1IsEnabled = true;
                    BackgroundColor10 = Brushes.White;
                    BackgroundColor11 = Brushes.LightGray;
                }
                else if (Frame6Entry1IsEnabled)
                {
                    Frame6Entry1IsEnabled = false;
                    Frame6Entry2IsEnabled = true;
                    BackgroundColor11 = Brushes.White;
                    BackgroundColor12 = Brushes.LightGray;
                }
                else if (Frame6Entry2IsEnabled)
                {
                    Frame6Entry2IsEnabled = false;
                    Frame7Entry1IsEnabled = true;
                    BackgroundColor12 = Brushes.White;
                    BackgroundColor13 = Brushes.LightGray;
                }
                else if (Frame7Entry1IsEnabled)
                {
                    Frame7Entry1IsEnabled = false;
                    Frame7Entry2IsEnabled = true;
                    BackgroundColor13 = Brushes.White;
                    BackgroundColor14 = Brushes.LightGray;
                }
                else if (Frame7Entry2IsEnabled)
                {
                    Frame7Entry2IsEnabled = false;
                    Frame8Entry1IsEnabled = true;
                    BackgroundColor14 = Brushes.White;
                    BackgroundColor15 = Brushes.LightGray;
                }
                else if (Frame8Entry1IsEnabled)
                {
                    Frame8Entry1IsEnabled = false;
                    Frame8Entry2IsEnabled = true;
                    BackgroundColor15 = Brushes.White;
                    BackgroundColor16 = Brushes.LightGray;
                }
                else if (Frame8Entry1IsEnabled)
                {
                    Frame8Entry1IsEnabled = false;
                    Frame8Entry2IsEnabled = true;
                    BackgroundColor16 = Brushes.White;
                    BackgroundColor17 = Brushes.LightGray;
                }
                else if (Frame8Entry2IsEnabled)
                {
                    Frame8Entry2IsEnabled = false;
                    Frame9Entry1IsEnabled = true;
                    BackgroundColor16 = Brushes.White;
                    BackgroundColor17 = Brushes.LightGray;
                }
                else if (Frame9Entry1IsEnabled)
                {
                    Frame9Entry1IsEnabled = false;
                    Frame9Entry2IsEnabled = true;
                    BackgroundColor17 = Brushes.White;
                    BackgroundColor18 = Brushes.LightGray;
                }
                else if (Frame9Entry2IsEnabled)
                {
                    Frame9Entry2IsEnabled = false;
                    Frame10Entry1IsEnabled = true;
                    BackgroundColor18 = Brushes.White;
                    BackgroundColor19 = Brushes.LightGray;
                }
                else if (Frame10Entry1IsEnabled)
                {
                    Frame10Entry1IsEnabled = false;
                    Frame10Entry2IsEnabled = true;
                    BackgroundColor19 = Brushes.White;
                    BackgroundColor20 = Brushes.LightGray;
                }
                else if (Frame10Entry2IsEnabled)
                {
                    Frame10Entry2IsEnabled = false;
                    Frame10Entry3IsEnabled = true;
                    BackgroundColor20 = Brushes.White;
                    BackgroundColor21 = Brushes.LightGray;
                }
            }
        }

        
        
        public void ResetScoring()
        {
            Frame1Entry1IsEnabled = true;
            Frame1Entry2IsEnabled = false;
            Frame2Entry1IsEnabled = false;
            Frame2Entry2IsEnabled = false;
            Frame3Entry1IsEnabled = false;
            Frame3Entry2IsEnabled = false;
            Frame4Entry1IsEnabled = false;
            Frame4Entry2IsEnabled = false;
            Frame5Entry1IsEnabled = false;
            Frame5Entry2IsEnabled = false;
            Frame6Entry1IsEnabled = false;
            Frame6Entry2IsEnabled = false;
            Frame7Entry1IsEnabled = false;
            Frame7Entry2IsEnabled = false;
            Frame8Entry1IsEnabled = false;
            Frame8Entry2IsEnabled = false;
            Frame9Entry1IsEnabled = false;
            Frame9Entry2IsEnabled = false;
            Frame10Entry1IsEnabled = false;
            Frame10Entry2IsEnabled = false;
            Frame10Entry3IsEnabled = false;
            frame1.FirstRollCompleted = false;
            frame2.FirstRollCompleted = false;
            frame3.FirstRollCompleted = false;
            frame4.FirstRollCompleted = false;
            frame5.FirstRollCompleted = false;
            frame6.FirstRollCompleted = false;
            frame7.FirstRollCompleted = false;
            frame8.FirstRollCompleted = false;
            frame9.FirstRollCompleted = false;
            frame10.FirstRollCompleted = false;
            frame1.SecondRollCompleted = false;
            frame2.SecondRollCompleted = false;
            frame3.SecondRollCompleted = false;
            frame4.SecondRollCompleted = false;
            frame5.SecondRollCompleted = false;
            frame6.SecondRollCompleted = false;
            frame7.SecondRollCompleted = false;
            frame8.SecondRollCompleted = false;
            frame9.SecondRollCompleted = false;
            frame10.SecondRollCompleted = false;
            frame1.UseThirdRoll = false;
            frame2.UseThirdRoll = false;
            frame3.UseThirdRoll = false;
            frame4.UseThirdRoll = false;
            frame5.UseThirdRoll = false;
            frame6.UseThirdRoll = false;
            frame7.UseThirdRoll = false;
            frame8.UseThirdRoll = false;
            frame9.UseThirdRoll = false;
            frame10.UseThirdRoll = false;
            frame1.RollOne = 0;
            frame2.RollOne = 0;
            frame3.RollOne = 0;
            frame4.RollOne = 0;
            frame5.RollOne = 0;
            frame6.RollOne = 0;
            frame7.RollOne = 0;
            frame8.RollOne = 0;
            frame9.RollOne = 0;
            frame10.RollOne = 0;
            frame1.RollTwo = 0;
            frame2.RollTwo = 0;
            frame3.RollTwo = 0;
            frame4.RollTwo = 0;
            frame5.RollTwo = 0;
            frame6.RollTwo = 0;
            frame7.RollTwo = 0;
            frame8.RollTwo = 0;
            frame9.RollTwo = 0;
            frame10.RollTwo = 0;
            frame1.RollThree = 0;
            frame2.RollThree = 0;
            frame3.RollThree = 0;
            frame4.RollThree = 0;
            frame5.RollThree = 0;
            frame6.RollThree = 0;
            frame7.RollThree = 0;
            frame8.RollThree = 0;
            frame9.RollThree = 0;
            frame10.RollThree = 0;
            frame1.FrameTotal = 0;
            frame2.FrameTotal = 0;
            frame3.FrameTotal = 0;
            frame4.FrameTotal = 0;
            frame5.FrameTotal = 0;
            frame6.FrameTotal = 0;
            frame7.FrameTotal = 0;
            frame8.FrameTotal = 0;
            frame9.FrameTotal = 0;
            frame10.FrameTotal = 0;
            frame1.FrameComplete = false;
            frame2.FrameComplete = false;
            frame3.FrameComplete = false;
            frame4.FrameComplete = false;
            frame5.FrameComplete = false;
            frame6.FrameComplete = false;
            frame7.FrameComplete = false;
            frame8.FrameComplete = false;
            frame9.FrameComplete = false;
            frame10.FrameComplete = false;
            frame1.Score = null;
            frame2.Score = null;
            frame3.Score = null;
            frame4.Score = null;
            frame5.Score = null;
            frame6.Score = null;
            frame7.Score = null;
            frame8.Score = null;
            frame9.Score = null;
            frame10.Score = null;
            Frame1Score = "";
            Frame2Score = "";
            Frame3Score = "";
            Frame4Score = "";
            Frame5Score = "";
            Frame6Score = "";
            Frame7Score = "";
            Frame8Score = "";
            Frame9Score = "";
            Frame10Score = "";
            BackgroundColor1 = Brushes.LightGray;
            BackgroundColor2 = Brushes.White;
            BackgroundColor3 = Brushes.White;
            BackgroundColor4 = Brushes.White;
            BackgroundColor5 = Brushes.White;
            BackgroundColor6 = Brushes.White;
            BackgroundColor7 = Brushes.White;
            BackgroundColor8 = Brushes.White;
            BackgroundColor9 = Brushes.White;
            BackgroundColor10 = Brushes.White;
            BackgroundColor11 = Brushes.White;
            BackgroundColor12 = Brushes.White;
            BackgroundColor13 = Brushes.White;
            BackgroundColor14 = Brushes.White;
            BackgroundColor15 = Brushes.White;
            BackgroundColor16 = Brushes.White;
            BackgroundColor17 = Brushes.White;
            BackgroundColor18 = Brushes.White;
            BackgroundColor19 = Brushes.White;
            BackgroundColor20 = Brushes.White;
            BackgroundColor21 = Brushes.White;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Frame1Entry1IsEnabled
        {
            get { return _frame1Entry1IsEnabled;}
            set
            {
                if (_frame1Entry1IsEnabled != value)
                {
                    _frame1Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame1Entry2IsEnabled
        {
            get { return _frame1Entry2IsEnabled; }
            set
            {
                if (_frame1Entry2IsEnabled != value)
                {
                    _frame1Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame2Entry1IsEnabled
        {
            get { return _frame2Entry1IsEnabled; }
            set
            {
                if (_frame2Entry1IsEnabled != value)
                {
                    _frame2Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame2Entry2IsEnabled
        {
            get { return _frame2Entry2IsEnabled; }
            set
            {
                if (_frame2Entry2IsEnabled != value)
                {
                    _frame2Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame3Entry1IsEnabled
        {
            get { return _frame3Entry1IsEnabled; }
            set
            {
                if (_frame3Entry1IsEnabled != value)
                {
                    _frame3Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame3Entry2IsEnabled
        {
            get { return _frame3Entry2IsEnabled; }
            set
            {
                if (_frame3Entry2IsEnabled != value)
                {
                    _frame3Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame4Entry1IsEnabled
        {
            get { return _frame4Entry1IsEnabled; }
            set
            {
                if (_frame4Entry1IsEnabled != value)
                {
                    _frame4Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame4Entry2IsEnabled
        {
            get { return _frame4Entry2IsEnabled; }
            set
            {
                if (_frame4Entry2IsEnabled != value)
                {
                    _frame4Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame5Entry1IsEnabled
        {
            get { return _frame5Entry1IsEnabled; }
            set
            {
                if (_frame5Entry1IsEnabled != value)
                {
                    _frame5Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame5Entry2IsEnabled
        {
            get { return _frame5Entry2IsEnabled; }
            set
            {
                if (_frame5Entry2IsEnabled != value)
                {
                    _frame5Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame6Entry1IsEnabled
        {
            get { return _frame6Entry1IsEnabled; }
            set
            {
                if (_frame6Entry1IsEnabled != value)
                {
                    _frame6Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame6Entry2IsEnabled
        {
            get { return _frame6Entry2IsEnabled; }
            set
            {
                if (_frame6Entry2IsEnabled != value)
                {
                    _frame6Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame7Entry1IsEnabled
        {
            get { return _frame7Entry1IsEnabled; }
            set
            {
                if (_frame7Entry1IsEnabled != value)
                {
                    _frame7Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame7Entry2IsEnabled
        {
            get { return _frame7Entry2IsEnabled; }
            set
            {
                if (_frame7Entry2IsEnabled != value)
                {
                    _frame7Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame8Entry1IsEnabled
        {
            get { return _frame8Entry1IsEnabled; }
            set
            {
                if (_frame8Entry1IsEnabled != value)
                {
                    _frame8Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame8Entry2IsEnabled
        {
            get { return _frame8Entry2IsEnabled; }
            set
            {
                if (_frame8Entry2IsEnabled != value)
                {
                    _frame8Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame9Entry1IsEnabled
        {
            get { return _frame9Entry1IsEnabled; }
            set
            {
                if (_frame9Entry1IsEnabled != value)
                {
                    _frame9Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame9Entry2IsEnabled
        {
            get { return _frame9Entry2IsEnabled; }
            set
            {
                if (_frame9Entry2IsEnabled != value)
                {
                    _frame9Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame10Entry1IsEnabled
        {
            get { return _frame10Entry1IsEnabled; }
            set
            {
                if (_frame10Entry1IsEnabled != value)
                {
                    _frame10Entry1IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame10Entry2IsEnabled
        {
            get { return _frame10Entry2IsEnabled; }
            set
            {
                if (_frame10Entry2IsEnabled != value)
                {
                    _frame10Entry2IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Frame10Entry3IsEnabled
        {
            get { return _frame10Entry3IsEnabled; }
            set
            {
                if (_frame10Entry3IsEnabled != value)
                {
                    _frame10Entry3IsEnabled = value;
                    OnPropertyChanged();
                }
            }
        }

        public string? Frame1Score
        {
            get { return frame1.Score; }
            set
            {
                if (frame1.Score != value)
                {
                    frame1.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame2Score
        {
            get { return frame2.Score; }
            set
            {
                if (frame2.Score != value)
                {
                    frame2.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame3Score
        {
            get { return frame3.Score; }
            set
            {
                if (frame3.Score != value)
                {
                    frame3.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame4Score
        {
            get { return frame4.Score; }
            set
            {
                if (frame4.Score != value)
                {
                    frame4.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame5Score
        {
            get { return frame5.Score; }
            set
            {
                if (frame5.Score != value)
                {
                    frame5.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame6Score
        {
            get { return frame6.Score; }
            set
            {
                if (frame6.Score != value)
                {
                    frame6.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame7Score
        {
            get { return frame7.Score; }
            set
            {
                if (frame7.Score != value)
                {
                    frame7.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame8Score
        {
            get { return frame8.Score; }
            set
            {
                if (frame8.Score != value)
                {
                    frame8.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame9Score
        {
            get { return frame9.Score; }
            set
            {
                if (frame9.Score != value)
                {
                    frame9.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? Frame10Score
        {
            get { return frame10.Score; }
            set
            {
                if (frame10.Score != value)
                {
                    frame10.Score = value;
                    OnPropertyChanged();
                }
            }
        }
        public string? TotalScore
        {
            get { return totalScore.Score; }
            set
            {
                if (totalScore.Score != value)
                {
                    totalScore.Score = value;
                    OnPropertyChanged();
                }
            }
        }

        public void UpdateFrame1Score(string entry)
        {
            if (!frame1.FrameComplete)
            {
                int entryNum = 0;

                if (!frame1.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            frame1.RollOne = entryNum;
                            
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            frame1.RollOne = 10;
                            //AdvanceTextBox();
                            frame1.UseThirdRoll = true;
                        }
                    }
                    frame1.FirstRollCompleted = true;
                }
                else if (frame1.FirstRollCompleted && !frame1.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            if (!frame1.UseThirdRoll && frame1.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame1.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                return;
                            }
                            frame1.RollTwo = entryNum;
                            
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame1.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame1.RollTwo = 10 - frame1.RollOne;
                            }
                        }
                    }
                    if (frame1.RollOne + frame1.RollTwo == 10)
                    {
                        frame1.UseThirdRoll = true;
                    }
                    frame1.SecondRollCompleted = true;
                }
                else if (frame1.SecondRollCompleted && frame1.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            frame1.RollThree = entryNum;
                            frame1.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame1.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame1.RollThree = 10 - frame1.RollTwo;
                            }
                        }
                    }
                    frame1.FrameComplete = true;
                }
                if (frame1.SecondRollCompleted && !frame1.UseThirdRoll)
                {
                    frame1.FrameComplete = true;
                }
                frame1.FrameTotal = frame1.RollOne + frame1.RollTwo + frame1.RollThree;
                Frame1Score = frame1.FrameTotal.ToString();
                //AdvanceTextBox();
            }
            
        }
        public void UpdateFrame2Score(string entry)
        {
            if (!frame2.FrameComplete)
            {
                int entryNum = 0;

                if (!frame2.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame2.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame2.RollOne = 10;
                            //AdvanceTextBox();
                            frame2.UseThirdRoll = true;
                        }
                    }
                    frame2.FirstRollCompleted = true;
                }
                else if (frame2.FirstRollCompleted && !frame2.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame2.UseThirdRoll && frame2.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame2.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame2.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame2.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame2.RollTwo = 10 - frame2.RollOne;
                            }
                        }
                    }
                    if (frame2.RollOne + frame2.RollTwo == 10)
                    {
                        frame2.UseThirdRoll = true;
                    }
                    frame2.SecondRollCompleted = true;
                }
                else if (frame2.SecondRollCompleted && frame2.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame2.RollThree = entryNum;
                            frame2.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame2.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame2.RollThree = 10 - frame2.RollTwo;
                            }
                        }
                    }
                    frame2.FrameComplete = true;
                }
                if (frame2.SecondRollCompleted && !frame2.UseThirdRoll)
                {
                    frame2.FrameComplete = true;
                }
                frame2.FrameTotal = frame2.RollOne + frame2.RollTwo + frame2.RollThree + frame1.FrameTotal;
                Frame2Score = frame2.FrameTotal.ToString();
                //AdvanceTextBox();
            }
            
        }
        public void UpdateFrame3Score(string entry)
        {
            if (!frame3.FrameComplete)
            {
                int entryNum = 0;

                if (!frame3.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame3.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame3.RollOne = 10;
                            //AdvanceTextBox();
                            frame3.UseThirdRoll = true;
                        }
                    }
                    frame3.FirstRollCompleted = true;
                }
                else if (frame3.FirstRollCompleted && !frame3.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame3.UseThirdRoll && frame3.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame3.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame3.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame3.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame3.RollTwo = 10 - frame3.RollOne;
                            }
                        }
                    }
                    if (frame3.RollOne + frame3.RollTwo == 10)
                    {
                        frame3.UseThirdRoll = true;
                    }
                    frame3.SecondRollCompleted = true;
                }
                else if (frame3.SecondRollCompleted && frame3.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame3.RollThree = entryNum;
                            frame3.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame3.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame3.RollThree = 10 - frame3.RollTwo;
                            }
                        }
                    }
                    frame3.FrameComplete = true;
                }
                if (frame3.SecondRollCompleted && !frame3.UseThirdRoll)
                {
                    frame3.FrameComplete = true;
                }
                frame3.FrameTotal = frame3.RollOne + frame3.RollTwo + frame3.RollThree + frame2.FrameTotal;
                Frame3Score = frame3.FrameTotal.ToString();
                //AdvanceTextBox();
            }
            
        }
        public void UpdateFrame4Score(string entry)
        {
            if (!frame4.FrameComplete)
            {
                int entryNum = 0;

                if (!frame4.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame4.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame4.RollOne = 10;
                            //AdvanceTextBox();
                            frame4.UseThirdRoll = true;
                        }
                    }
                    frame4.FirstRollCompleted = true;
                }
                else if (frame4.FirstRollCompleted && !frame4.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame4.UseThirdRoll && frame4.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame4.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame4.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame4.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame4.RollTwo = 10 - frame4.RollOne;
                            }
                        }
                    }
                    if (frame4.RollOne + frame4.RollTwo == 10)
                    {
                        frame4.UseThirdRoll = true;
                    }
                    frame4.SecondRollCompleted = true;
                }
                else if (frame4.SecondRollCompleted && frame4.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame4.RollThree = entryNum;
                            frame4.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame4.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame4.RollThree = 10 - frame4.RollTwo;
                            }
                        }
                    }
                    frame4.FrameComplete = true;
                }
                if (frame4.SecondRollCompleted && !frame4.UseThirdRoll)
                {
                    frame4.FrameComplete = true;
                }
                frame4.FrameTotal = frame4.RollOne + frame4.RollTwo + frame4.RollThree + frame3.FrameTotal;
                Frame4Score = frame4.FrameTotal.ToString();
                //AdvanceTextBox();
            }
            
        }
        public void UpdateFrame5Score(string entry)
        {
            if (!frame5.FrameComplete)
            {
                int entryNum = 0;

                if (!frame5.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame5.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame5.RollOne = 10;
                            //AdvanceTextBox();
                            frame5.UseThirdRoll = true;
                        }
                    }
                    frame5.FirstRollCompleted = true;
                }
                else if (frame5.FirstRollCompleted && !frame5.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame5.UseThirdRoll && frame5.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame5.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame5.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame5.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame5.RollTwo = 10 - frame5.RollOne;
                            }
                        }
                    }
                    if (frame5.RollOne + frame5.RollTwo == 10)
                    {
                        frame5.UseThirdRoll = true;
                    }
                    frame5.SecondRollCompleted = true;
                }
                else if (frame5.SecondRollCompleted && frame5.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame5.RollThree = entryNum;
                            frame5.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame5.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame5.RollThree = 10 - frame5.RollTwo;
                            }
                        }
                    }
                    frame5.FrameComplete = true;
                }
                if (frame5.SecondRollCompleted && !frame5.UseThirdRoll)
                {
                    frame5.FrameComplete = true;
                }
                frame5.FrameTotal = frame5.RollOne + frame5.RollTwo + frame5.RollThree + frame4.FrameTotal;
                Frame5Score = frame5.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public void UpdateFrame6Score(string entry)
        {
            if (!frame6.FrameComplete)
            {
                int entryNum = 0;

                if (!frame6.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame6.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame6.RollOne = 10;
                            //AdvanceTextBox();
                            frame6.UseThirdRoll = true;
                        }
                    }
                    frame6.FirstRollCompleted = true;
                }
                else if (frame6.FirstRollCompleted && !frame6.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame6.UseThirdRoll && frame6.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame6.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame6.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame6.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame6.RollTwo = 10 - frame6.RollOne;
                            }
                        }
                    }
                    if (frame6.RollOne + frame6.RollTwo == 10)
                    {
                        frame6.UseThirdRoll = true;
                    }
                    frame6.SecondRollCompleted = true;
                }
                else if (frame6.SecondRollCompleted && frame6.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame6.RollThree = entryNum;
                            frame6.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame6.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame6.RollThree = 10 - frame6.RollTwo;
                            }
                        }
                    }
                    frame6.FrameComplete = true;
                }
                if (frame6.SecondRollCompleted && !frame6.UseThirdRoll)
                {
                    frame6.FrameComplete = true;
                }
                frame6.FrameTotal = frame6.RollOne + frame6.RollTwo + frame6.RollThree + frame5.FrameTotal;
                Frame6Score = frame6.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public void UpdateFrame7Score(string entry)
        {
            if (!frame7.FrameComplete)
            {
                int entryNum = 0;

                if (!frame7.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame7.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame7.RollOne = 10;
                            //AdvanceTextBox();
                            frame7.UseThirdRoll = true;
                        }
                    }
                    frame7.FirstRollCompleted = true;
                }
                else if (frame7.FirstRollCompleted && !frame7.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame7.UseThirdRoll && frame7.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame7.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame7.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame7.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame7.RollTwo = 10 - frame7.RollOne;
                            }
                        }
                    }
                    if (frame7.RollOne + frame7.RollTwo == 10)
                    {
                        frame7.UseThirdRoll = true;
                    }
                    frame7.SecondRollCompleted = true;
                }
                else if (frame7.SecondRollCompleted && frame7.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame7.RollThree = entryNum;
                            frame7.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame7.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame7.RollThree = 10 - frame7.RollTwo;
                            }
                        }
                    }
                    frame7.FrameComplete = true;
                }
                if (frame7.SecondRollCompleted && !frame7.UseThirdRoll)
                {
                    frame7.FrameComplete = true;
                }
                frame7.FrameTotal = frame7.RollOne + frame7.RollTwo + frame7.RollThree + frame6.FrameTotal;
                Frame7Score = frame7.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public void UpdateFrame8Score(string entry)
        {
            if (!frame8.FrameComplete)
            {
                int entryNum = 0;

                if (!frame8.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame8.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame8.RollOne = 10;
                            //AdvanceTextBox();
                            frame8.UseThirdRoll = true;
                        }
                    }
                    frame8.FirstRollCompleted = true;
                }
                else if (frame8.FirstRollCompleted && !frame8.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame8.UseThirdRoll && frame8.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame8.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame8.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame8.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame8.RollTwo = 10 - frame8.RollOne;
                            }
                        }
                    }
                    if (frame8.RollOne + frame8.RollTwo == 10)
                    {
                        frame8.UseThirdRoll = true;
                    }
                    frame8.SecondRollCompleted = true;
                }
                else if (frame8.SecondRollCompleted && frame8.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame8.RollThree = entryNum;
                            frame8.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame8.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame8.RollThree = 10 - frame8.RollTwo;
                            }
                        }
                    }
                    frame8.FrameComplete = true;
                }
                if (frame8.SecondRollCompleted && !frame8.UseThirdRoll)
                {
                    frame8.FrameComplete = true;
                }
                frame8.FrameTotal = frame8.RollOne + frame8.RollTwo + frame8.RollThree + frame7.FrameTotal;
                Frame8Score = frame8.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public void UpdateFrame9Score(string entry)
        {
            if (!frame9.FrameComplete)
            {
                int entryNum = 0;

                if (!frame9.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame9.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame9.RollOne = 10;
                            //AdvanceTextBox();
                            frame9.UseThirdRoll = true;
                        }
                    }
                    frame9.FirstRollCompleted = true;
                }
                else if (frame9.FirstRollCompleted && !frame9.SecondRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (!frame9.UseThirdRoll && frame9.RollOne + entryNum > 10)
                            {
                                int difference = 10 - frame9.RollOne + 1;
                                MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            frame9.RollTwo = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame9.RollTwo = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame9.RollTwo = 10 - frame9.RollOne;
                            }
                        }
                    }
                    if (frame9.RollOne + frame9.RollTwo == 10)
                    {
                        frame9.UseThirdRoll = true;
                    }
                    frame9.SecondRollCompleted = true;
                }
                else if (frame9.SecondRollCompleted && frame9.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame9.RollThree = entryNum;
                            frame9.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X" && entry != "/")
                        {
                            MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            if (entry == "x" || entry == "X")
                            {
                                frame9.RollThree = 10;
                                //AdvanceTextBox();
                            }
                            else if (entry == "/")
                            {
                                frame9.RollThree = 10 - frame9.RollTwo;
                            }
                        }
                    }
                    frame9.FrameComplete = true;
                }
                if (frame9.SecondRollCompleted && !frame9.UseThirdRoll)
                {
                    frame9.FrameComplete = true;
                }
                frame9.FrameTotal = frame9.RollOne + frame9.RollTwo + frame9.RollThree + frame8.FrameTotal;
                Frame9Score = frame9.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public void UpdateFrame10Score(string entry)
        {
            if (!frame10.FrameComplete)
            {
                int entryNum = 0;

                if (!frame10.FirstRollCompleted)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame10.RollOne = entryNum;

                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame10.RollOne = 10;
                            //AdvanceTextBox();
                            frame10.UseThirdRoll = true;
                        }
                    }
                    frame10.FirstRollCompleted = true;
                }
                else if (frame10.FirstRollCompleted && !frame10.SecondRollCompleted)
                {
                    if (frame10.RollOne == 10)
                    {
                        if (int.TryParse(entry, out entryNum)) //entry is an integer
                        {
                            if (entryNum < 0 || entryNum > 9)
                            {
                                MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            else
                            {
                                frame10.RollTwo = entryNum;
                            }
                        }
                        else //entry is a string
                        {
                            if (entry != "x" && entry != "X")
                            {
                                MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            else
                            {
                                frame10.RollTwo = 10;
                                //AdvanceTextBox();
                                frame10.UseThirdRoll = true;
                            }
                        }
                        frame10.SecondRollCompleted = true;
                    }
                    else
                    {
                        if (int.TryParse(entry, out entryNum)) //entry is an integer
                        {
                            if (entryNum < 0 || entryNum > 9)
                            {
                                MessageBox.Show("Must enter an integer 0-9, or 'x'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            else
                            {
                                if (!frame10.UseThirdRoll && frame10.RollOne + entryNum > 10)
                                {
                                    int difference = 10 - frame10.RollOne + 1;
                                    MessageBox.Show("Entry must be lower than " + difference + " or '/'", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                    canAdvance = false;
                                    return;
                                }
                                frame10.RollTwo = entryNum;

                            }
                        }
                        else //entry is a string
                        {
                            if (entry != "x" && entry != "X" && entry != "/")
                            {
                                MessageBox.Show("Must enter an integer 0-9, 'x' on roll one, or '/' on roll two", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                                canAdvance = false;
                                return;
                            }
                            else
                            {
                                if (entry == "x" || entry == "X")
                                {
                                    frame10.RollTwo = 10;
                                    //AdvanceTextBox();
                                }
                                else if (entry == "/")
                                {
                                    frame10.RollTwo = 10 - frame10.RollOne;
                                }
                            }
                        }
                        if (frame10.RollOne + frame10.RollTwo == 10)
                        {
                            frame10.UseThirdRoll = true;
                        }
                        frame10.SecondRollCompleted = true;
                    }
                }
                else if (frame10.SecondRollCompleted && frame10.UseThirdRoll)
                {
                    if (int.TryParse(entry, out entryNum)) //entry is an integer
                    {
                        if (entryNum < 0 || entryNum > 9)
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'.", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame10.RollThree = entryNum;
                            frame10.FirstRollCompleted = true;
                        }
                    }
                    else //entry is a string
                    {
                        if (entry != "x" && entry != "X")
                        {
                            MessageBox.Show("Must enter an integer 0-9, or 'x'.", "Invalid Entry", MessageBoxButton.OK, MessageBoxImage.Error);
                            canAdvance = false;
                            return;
                        }
                        else
                        {
                            frame10.RollThree = 10;
                        }
                    }
                    frame10.FrameComplete = true;
                }
                if (frame10.SecondRollCompleted && !frame10.UseThirdRoll)
                {
                    frame10.FrameComplete = true;
                }
                frame10.FrameTotal = frame10.RollOne + frame10.RollTwo + frame10.RollThree + frame9.FrameTotal;
                Frame10Score = frame10.FrameTotal.ToString();
                //AdvanceTextBox();
            }

        }
        public SolidColorBrush BackgroundColor1
        {
            get { return _backgroundColor1; }
            set
            {
                _backgroundColor1 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor2
        {
            get { return _backgroundColor2; }
            set
            {
                _backgroundColor2 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor3
        {
            get { return _backgroundColor3; }
            set
            {
                _backgroundColor3 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor4
        {
            get { return _backgroundColor4; }
            set
            {
                _backgroundColor4 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor5
        {
            get { return _backgroundColor5; }
            set
            {
                _backgroundColor5 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor6
        {
            get { return _backgroundColor6; }
            set
            {
                _backgroundColor6 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor7
        {
            get { return _backgroundColor7; }
            set
            {
                _backgroundColor7 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor8
        {
            get { return _backgroundColor8; }
            set
            {
                _backgroundColor8 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor9
        {
            get { return _backgroundColor9; }
            set
            {
                _backgroundColor9 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor10
        {
            get { return _backgroundColor10; }
            set
            {
                _backgroundColor10 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor11
        {
            get { return _backgroundColor11; }
            set
            {
                _backgroundColor11 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor12
        {
            get { return _backgroundColor12; }
            set
            {
                _backgroundColor12 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor13
        {
            get { return _backgroundColor13; }
            set
            {
                _backgroundColor13 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor14
        {
            get { return _backgroundColor14; }
            set
            {
                _backgroundColor14 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor15
        {
            get { return _backgroundColor15; }
            set
            {
                _backgroundColor15 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor16
        {
            get { return _backgroundColor16; }
            set
            {
                _backgroundColor16 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor17
        {
            get { return _backgroundColor17; }
            set
            {
                _backgroundColor17 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor18
        {
            get { return _backgroundColor18; }
            set
            {
                _backgroundColor18 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor19
        {
            get { return _backgroundColor19; }
            set
            {
                _backgroundColor19 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor20
        {
            get { return _backgroundColor20; }
            set
            {
                _backgroundColor20 = value;
                OnPropertyChanged();
            }
        }
        public SolidColorBrush BackgroundColor21
        {
            get { return _backgroundColor21; }
            set
            {
                _backgroundColor21 = value;
                OnPropertyChanged();
            }
        }
    }
}
