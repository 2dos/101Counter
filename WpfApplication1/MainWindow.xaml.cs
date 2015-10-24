using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
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
		public int Max_GB = 201;
		public int Max_BP = 40;
		public int Max_Medal = 40;
		public int Max_Fairy = 20;
		public int Max_Crown = 10;
		public int Max_BossKey = 8;
		public int Max_N64Coin = 1;
		public int Max_RWCoin = 1;

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

		public FontDialog fontPicker = new FontDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e) {
			IncrementWindow iw = new IncrementWindow(this);
			iw.Show();
			iw.BringToFront();
		}

		private void CalcPercent() {
			actualPercent = Convert.ToDecimal((GB * 0.4) + (Medal * 0.2) + (Fairy * 0.2) + (Crown * 0.5) + (BossKey * 0.25) + (N64Coin * 0.5) + (RWCoin * 0.5));
			Percentage = Decimal.ToInt32(actualPercent);
			if (actualPercent.Equals(100.4m)) {
				Percentage = 101;
			}
		}

        public void RefreshUI()
        {
            numGB.Text = GB.ToString() + "/" + Max_GB.ToString();
			numBP.Text = BP.ToString() + "/" + Max_BP.ToString();
			numMedal.Text = Medal.ToString() + "/" + Max_Medal.ToString();
			numFairy.Text = Fairy.ToString() + "/" + Max_Fairy.ToString();
			numCrown.Text = Crown.ToString() + "/" + Max_Crown.ToString();
			numKey.Text = BossKey.ToString() + "/" + Max_BossKey.ToString();
			n64CoinImage.Source = (ImageSource) (N64Coin == 1 ? FindResource("N64Coin") : FindResource("N64Coin_greyed"));
			rwCoinImage.Source = (ImageSource) (RWCoin == 1 ? FindResource("RarewareCoin") : FindResource("RarewareCoin_greyed"));
            CalcPercent();
            numPercent.Text = Percentage.ToString() + "%";
        }

		public void Reset() {
			GB = 0;
			BP = 0;
			Medal = 0;
			Fairy = 0;
			Crown = 0;
			BossKey = 0;
			N64Coin = 0;
			RWCoin = 0;
			Percentage = 0;
			actualPercent = 0;
			RefreshUI();
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
            System.Windows.Application.Current.Shutdown();
        }

		private void PickFont_Click(object sender, RoutedEventArgs e) {
			if (fontPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				Font font = fontPicker.Font;
				System.Windows.Media.FontFamily mFamily = new System.Windows.Media.FontFamily(font.Name);
				numGB.FontFamily = mFamily;
				numBP.FontFamily = mFamily;
				numMedal.FontFamily = mFamily;
				numFairy.FontFamily = mFamily;
				numCrown.FontFamily = mFamily;
				numKey.FontFamily = mFamily;
				numPercent.FontFamily = mFamily;
			}
		}
    }
}
