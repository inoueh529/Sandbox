using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSandbox
{
    public partial class Form1 : Form
    {
        private const string TAG = "合計: ";
        private const int DEFAULT_NUM = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcSum_Click(object sender, EventArgs e)
        {
            int item1 = DEFAULT_NUM;
            int item2 = DEFAULT_NUM;
            int.TryParse(num1.Text, out item1);
            int.TryParse(num2.Text, out item2);

            sum.Text = MakeText((item1 + item2).ToString());
        }

        private string MakeText(string calcSum)
        {
            string str = (calcSum != null) ? TAG + calcSum : string.Empty;

            return str;
        }
    }
}
