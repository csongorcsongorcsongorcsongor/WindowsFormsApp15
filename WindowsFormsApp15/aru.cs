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
    class aru : UserControl
    {
        public Button button1;

        public int cost { get; set; }
        public string name { get; set; }
        public aru()
        {
            InitializeComponent();

        }
        public virtual void ClickEvent(Object s, EventArgs e)
        {
            MessageBox.Show($"{cost}");
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // aru
            // 
            this.Controls.Add(this.button1);
            this.Name = "aru";
            this.Size = new System.Drawing.Size(75, 50);
            this.ResumeLayout(false);
            this.button1.Click += ClickEvent;
            button1.Text = $"Nev: {name}";

        }
    }
}
