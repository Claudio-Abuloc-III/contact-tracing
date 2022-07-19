namespace Contact_Tracing_Form
{
    partial class QRForm
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
            this.Generatebutton = new System.Windows.Forms.Button();
            this.QRlabel = new System.Windows.Forms.Label();
            this.QRpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Generatebutton
            // 
            this.Generatebutton.BackColor = System.Drawing.Color.Teal;
            this.Generatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generatebutton.ForeColor = System.Drawing.Color.Snow;
            this.Generatebutton.Location = new System.Drawing.Point(156, 407);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(110, 33);
            this.Generatebutton.TabIndex = 0;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = false;
            // 
            // QRlabel
            // 
            this.QRlabel.AutoSize = true;
            this.QRlabel.ForeColor = System.Drawing.Color.Snow;
            this.QRlabel.Location = new System.Drawing.Point(25, 57);
            this.QRlabel.Name = "QRlabel";
            this.QRlabel.Size = new System.Drawing.Size(68, 16);
            this.QRlabel.TabIndex = 1;
            this.QRlabel.Text = "QR CODE";
            // 
            // QRpictureBox
            // 
            this.QRpictureBox.Location = new System.Drawing.Point(28, 76);
            this.QRpictureBox.Name = "QRpictureBox";
            this.QRpictureBox.Size = new System.Drawing.Size(393, 325);
            this.QRpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QRpictureBox.TabIndex = 2;
            this.QRpictureBox.TabStop = false;
            // 
            // QRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1332, 586);
            this.Controls.Add(this.QRpictureBox);
            this.Controls.Add(this.QRlabel);
            this.Controls.Add(this.Generatebutton);
            this.Name = "QRForm";
            this.Text = "QRForm";
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.Label QRlabel;
        private System.Windows.Forms.PictureBox QRpictureBox;
    }
}