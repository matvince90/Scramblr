using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scramblr
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        public void setText(string text)
        {
            this.text.Text = text;
        }
    }
}
