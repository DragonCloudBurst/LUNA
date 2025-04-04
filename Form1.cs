using LUNA.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LUNA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf";
            saveFileDialog1.Title = "Save file";
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        // this is the open button i just forgot to name it first
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf";
            openFileDialog1.Title = "Open file";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var text = File.ReadAllText(openFileDialog1.FileName);

                textBox.Text = text;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int charCount = textBox.Text.Length;
            charCountLabel.Text = $"characters: {charCount}";
        }
    }
}
