using System.Diagnostics.CodeAnalysis;

namespace RichTextBoxDemo
{
    public partial class Form1 : Form
    {
        private const string SampleText = "Lorem ipsum";
        
        public Form1()
        {
            InitializeComponent();
            this.sampleLabel.Text = SampleText;
            this.sampleRichTextBox.Text = SampleText;
            this.borderStyle.Items.Clear();
            this.borderStyle.Items.Add(BorderStyle.None);
            // RichTextBox doesn't support FixedSingle
            this.borderStyle.Items.Add(BorderStyle.Fixed3D);
            
            this.selectable.Checked = this.sampleRichTextBox.Selectable;
            this.readOnly.Checked = this.sampleRichTextBox.ReadOnly;
            this.borderStyle.SelectedItem = this.sampleRichTextBox.BorderStyle;
            
            this.readOnly.CheckedChanged += ReadOnlyOnCheckedChanged;
            this.selectable.CheckedChanged += SelectableOnCheckedChanged;
            this.borderStyle.SelectedIndexChanged += BorderStyleOnSelectedIndexChanged;
        }


        
        private void BorderStyleOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            if (this.borderStyle.SelectedItem is BorderStyle style)
            {
                this.sampleRichTextBox.BorderStyle = style;
            }
        }
        
        private void SelectableOnCheckedChanged(object? sender, EventArgs e)
        {
            this.sampleRichTextBox.Selectable = this.selectable.Checked;
        }

        private void ReadOnlyOnCheckedChanged(object? sender, EventArgs e)
        {
            this.sampleRichTextBox.ReadOnly = this.readOnly.Checked;
        }



    }
}