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
        MainWindow mw = null;
        int temp;

        public IncrementWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
		}

		private void plusGB_Click(object sender, EventArgs e)
		{
            temp = this.mw.GB;
            if(temp < 201)
            {
			    temp++;
			    this.mw.ValueGB(temp);
			    this.mw.Load();
			}
		}

        private void minusGB_Click(object sender, EventArgs e)
        {
            temp = this.mw.GB;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueGB(temp);
                this.mw.Load();
            }
        }

        private void plusBlueprint_Click(object sender, EventArgs e)
        {
            temp = this.mw.BP;
            if (temp < 40)
            {
                temp++;
                this.mw.ValueBP(temp);
                this.mw.Load();
            }
        }

        private void minusBlueprint_Click(object sender, EventArgs e)
        {
            temp = this.mw.BP;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueBP(temp);
                this.mw.Load();
            }
        }

        private void plusMedal_Click(object sender, EventArgs e)
        {
            temp = this.mw.Medal;
            if (temp < 40)
            {
                temp++;
                this.mw.ValueMedal(temp);
                this.mw.Load();
            }
        }

        private void minusMedal_Click(object sender, EventArgs e)
        {
            temp = this.mw.Medal;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueMedal(temp);
                this.mw.Load();
            }
        }

        private void plusFairy_Click(object sender, EventArgs e)
        {
            temp = this.mw.Fairy;
            if (temp < 20)
            {
                temp++;
                this.mw.ValueFairy(temp);
                this.mw.Load();
            }
        }

        private void minusFairy_Click(object sender, EventArgs e)
        {
            temp = this.mw.Fairy;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueFairy(temp);
                this.mw.Load();
            }
        }

        private void plusCrown_Click(object sender, EventArgs e)
        {
            temp = this.mw.Crown;
            if (temp < 10)
            {
                temp++;
                this.mw.ValueCrown(temp);
                this.mw.Load();
            }
        }

        private void minusCrown_Click(object sender, EventArgs e)
        {
            temp = this.mw.Crown;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueCrown(temp);
                this.mw.Load();
            }
        }

        private void plusKey_Click(object sender, EventArgs e)
        {
            temp = this.mw.BossKey;
            if (temp < 8)
            {
                temp++;
                this.mw.ValueKey(temp);
                this.mw.Load();
            }
        }

        private void minusKey_Click(object sender, EventArgs e)
        {
            temp = this.mw.BossKey;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueKey(temp);
                this.mw.Load();
            }
        }

        private void plusN64Coin_Click(object sender, EventArgs e)
        {
            temp = this.mw.N64Coin;
            if (temp < 1)
            {
                temp++;
                this.mw.ValueN64Coin(temp);
                this.mw.Load();
            }
        }

        private void minusN64Coin_Click(object sender, EventArgs e)
        {
            temp = this.mw.N64Coin;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueN64Coin(temp);
                this.mw.Load();
            }
        }

        private void plusRWCoin_Click(object sender, EventArgs e)
        {
            temp = this.mw.RWCoin;
            if (temp < 1)
            {
                temp++;
                this.mw.ValueRWCoin(temp);
                this.mw.Load();
            }
        }

        private void minusRWCoin_Click(object sender, EventArgs e)
        {
            temp = this.mw.RWCoin;
            if (temp > 0)
            {
                temp--;
                this.mw.ValueRWCoin(temp);
                this.mw.Load();
            }
        }
    }
}
