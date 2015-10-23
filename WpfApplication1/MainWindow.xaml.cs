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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int GB = 0;
        public int BP = 0;
        public int Medal = 0;
        public int Fairy = 0;
        public int Crown = 0;
        public int BossKey = 0;
        public int N64Coin = 0;
        public int RWCoin = 0;
        public int Percentage = 0;
        public decimal actualPercent = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Load()
        {
            numGB.Text = GB.ToString();
            numBP.Text = BP.ToString();
            numMedal.Text = Medal.ToString();
            numFairy.Text = Fairy.ToString();
            numCrown.Text = Crown.ToString();
            numKey.Text = BossKey.ToString();
            numN64Coin.Text = N64Coin.ToString();
            numRWCoin.Text = RWCoin.ToString();
            CalcPercent();
            numPercent.Text = Percentage.ToString();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void ShowWindow_Click(object sender, RoutedEventArgs e)
        {
            IncrementWindow iw = new IncrementWindow(this);
            iw.Show();
        }

        private void PercentInfo_Click(object sender, RoutedEventArgs e)
        {
            PercentInfo pi = new PercentInfo();
            pi.Show();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CalcPercent()
        {
            actualPercent = Convert.ToDecimal((GB * 0.4) + (Medal * 0.2) + (Fairy * 0.2) + (Crown * 0.5) + (BossKey * 0.25) + (N64Coin * 0.5) + (RWCoin * 0.5));
            Percentage = Decimal.ToInt32(actualPercent);
            if (actualPercent.Equals(100.4m))
            {
                Percentage = 101;
            }
        }
    }
}
