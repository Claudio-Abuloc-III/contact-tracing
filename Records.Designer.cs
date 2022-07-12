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
            this.Listbutton = new System.Windows.Forms.Button();
            this.RecordListbox = new System.Windows.Forms.ListBox();
            this.SearchDateButton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.FilteredlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Listbutton
            // 
            this.Listbutton.Location = new System.Drawing.Point(626, 8);
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
            this.RecordListbox.Location = new System.Drawing.Point(682, 54);
            this.RecordListbox.Name = "RecordListbox";
            this.RecordListbox.Size = new System.Drawing.Size(427, 276);
            this.RecordListbox.TabIndex = 2;
            // 
            // SearchDateButton
            // 
            this.SearchDateButton.Location = new System.Drawing.Point(12, 25);
            this.SearchDateButton.Name = "SearchDateButton";
            this.SearchDateButton.Size = new System.Drawing.Size(136, 23);
            this.SearchDateButton.TabIndex = 3;
            this.SearchDateButton.Text = "Search Date";
            this.SearchDateButton.UseVisualStyleBackColor = true;
            this.SearchDateButton.Click += new System.EventHandler(this.SearchDateButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(154, 26);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(265, 22);
            this.SearchtextBox.TabIndex = 4;
            // 
            // FilteredlistBox
            // 
            this.FilteredlistBox.FormattingEnabled = true;
            this.FilteredlistBox.ItemHeight = 16;
            this.FilteredlistBox.Location = new System.Drawing.Point(13, 54);
            this.FilteredlistBox.Name = "FilteredlistBox";
            this.FilteredlistBox.Size = new System.Drawing.Size(406, 260);
            this.FilteredlistBox.TabIndex = 5;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 566);
            this.Controls.Add(this.FilteredlistBox);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.SearchDateButton);
            this.Controls.Add(this.RecordListbox);
            this.Controls.Add(this.Listbutton);
            this.Name = "Records";
            this.Text = "Records";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Listbutton;
        private System.Windows.Forms.ListBox RecordListbox;
        private System.Windows.Forms.Button SearchDateButton;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.ListBox FilteredlistBox;
    }
}