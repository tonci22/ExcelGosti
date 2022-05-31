using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelGosti
{
    public partial class MissingMicrosoftAccessDatabaseEngine : Form
    {
        public MissingMicrosoftAccessDatabaseEngine()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public new static void Show()
        {
            var mmadb = new MissingMicrosoftAccessDatabaseEngine();
            mmadb.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.microsoft.com/en-us/download/confirmation.aspx?id=13255");
        }
    }
}
