using System;
using System.Windows.Forms;

namespace ExcelGosti
{
    public partial class ExcelFormatException : Form
    {
        public ExcelFormatException()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public new static void Show()
        {
            ExcelFormatException excelFormat = new ExcelFormatException();
            excelFormat.ShowDialog();
        }
    }
}
