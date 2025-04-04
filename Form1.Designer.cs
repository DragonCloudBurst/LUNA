namespace LUNA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.LightCyan;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newButton.FlatAppearance.BorderSize = 10;
            this.newButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(164, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(90, 50);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "new";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightCyan;
            this.saveButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(260, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 50);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LUNA.Properties.Resources.luna;
            this.pictureBox1.InitialImage = global::LUNA.Properties.Resources.luna;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(50, 50);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.LightCyan;
            this.openButton.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(68, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(90, 50);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "open";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // charCountLabel
            // 
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCountLabel.Location = new System.Drawing.Point(656, 459);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(137, 26);
            this.charCountLabel.TabIndex = 6;
            this.charCountLabel.Text = "characters: ";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 68);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(854, 380);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.charCountLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LUNA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.RichTextBox textBox;
    }
}

