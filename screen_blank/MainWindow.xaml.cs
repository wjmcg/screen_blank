using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using sw = System.Windows;

namespace screen_blank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
            DataContext = new AppDataContext();
        }


        private void Init()
        {
            Screen leftMost = Screen.AllScreens[0];

            if (Screen.AllScreens.Length > 1)
            {
                foreach(Screen nextScreen in Screen.AllScreens)
                {
                    if (nextScreen.Bounds.Left < leftMost.Bounds.Left) leftMost = nextScreen;
                }

                Top = leftMost.Bounds.Top;
                Left = leftMost.Bounds.Left;
                Width = leftMost.Bounds.Width;
                Height = leftMost.Bounds.Height;
                Topmost = true;

            }
            else
            {
                Environment.Exit(1);
            }

        }



    }
}
