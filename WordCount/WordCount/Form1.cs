using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
namespace WordCount
{
    public partial class Form1 : Form
    {
        private SharedLogic sharedlogic;
        private long count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            sharedlogic = new SharedLogic();
            rtxtResult.Text = sharedlogic.countNumberofWords(rtxtSentence.Text.ToUpper().Trim(), ref count);
            lblTotal.Text = "Total distinct word are:" + count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtSentence.Clear();
            rtxtResult.Clear();
            lblTotal.Text = "";
        }
    }
}
