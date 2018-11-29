using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class MainForm : Form
    {
        private CalculatorHandeler _calculatorHandeler;
        public MainForm()
        {
            InitializeComponent();
            _calculatorHandeler = new CalculatorHandeler(this.mainTextBox);
            this.KeyPreview = true;
        }

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            HandleEqualsPress();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13: //enter
                    //MessageBox.Show("Got keypress in main form: " + e.KeyChar);
                    HandleEqualsPress();
                    break;
                default:
                    //MessageBox.Show("Got keypress in main form: " + (int)e.KeyChar);
                    break;
            }
        }

        private void HandleEqualsPress()
        {
            _calculatorHandeler.GetResult();

        }
    }
}
