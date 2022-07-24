namespace SampleInputApp
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label6;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.readOnly = new System.Windows.Forms.CheckBox();
            this.sampleLabel = new System.Windows.Forms.Label();
            this.sampleRichTextBox = new SampleInputApp.RichTextBoxEx();
            this.selectable = new System.Windows.Forms.CheckBox();
            this.borderStyle = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Label:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 42);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Rich Text Box:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 75);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Border Style:";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(21, 108);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Selectable:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(20, 141);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 15);
            label6.TabIndex = 9;
            label6.Text = "Read Only:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sampleLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sampleRichTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectable, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.borderStyle, 1, 2);
            this.tableLayoutPanel1.Controls.Add(label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.readOnly, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // readOnly
            // 
            this.readOnly.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.readOnly.Location = new System.Drawing.Point(92, 135);
            this.readOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.readOnly.Name = "readOnly";
            this.readOnly.Size = new System.Drawing.Size(136, 27);
            this.readOnly.TabIndex = 11;
            this.readOnly.UseVisualStyleBackColor = true;
            // 
            // sampleLabel
            // 
            this.sampleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Location = new System.Drawing.Point(92, 9);
            this.sampleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(38, 15);
            this.sampleLabel.TabIndex = 2;
            this.sampleLabel.Text = "label3";
            // 
            // sampleRichTextBox
            // 
            this.sampleRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleRichTextBox.Location = new System.Drawing.Point(92, 37);
            this.sampleRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sampleRichTextBox.Multiline = false;
            this.sampleRichTextBox.Name = "sampleRichTextBox";
            this.sampleRichTextBox.Size = new System.Drawing.Size(539, 25);
            this.sampleRichTextBox.TabIndex = 3;
            this.sampleRichTextBox.Text = "label3";
            // 
            // selectable
            // 
            this.selectable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectable.Location = new System.Drawing.Point(92, 103);
            this.selectable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectable.Name = "selectable";
            this.selectable.Size = new System.Drawing.Size(136, 25);
            this.selectable.TabIndex = 7;
            this.selectable.UseVisualStyleBackColor = true;
            // 
            // borderStyle
            // 
            this.borderStyle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderStyle.FormattingEnabled = true;
            this.borderStyle.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.borderStyle.Location = new System.Drawing.Point(92, 69);
            this.borderStyle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.borderStyle.Name = "borderStyle";
            this.borderStyle.Size = new System.Drawing.Size(539, 23);
            this.borderStyle.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 186);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.CheckBox readOnly;

        private System.Windows.Forms.CheckBox selectable;

        private System.Windows.Forms.ComboBox borderStyle;

        private System.Windows.Forms.Label sampleLabel;
        private SampleInputApp.RichTextBoxEx sampleRichTextBox;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}