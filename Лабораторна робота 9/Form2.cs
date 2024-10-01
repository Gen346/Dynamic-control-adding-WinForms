using System;
using System.Windows.Forms;

namespace Лабораторна_робота_9
{
    public partial class Form2 : Form
    {
        private Label _message;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void okButton_Click(object sender, EventArgs e)
        {
            GetTimeIncrement();
            this.Close();
        }
        public int GetTimeIncrement()
        {
            return (int)numericUpDown1.Value;
        }

    }
}
