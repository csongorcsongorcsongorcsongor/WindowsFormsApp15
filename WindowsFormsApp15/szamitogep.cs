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
    class szamitogep : aru
    {
        public string type { get; set; }
        public int size { get; set; }
        public string os { get; set; }
        public szamitogep()
        {
        }
        public override void ClickEvent(object s, EventArgs e)
        {
            button1.Text = $"{name}";

            MessageBox.Show($"Típus: {type}, Memoria: {size}, OS: {os}, Ár: {cost}");
        }
    }
}
