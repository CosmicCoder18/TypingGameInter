using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGameInter
{
    public partial class HTP : Form
    {
        public HTP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _1stpage p1 = new _1stpage();
            p1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
