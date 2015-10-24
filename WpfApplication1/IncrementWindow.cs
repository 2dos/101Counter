using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApplication1
{
    public partial class IncrementWindow : Form
    {
        MainWindow mw;

        public IncrementWindow(MainWindow _mw)
        {
            InitializeComponent();
            mw = _mw;
			
			btnToggleRWCoin.ImageIndex = mw.RWCoin;
			btnToggleN64Coin.ImageIndex = mw.N64Coin;
		}

		private void plusGB_Click(object sender, EventArgs e)
		{
            if (mw.GB < mw.Max_GB)
            {
				mw.GB++;
			    mw.RefreshUI();
			}
		}

        private void minusGB_Click(object sender, EventArgs e)
        {
            if (mw.GB > 0)
            {
                mw.GB--;
                mw.RefreshUI();
            }
        }

        private void plusBlueprint_Click(object sender, EventArgs e)
        {
            if (mw.BP < mw.Max_BP)
            {
				mw.BP++;
                mw.RefreshUI();
            }
        }

        private void minusBlueprint_Click(object sender, EventArgs e)
        {
            if (mw.BP > 0)
            {
                mw.BP--;
                mw.RefreshUI();
            }
        }

        private void plusMedal_Click(object sender, EventArgs e)
        {
            if (mw.Medal < mw.Max_Medal)
            {
				mw.Medal++;
                mw.RefreshUI();
            }
        }

        private void minusMedal_Click(object sender, EventArgs e)
        {
            if (mw.Medal > 0)
            {
				mw.Medal--;
                mw.RefreshUI();
            }
        }

        private void plusFairy_Click(object sender, EventArgs e)
        {
            if (mw.Fairy < mw.Max_Fairy)
            {
                mw.Fairy++;
                mw.RefreshUI();
            }
        }

        private void minusFairy_Click(object sender, EventArgs e)
        {
			if (mw.Fairy > 0) {
				mw.Fairy--;
				mw.RefreshUI();
			}
        }

        private void plusCrown_Click(object sender, EventArgs e)
        {
            if (mw.Crown < mw.Max_Crown)
            {
				mw.Crown++;
                mw.RefreshUI();
            }
        }

        private void minusCrown_Click(object sender, EventArgs e)
        {
            if (mw.Crown > 0)
            {
                mw.Crown--;
                mw.RefreshUI();
            }
        }

        private void plusKey_Click(object sender, EventArgs e)
        {
            if (mw.BossKey < mw.Max_BossKey)
            {
				mw.BossKey++;
                mw.RefreshUI();
            }
        }

        private void minusKey_Click(object sender, EventArgs e)
        {
            if (mw.BossKey > 0)
            {
				mw.BossKey--;
                mw.RefreshUI();
            }
        }

        private void plusN64Coin_Click(object sender, EventArgs e)
        {
            if (mw.N64Coin < mw.Max_N64Coin)
            {
                mw.N64Coin++;
                mw.RefreshUI();
            }
        }

        private void minusN64Coin_Click(object sender, EventArgs e)
        {
            if (mw.N64Coin > 0)
            {
				mw.N64Coin--;
                mw.RefreshUI();
            }
        }

        private void plusRWCoin_Click(object sender, EventArgs e)
        {
            if (mw.RWCoin < mw.Max_RWCoin)
            {
				mw.RWCoin++;
                mw.RefreshUI();
            }
        }

        private void minusRWCoin_Click(object sender, EventArgs e)
        {
            if (mw.RWCoin > 0)
            {
				mw.RWCoin--;
                mw.RefreshUI();
            }
        }

		private void resetButton_Click(object sender, EventArgs e) {
			mw.Reset();
			btnToggleRWCoin.ImageIndex = mw.RWCoin;
			btnToggleN64Coin.ImageIndex = mw.N64Coin;
		}

		private void btnToggleN64Coin_Click(object sender, EventArgs e) {
			if (mw.N64Coin == 0) {
				mw.N64Coin = mw.Max_N64Coin;
			} else {
				mw.N64Coin = 0;
			}
			btnToggleN64Coin.ImageIndex = mw.N64Coin;
			mw.RefreshUI();
		}

		private void btnToggleRWCoin_Click(object sender, EventArgs e) {
			if (mw.RWCoin == 0) {
				mw.RWCoin = mw.Max_RWCoin;
			} else {
				mw.RWCoin = 0;
			}
			btnToggleRWCoin.ImageIndex = mw.RWCoin;
			mw.RefreshUI();
		}
    }
}
