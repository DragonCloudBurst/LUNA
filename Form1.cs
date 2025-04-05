using LUNA.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // function from here, thank god, credit to this person
        // https://learn.microsoft.com/en-us/answers/questions/530055/how-to-color-a-specific-string-s-in-richtextbox-te
        void HighlightPhrase(RichTextBox box, string phrase, Color color)
        {
            string results = "";
            int pos = box.SelectionStart;
            string s = box.Text;
            for (int ix = 0; ix < s.Length; ix++)
            {
                int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0)
                {
                    break;
                }
                else
                {
                    box.SelectionStart = jx;
                    box.SelectionLength = phrase.Length;
                    box.SelectionColor = color;
                    ix = jx + 1;
                    results+= jx;
                }
            }
            box.SelectionStart = 0;
            box.SelectionLength = 0;
            
        }

        private void render_Click(object sender, EventArgs e)
        {
            List<string> MarkdownBaseElements = new List<string>
            {
                "#", "##", "###", "~~", "*", "**", "---", ">", "-", "`", "```", "|", "=="
            };
            
            // headers
            HighlightPhrase(textBox, MarkdownBaseElements[0], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[1], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[2], Color.Firebrick);
            
            //strikethrough
            HighlightPhrase(textBox, MarkdownBaseElements[3], Color.Teal);
            
            //italics
            HighlightPhrase(textBox, MarkdownBaseElements[4], Color.CornflowerBlue);
            
            // bold
            HighlightPhrase(textBox, MarkdownBaseElements[5], Color.Fuchsia);
            
            // horizontal rule
            HighlightPhrase(textBox, MarkdownBaseElements[6], Color.OrangeRed);
            
            // blockquote 
            HighlightPhrase(textBox, MarkdownBaseElements[7], Color.Lime);
            
            // dash / list bullet
            HighlightPhrase(textBox, MarkdownBaseElements[8], Color.Purple);
            
            // codeblock
            HighlightPhrase(textBox, MarkdownBaseElements[9], Color.Crimson);
            HighlightPhrase(textBox, MarkdownBaseElements[10], Color.Crimson);
            
            // pipe character
            HighlightPhrase(textBox, MarkdownBaseElements[11], Color.Blue);
            
            //highlight
            HighlightPhrase(textBox, MarkdownBaseElements[12], Color.Cyan);
        }
    }
}

