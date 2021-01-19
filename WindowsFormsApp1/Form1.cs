using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRGB : Form
    { 
        public FormRGB()
        {
            InitializeComponent();
            rgbControl1.ChangeColorEvent += OnChangeColor;
        }

        public void OnChangeColor(object sender, EventArgs eventArgs)
        {
            ForeColor = rgbControl1.CurColor;
        }
    }
}
