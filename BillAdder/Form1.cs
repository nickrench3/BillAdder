using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillAdder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetTextBoxes();
        }

        private void SetTextBoxes()
        {
            HundredsText.Text = "0";
            FiftysText.Text = "0";
            TwentiesText.Text = "0";
            TensText.Text = "0";
            FivesText.Text = "0";
            OnesText.Text = "0";
            TotalText.Text = "0";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int Hundreds = Convert.ToInt32(HundredsText.Text) * 100;
            int Fiftys = Convert.ToInt32(FiftysText.Text) * 50;
            int Twenties = Convert.ToInt32(TwentiesText.Text) * 20;
            int Tens = Convert.ToInt32(TensText.Text) * 10;
            int Fives = Convert.ToInt32(FivesText.Text) * 5;
            int Ones = Convert.ToInt32(OnesText.Text);

            int Total = (Hundreds + Fiftys + Twenties + Tens + Fives + Ones);

            TotalText.Text = Total.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetTextBoxes();
        }
    }
}
