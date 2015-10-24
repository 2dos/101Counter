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
		}

		private void plusGB_Click(object sender, EventArgs e)
		{
            if (mw.GB < 201)
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
            if (mw.BP < 40)
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
            if (mw.Medal < 40)
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
            if (mw.Fairy < 20)
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
            if (mw.Crown < 10)
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
            if (mw.BossKey < 8)
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
            if (mw.N64Coin < 1)
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
            if (mw.RWCoin < 1)
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
		}
    }
}
