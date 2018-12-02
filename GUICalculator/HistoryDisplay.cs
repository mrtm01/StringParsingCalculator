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
    public partial class HistoryDisplay : Control
    {
        private List<string> _textLines;
        private bool _messageMode = false;
        public HistoryDisplay()
        {
            _textLines = new List<string>();
            InitializeComponent();
        }

        public void AddLine(string s)
        {
            _textLines.Insert(0, s);
            this.Invalidate();
            _messageMode = false;
        }
        public void Clear()
        {
            _textLines.Clear();
            this.Invalidate();
        }
        public void EnterMessageMode()
        {
            _messageMode = true;
            this.Invalidate();
        }
        public void ExitMessageMode()
        {
            _messageMode = false;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {

            base.OnPaint(pe);
            if (!_messageMode)
            {
                for (int i = 0; i < _textLines.Count; i++)
                {
                    string s = _textLines[i];
                    int ypos = ClientRectangle.Location.Y + ClientRectangle.Height - (i + 1) * Font.Height;
                    if ((ypos + Font.Height) < ClientRectangle.Location.Y)
                    {
                        break; //dont draw text out of bounds

                    }
                    pe.Graphics.DrawString(s, this.Font, new SolidBrush(ForeColor), ClientRectangle.Location.X, ypos);
                }
            }
            else
            {
                pe.Graphics.DrawString(this.Text, this.Font, new SolidBrush(ForeColor), ClientRectangle);
            }
        }
    }
}
