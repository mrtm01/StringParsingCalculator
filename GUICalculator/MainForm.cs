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
            _calculatorHandeler = new CalculatorHandeler(this.mainTextBox, this,this.historyDisplay1);
            this.KeyPreview = true;            
        }

        public void SelectAllInTextBox()
        {
            mainTextBox.SelectAll();
            mainTextBox.Focus();
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
                    equalsButton.PerformClick();
                    e.Handled = true;
                    break;
                case (char)48: //0
                    btnNum0.PerformClick();
                    e.Handled = true;
                    break;
                case (char)49: //1
                    btnNum1.PerformClick();
                    e.Handled = true;
                    break;
                case (char)50: //2
                    btnNum2.PerformClick();
                    e.Handled = true;
                    break;
                case (char)51: //3
                    btnNum3.PerformClick();
                    e.Handled = true;
                    break;
                case (char)52: //4
                    btnNum4.PerformClick();
                    e.Handled = true;
                    break;
                case (char)53: //5
                    btnNum5.PerformClick();
                    e.Handled = true;
                    break;
                case (char)54: //6
                    btnNum6.PerformClick();
                    e.Handled = true;
                    break;
                case (char)55: //7
                    btnNum7.PerformClick();
                    e.Handled = true;
                    break;
                case (char)56: //8
                    btnNum8.PerformClick();
                    e.Handled = true;
                    break;
                case (char)57: //9
                    btnNum9.PerformClick();
                    e.Handled = true;
                    break;
                case (char)27: //esc
                    _calculatorHandeler.HistoryDisplayReset();
                    e.Handled = true;
                    break;
                default:
                    //MessageBox.Show("Got keypress in main form: " + (int)e.KeyChar);
                    break;
            }
        }

        private void HandleEqualsPress()
        {
            if (!_calculatorHandeler.GetResult()) mainTextBox.SelectAll();
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("0");
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("1");
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("2");
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("3");
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("4");
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("5");
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("6");
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("7");
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("8");
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("9");
        }

        private void MainTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
                case Keys.Up:
                    //Console.WriteLine("up arrow!");
                    e.IsInputKey = true;
                    break;
            }
        }


        private void MainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    //e.IsInputKey = true;
                    _calculatorHandeler.HistoryDown();
                    e.Handled = true;
                    //mainTextBox.Text = _commandHistory.Down();
                    break;
                case Keys.Up:
                    //mainTextBox.Text = _commandHistory.Up();
                    //e.IsInputKey = true;
                    e.Handled = true;
                    _calculatorHandeler.HistoryUp();
                    break;
            }

        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("sin(", ")");
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("cos(", ")");
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("tan(", ")");
        }

        private void AsinButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("asin(", ")");
        }

        private void AcosButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("acos(", ")");
        }

        private void AtanButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("atan(", ")");
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.InsertSurroundingSelection("sqrt(", ")");
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            _calculatorHandeler.AddSymbol("^");

        }
    }
}
