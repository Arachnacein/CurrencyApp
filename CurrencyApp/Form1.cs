using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        private const string GOLD = "XAU";
        private const string SILVER = "XAG";

        private const string USD = "USD";
        private const string PLN = "PLN";
        private const string EUR = "EUR";
        private const string NOK = "NOK";
        private const string GBP = "GBP";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load metal data section
            GetMetalData metal = new GetMetalData();
            labelGoldValuePLN.Text = metal.GetMetalValue(PLN, GOLD);
            labelGoldValueUSD.Text = metal.GetMetalValue(USD, GOLD);
            labelSilverValuePLN.Text = metal.GetMetalValue(PLN, SILVER);
            labelSilverValueUSD.Text = metal.GetMetalValue(USD, SILVER);
            labelGold_SilverRatioValue.Text = metal.GetMetalValue(SILVER, GOLD);

            //Load currency data section
            GetCurrencyData currency = new GetCurrencyData();
            labelValueDollar.Text = currency.GetCurrencyValue(USD);
            labelValueEuro.Text = currency.GetCurrencyValue(EUR);
            labelValuePound.Text = currency.GetCurrencyValue(GBP);
            labelValueNOK.Text = currency.GetCurrencyValue(NOK);


        }

        private void Refresh(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
