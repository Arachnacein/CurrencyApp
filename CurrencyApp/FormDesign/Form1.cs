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
            Service obj = new Service();
            labelGoldValuePLN.Text = obj.GetMetalValue(PLN, GOLD);
            labelGoldValueUSD.Text = obj.GetMetalValue(USD, GOLD);
            labelSilverValuePLN.Text = obj.GetMetalValue(PLN, SILVER);
            labelSilverValueUSD.Text = obj.GetMetalValue(USD, SILVER);
            labelGold_SilverRatioValue.Text = obj.GetGoldSiverRatio(labelGoldValuePLN.Text, labelSilverValuePLN.Text).ToString();

            labelValueDollar.Text = obj.GetCurrencyValue(USD);
            labelValueEuro.Text = obj.GetCurrencyValue(EUR);
            labelValuePound.Text = obj.GetCurrencyValue(GBP);
            labelValueNOK.Text = obj.GetCurrencyValue(NOK);
        }
    }
}