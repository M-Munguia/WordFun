namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            wordFunToolStripMenuItem = new ToolStripMenuItem();
            metricsToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            pyramidToolStripMenuItem = new ToolStripMenuItem();
            palindromeToolStripMenuItem = new ToolStripMenuItem();
            compareToolStripMenuItem = new ToolStripMenuItem();
            conversionMultilicationToolStripMenuItem = new ToolStripMenuItem();
            Output = new RichTextBox();
            buttonMetric = new Button();
            buttonSquare = new Button();
            buttonPyramid = new Button();
            buttonPalindrome = new Button();
            buttonCompare = new Button();
            buttonConversion = new Button();
            label1 = new Label();
            Word1 = new TextBox();
            Word2 = new TextBox();
            WordFunTitle = new Label();
            NullLabel = new Label();
            labelWord1 = new Label();
            labelWord2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(224, 224, 224);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { wordFunToolStripMenuItem, metricsToolStripMenuItem, squareToolStripMenuItem, pyramidToolStripMenuItem, palindromeToolStripMenuItem, compareToolStripMenuItem, conversionMultilicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1630, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // wordFunToolStripMenuItem
            // 
            wordFunToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            wordFunToolStripMenuItem.Font = new Font("Rockwell", 9F);
            wordFunToolStripMenuItem.ForeColor = Color.White;
            wordFunToolStripMenuItem.Name = "wordFunToolStripMenuItem";
            wordFunToolStripMenuItem.Size = new Size(142, 36);
            wordFunToolStripMenuItem.Text = "Word Fun";
            // 
            // metricsToolStripMenuItem
            // 
            metricsToolStripMenuItem.BackColor = Color.FromArgb(128, 64, 64);
            metricsToolStripMenuItem.ForeColor = Color.White;
            metricsToolStripMenuItem.Name = "metricsToolStripMenuItem";
            metricsToolStripMenuItem.Size = new Size(112, 36);
            metricsToolStripMenuItem.Text = "Metrics";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.BackColor = Color.FromArgb(128, 64, 0);
            squareToolStripMenuItem.ForeColor = Color.White;
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(108, 36);
            squareToolStripMenuItem.Text = "Square";
            // 
            // pyramidToolStripMenuItem
            // 
            pyramidToolStripMenuItem.BackColor = Color.FromArgb(192, 64, 0);
            pyramidToolStripMenuItem.ForeColor = Color.White;
            pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem";
            pyramidToolStripMenuItem.Size = new Size(120, 36);
            pyramidToolStripMenuItem.Text = "Pyramid";
            // 
            // palindromeToolStripMenuItem
            // 
            palindromeToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 0);
            palindromeToolStripMenuItem.ForeColor = Color.White;
            palindromeToolStripMenuItem.Name = "palindromeToolStripMenuItem";
            palindromeToolStripMenuItem.Size = new Size(154, 36);
            palindromeToolStripMenuItem.Text = "Palindrome";
            // 
            // compareToolStripMenuItem
            // 
            compareToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 128);
            compareToolStripMenuItem.ForeColor = Color.White;
            compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            compareToolStripMenuItem.Size = new Size(131, 36);
            compareToolStripMenuItem.Text = "Compare";
            // 
            // conversionMultilicationToolStripMenuItem
            // 
            conversionMultilicationToolStripMenuItem.BackColor = Color.FromArgb(255, 224, 192);
            conversionMultilicationToolStripMenuItem.ForeColor = Color.White;
            conversionMultilicationToolStripMenuItem.Name = "conversionMultilicationToolStripMenuItem";
            conversionMultilicationToolStripMenuItem.Size = new Size(294, 36);
            conversionMultilicationToolStripMenuItem.Text = "Conversion Multilication";
            // 
            // Output
            // 
            Output.BackColor = Color.WhiteSmoke;
            Output.BorderStyle = BorderStyle.FixedSingle;
            Output.ForeColor = Color.Black;
            Output.Location = new Point(397, 277);
            Output.Name = "Output";
            Output.Size = new Size(844, 494);
            Output.TabIndex = 1;
            Output.Text = "";
            // 
            // buttonMetric
            // 
            buttonMetric.BackColor = Color.Coral;
            buttonMetric.FlatStyle = FlatStyle.Flat;
            buttonMetric.Font = new Font("Rockwell", 9F);
            buttonMetric.ForeColor = Color.White;
            buttonMetric.Location = new Point(184, 815);
            buttonMetric.Name = "buttonMetric";
            buttonMetric.Size = new Size(179, 83);
            buttonMetric.TabIndex = 2;
            buttonMetric.Text = "Metrics";
            buttonMetric.UseVisualStyleBackColor = false;
            buttonMetric.Click += buttonMetric_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.BackColor = Color.Coral;
            buttonSquare.FlatStyle = FlatStyle.Flat;
            buttonSquare.Font = new Font("Rockwell", 9F);
            buttonSquare.ForeColor = Color.White;
            buttonSquare.Location = new Point(397, 813);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(179, 81);
            buttonSquare.TabIndex = 3;
            buttonSquare.Text = "Square";
            buttonSquare.UseVisualStyleBackColor = false;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonPyramid
            // 
            buttonPyramid.BackColor = Color.Coral;
            buttonPyramid.FlatStyle = FlatStyle.Flat;
            buttonPyramid.Font = new Font("Rockwell", 9F);
            buttonPyramid.ForeColor = Color.White;
            buttonPyramid.Location = new Point(625, 813);
            buttonPyramid.Name = "buttonPyramid";
            buttonPyramid.Size = new Size(179, 83);
            buttonPyramid.TabIndex = 4;
            buttonPyramid.Text = "Pyramid";
            buttonPyramid.UseVisualStyleBackColor = false;
            buttonPyramid.Click += buttonPyramid_Click;
            // 
            // buttonPalindrome
            // 
            buttonPalindrome.BackColor = Color.Coral;
            buttonPalindrome.FlatStyle = FlatStyle.Flat;
            buttonPalindrome.Font = new Font("Rockwell", 9F);
            buttonPalindrome.ForeColor = Color.White;
            buttonPalindrome.Location = new Point(851, 815);
            buttonPalindrome.Name = "buttonPalindrome";
            buttonPalindrome.Size = new Size(179, 81);
            buttonPalindrome.TabIndex = 5;
            buttonPalindrome.Text = "Palindrome";
            buttonPalindrome.UseVisualStyleBackColor = false;
            buttonPalindrome.Click += buttonPalindrome_Click;
            // 
            // buttonCompare
            // 
            buttonCompare.BackColor = Color.Coral;
            buttonCompare.FlatStyle = FlatStyle.Flat;
            buttonCompare.Font = new Font("Rockwell", 9F);
            buttonCompare.ForeColor = Color.White;
            buttonCompare.Location = new Point(1062, 815);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(179, 81);
            buttonCompare.TabIndex = 6;
            buttonCompare.Text = "Compare";
            buttonCompare.UseVisualStyleBackColor = false;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // buttonConversion
            // 
            buttonConversion.BackColor = Color.Coral;
            buttonConversion.FlatStyle = FlatStyle.Flat;
            buttonConversion.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConversion.ForeColor = Color.White;
            buttonConversion.Location = new Point(1284, 811);
            buttonConversion.Name = "buttonConversion";
            buttonConversion.Size = new Size(179, 83);
            buttonConversion.TabIndex = 7;
            buttonConversion.Text = "Conversion Multiplication";
            buttonConversion.UseVisualStyleBackColor = false;
            buttonConversion.Click += buttonConversion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 212);
            label1.Name = "label1";
            label1.Size = new Size(667, 38);
            label1.TabIndex = 8;
            label1.Text = "Words you have selected will appear here";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Word1
            // 
            Word1.BackColor = Color.WhiteSmoke;
            Word1.Location = new Point(484, 150);
            Word1.Name = "Word1";
            Word1.Size = new Size(263, 39);
            Word1.TabIndex = 9;
            // 
            // Word2
            // 
            Word2.BackColor = Color.WhiteSmoke;
            Word2.Location = new Point(978, 150);
            Word2.Name = "Word2";
            Word2.Size = new Size(263, 39);
            Word2.TabIndex = 10;
            // 
            // WordFunTitle
            // 
            WordFunTitle.AutoSize = true;
            WordFunTitle.BackColor = Color.Transparent;
            WordFunTitle.Font = new Font("Century Gothic", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WordFunTitle.Location = new Point(683, 59);
            WordFunTitle.Name = "WordFunTitle";
            WordFunTitle.Size = new Size(265, 63);
            WordFunTitle.TabIndex = 11;
            WordFunTitle.Text = "Word Fun";
            WordFunTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NullLabel
            // 
            NullLabel.AutoSize = true;
            NullLabel.BackColor = Color.Transparent;
            NullLabel.Font = new Font("Century Gothic", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NullLabel.ForeColor = Color.Red;
            NullLabel.Location = new Point(440, 212);
            NullLabel.Name = "NullLabel";
            NullLabel.Size = new Size(34, 49);
            NullLabel.TabIndex = 12;
            NullLabel.Text = ".";
            // 
            // labelWord1
            // 
            labelWord1.AutoSize = true;
            labelWord1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWord1.Location = new Point(382, 157);
            labelWord1.Name = "labelWord1";
            labelWord1.Size = new Size(96, 32);
            labelWord1.TabIndex = 13;
            labelWord1.Text = "Word 1:";
            // 
            // labelWord2
            // 
            labelWord2.AutoSize = true;
            labelWord2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelWord2.Location = new Point(873, 157);
            labelWord2.Name = "labelWord2";
            labelWord2.Size = new Size(99, 32);
            labelWord2.TabIndex = 14;
            labelWord2.Text = "Word 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1630, 967);
            Controls.Add(labelWord2);
            Controls.Add(labelWord1);
            Controls.Add(NullLabel);
            Controls.Add(WordFunTitle);
            Controls.Add(Word2);
            Controls.Add(Word1);
            Controls.Add(label1);
            Controls.Add(buttonConversion);
            Controls.Add(buttonCompare);
            Controls.Add(buttonPalindrome);
            Controls.Add(buttonPyramid);
            Controls.Add(buttonSquare);
            Controls.Add(buttonMetric);
            Controls.Add(Output);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Michelle Munguia Assignment 4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem wordFunToolStripMenuItem;
        private Button buttonMetric;
        private Button buttonSquare;
        private Button buttonPyramid;
        private Button buttonPalindrome;
        private Button buttonCompare;
        private Button buttonConversion;
        private RichTextBox Output;
        private Label label1;
        private TextBox Word1;
        private TextBox Word2;
        private Label WordFunTitle;
        private ToolStripMenuItem metricsToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem pyramidToolStripMenuItem;
        private ToolStripMenuItem palindromeToolStripMenuItem;
        private ToolStripMenuItem compareToolStripMenuItem;
        private ToolStripMenuItem conversionMultilicationToolStripMenuItem;
        private Label NullLabel;
        private Label labelWord1;
        private Label labelWord2;
    }
}