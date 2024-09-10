using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_of_Warcraft_Gold_Calculator
{
    public partial class Form1 : Form
    {
        private readonly uint DefaultValueGold = 10000;
        private readonly uint DefaultValueSilver = 100;
        private readonly uint DefaultValueCopper = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void GoldInput_ValueChanged(object sender, EventArgs e)
        {
            uint gold = (uint)GoldInput.Value * DefaultValueGold;
            GoldResult.Text = gold.ToString();
        }

        private void SilverInput_ValueChanged(object sender, EventArgs e)
        {
            uint silver = (uint)SilverInput.Value * DefaultValueSilver;
            SilverResult.Text = silver.ToString();
        }

        private void CopperInput_ValueChanged(object sender, EventArgs e)
        {
            uint copper = (uint)CopperInput.Value * DefaultValueCopper;
            CopperResutl.Text = copper.ToString();
        }
    }
}
