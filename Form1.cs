using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Семафоры_homework_25._04._2023
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e){
            if(e.KeyValue == (char)Keys.A) { 
                
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            /*if(e.KeyChar == (char)Keys.A) { 
                button1.Enabled = false;
            }*/


        }
    }
}
