using System;

namespace OOP4._2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new EventHandler(this.UpdateFromModel);
            model.observers.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.FirstValue = Int32.Parse(textBox1.Text);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.SecondValue = Int32.Parse(textBox2.Text);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.ThirdValue = Int32.Parse(textBox3.Text);
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.FirstValue = Decimal.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.SecondValue = Decimal.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            model.ThirdValue = Decimal.ToInt32(numericUpDown3.Value);
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            model.FirstValue = trackBar1.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            model.SecondValue = trackBar2.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            model.ThirdValue = trackBar3.Value;
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBox1.Text = model.FirstValue.ToString();
            textBox2.Text = model.SecondValue.ToString();
            textBox3.Text = model.ThirdValue.ToString();
            numericUpDown1.Value = model.FirstValue;
            numericUpDown2.Value = model.SecondValue;
            numericUpDown3.Value = model.ThirdValue;
            trackBar1.Value = model.FirstValue;
            trackBar2.Value = model.SecondValue;
            trackBar3.Value = model.ThirdValue;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FirstValue = model.FirstValue;
            Properties.Settings.Default.SecondValue = model.SecondValue;
            Properties.Settings.Default.ThirdValue = model.ThirdValue;
            Properties.Settings.Default.Save();
        }
    }
}