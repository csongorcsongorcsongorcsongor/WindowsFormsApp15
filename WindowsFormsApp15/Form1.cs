using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start();
        }
        void start()
        {
            szamitogep one = new szamitogep() { type = "hp", size = 16, os = "win", name = "igusdfahgfda", cost = 432424 };
            szamitogep two = new szamitogep() { type = "dell", size = 32, os = "win2", name="dell", cost = 327815 };
            Controls.Add(one);
            Controls.Add(two);


        }
    }
}
