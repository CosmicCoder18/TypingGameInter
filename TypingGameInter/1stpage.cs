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
    public partial class _1stpage : Form
    {
        public _1stpage()
        {
            InitializeComponent();
        }

        private void _1stpage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2ndpage p2 = new _2ndpage();
            p2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HTP htp = new HTP();
            htp.Show();
            this.Hide();
        }
    }
}
