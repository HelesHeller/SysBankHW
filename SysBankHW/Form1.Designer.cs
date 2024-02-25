using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysBankHW
{
    partial class Form1 : Form
    {
        private TextBox moneyTextBox = new TextBox();
        private TextBox nameTextBox = new TextBox();
        private TextBox percentTextBox = new TextBox();
        private Label label1 = new Label();
        private Label label2 = new Label();
        private Label label3 = new Label();
        private ListBox outputListBox = new ListBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            // moneyTextBox
            moneyTextBox.Location = new Point(12, 35);
            moneyTextBox.Size = new Size(125, 27);
            Controls.Add(moneyTextBox);

            // nameTextBox
            nameTextBox.Location = new Point(143, 35);
            nameTextBox.Size = new Size(125, 27);
            Controls.Add(nameTextBox);

            // percentTextBox
            percentTextBox.Location = new Point(274, 35);
            percentTextBox.Size = new Size(125, 27);
            Controls.Add(percentTextBox);

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Text = "money:";
            Controls.Add(label1);

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(143, 12);
            label2.Text = "name:";
            Controls.Add(label2);

            // label3
            label3.AutoSize = true;
            label3.Location = new Point(274, 12);
            label3.Text = "percent:";
            Controls.Add(label3);

            // outputListBox
            outputListBox.FormattingEnabled = true;
            outputListBox.Location = new Point(12, 88);
            outputListBox.Size = new Size(387, 124);
            Controls.Add(outputListBox);

            // Form1
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 253);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
