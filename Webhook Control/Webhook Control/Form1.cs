using Flagsec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webhook_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Webhook hook = new Webhook("YOUR WEBHOOK URL HERE");
            hook.Name = "YOUR NAME HERE";
            hook.ProfilePictureUrl = "YOUR PICTURE URL HERE";

            hook.SendMessage(textBox1.Text, textBox2.Text);
        }
    }
}
