using CurrencyApp.Logic;
using System;
using System.Windows.Forms;
using static CurrencyApp.Logic.Const.ConstValues;

namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshContent(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {

            //Load metal data section
            Service metal = new Service();
            labelGoldValuePLN.Text = metal.GetMetalValue(PLN, GOLD);
            labelGoldValueUSD.Text = metal.GetMetalValue(USD, GOLD);
            labelSilverValuePLN.Text = metal.GetMetalValue(PLN, SILVER);
            labelSilverValueUSD.Text = metal.GetMetalValue(USD, SILVER);
            labelGold_SilverRatioValue.Text = metal.GetMetalValue(SILVER, GOLD);

            //Load currency data section
            Service currency = new Service();
            labelValueDollar.Text = currency.GetCurrencyValue(USD);
            labelValueEuro.Text = currency.GetCurrencyValue(EUR);
            labelValuePound.Text = currency.GetCurrencyValue(GBP);
            labelValueNOK.Text = currency.GetCurrencyValue(NOK);
        }
    }
}
