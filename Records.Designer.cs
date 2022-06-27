namespace Contact_Tracing_Form
{
    partial class Records
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
            this.RecordstextBox = new System.Windows.Forms.TextBox();
            this.Listbutton = new System.Windows.Forms.Button();
            this.RecordListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RecordstextBox
            // 
            this.RecordstextBox.Location = new System.Drawing.Point(458, 58);
            this.RecordstextBox.Multiline = true;
            this.RecordstextBox.Name = "RecordstextBox";
            this.RecordstextBox.Size = new System.Drawing.Size(293, 276);
            this.RecordstextBox.TabIndex = 0;
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(12, 12);
            this.Listbutton.Name = "Listbutton";
            this.Listbutton.Size = new System.Drawing.Size(124, 40);
            this.Listbutton.TabIndex = 1;
            this.Listbutton.Text = "List all Records";
            this.Listbutton.UseVisualStyleBackColor = true;
            this.Listbutton.Click += new System.EventHandler(this.Listbutton_Click);
            // 
            // RecordListbox
            // 
            this.RecordListbox.FormattingEnabled = true;
            this.RecordListbox.ItemHeight = 16;
            this.RecordListbox.Location = new System.Drawing.Point(12, 58);
            this.RecordListbox.Name = "RecordListbox";
            this.RecordListbox.Size = new System.Drawing.Size(427, 276);
            this.RecordListbox.TabIndex = 2;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 452);
            this.Controls.Add(this.RecordListbox);
            this.Controls.Add(this.Listbutton);
            this.Controls.Add(this.RecordstextBox);
            this.Name = "Records";
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecordstextBox;
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.ListBox RecordListbox;
    }
}