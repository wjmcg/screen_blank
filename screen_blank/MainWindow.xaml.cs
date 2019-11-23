using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using sw = System.Windows;
using System.Threading.Tasks;

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

            InitTask();

        }


        void InitTask()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    Dispatcher.Invoke(() => Init());
                    await Task.Delay(1000);
                }
            });
        }


        private void Init()
        {
            Cursor = sw.Input.Cursors.None;

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
