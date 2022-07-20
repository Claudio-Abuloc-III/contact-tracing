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
            this.components = new System.ComponentModel.Container();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.QRlabel = new System.Windows.Forms.Label();
            this.QRpictureBox = new System.Windows.Forms.PictureBox();
            this.QRtextBox = new System.Windows.Forms.TextBox();
            this.ReadQRbutton = new System.Windows.Forms.Button();
            this.Cameralabel = new System.Windows.Forms.Label();
            this.QRcomboBox = new System.Windows.Forms.ComboBox();
            this.ReadQRpictureBox = new System.Windows.Forms.PictureBox();
            this.ReadQRtextBox = new System.Windows.Forms.TextBox();
            this.QRtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadQRpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Generatebutton
            // 
            this.Generatebutton.BackColor = System.Drawing.Color.Teal;
            this.Generatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generatebutton.ForeColor = System.Drawing.Color.Snow;
            this.Generatebutton.Location = new System.Drawing.Point(178, 417);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(175, 43);
            this.Generatebutton.TabIndex = 0;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = false;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // QRlabel
            // 
            this.QRlabel.AutoSize = true;
            this.QRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRlabel.ForeColor = System.Drawing.Color.Snow;
            this.QRlabel.Location = new System.Drawing.Point(34, 41);
            this.QRlabel.Name = "QRlabel";
            this.QRlabel.Size = new System.Drawing.Size(151, 32);
            this.QRlabel.TabIndex = 1;
            this.QRlabel.Text = "QR CODE";
            // 
            // QRpictureBox
            // 
            this.QRpictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.QRpictureBox.Location = new System.Drawing.Point(28, 76);
            this.QRpictureBox.Name = "QRpictureBox";
            this.QRpictureBox.Size = new System.Drawing.Size(393, 325);
            this.QRpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.QRpictureBox.TabIndex = 2;
            this.QRpictureBox.TabStop = false;
            // 
            // QRtextBox
            // 
            this.QRtextBox.Location = new System.Drawing.Point(437, 92);
            this.QRtextBox.Multiline = true;
            this.QRtextBox.Name = "QRtextBox";
            this.QRtextBox.Size = new System.Drawing.Size(261, 230);
            this.QRtextBox.TabIndex = 3;
            // 
            // ReadQRbutton
            // 
            this.ReadQRbutton.BackColor = System.Drawing.Color.Teal;
            this.ReadQRbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadQRbutton.ForeColor = System.Drawing.Color.Snow;
            this.ReadQRbutton.Location = new System.Drawing.Point(852, 436);
            this.ReadQRbutton.Name = "ReadQRbutton";
            this.ReadQRbutton.Size = new System.Drawing.Size(159, 43);
            this.ReadQRbutton.TabIndex = 4;
            this.ReadQRbutton.Text = "Read QR";
            this.ReadQRbutton.UseVisualStyleBackColor = false;
            this.ReadQRbutton.Click += new System.EventHandler(this.ReadQRbutton_Click);
            // 
            // Cameralabel
            // 
            this.Cameralabel.AutoSize = true;
            this.Cameralabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cameralabel.ForeColor = System.Drawing.Color.Snow;
            this.Cameralabel.Location = new System.Drawing.Point(726, 54);
            this.Cameralabel.Name = "Cameralabel";
            this.Cameralabel.Size = new System.Drawing.Size(120, 32);
            this.Cameralabel.TabIndex = 5;
            this.Cameralabel.Text = "Camera";
            // 
            // QRcomboBox
            // 
            this.QRcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QRcomboBox.FormattingEnabled = true;
            this.QRcomboBox.Location = new System.Drawing.Point(852, 62);
            this.QRcomboBox.Name = "QRcomboBox";
            this.QRcomboBox.Size = new System.Drawing.Size(321, 24);
            this.QRcomboBox.TabIndex = 6;
            // 
            // ReadQRpictureBox
            // 
            this.ReadQRpictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReadQRpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReadQRpictureBox.Location = new System.Drawing.Point(852, 92);
            this.ReadQRpictureBox.Name = "ReadQRpictureBox";
            this.ReadQRpictureBox.Size = new System.Drawing.Size(321, 230);
            this.ReadQRpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReadQRpictureBox.TabIndex = 7;
            this.ReadQRpictureBox.TabStop = false;
            // 
            // ReadQRtextBox
            // 
            this.ReadQRtextBox.Location = new System.Drawing.Point(852, 342);
            this.ReadQRtextBox.Multiline = true;
            this.ReadQRtextBox.Name = "ReadQRtextBox";
            this.ReadQRtextBox.Size = new System.Drawing.Size(321, 51);
            this.ReadQRtextBox.TabIndex = 8;
            // 
            // QRtimer
            // 
            this.QRtimer.Interval = 1000;
            this.QRtimer.Tick += new System.EventHandler(this.QRtimer_Tick);
            // 
            // QRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1332, 586);
            this.Controls.Add(this.ReadQRtextBox);
            this.Controls.Add(this.ReadQRpictureBox);
            this.Controls.Add(this.QRcomboBox);
            this.Controls.Add(this.Cameralabel);
            this.Controls.Add(this.ReadQRbutton);
            this.Controls.Add(this.QRtextBox);
            this.Controls.Add(this.QRpictureBox);
            this.Controls.Add(this.QRlabel);
            this.Controls.Add(this.Generatebutton);
            this.Name = "QRForm";
            this.Text = "QRForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRForm_FormClosing);
            this.Load += new System.EventHandler(this.QRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReadQRpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.Label QRlabel;
        private System.Windows.Forms.PictureBox QRpictureBox;
        private System.Windows.Forms.TextBox QRtextBox;
        private System.Windows.Forms.Button ReadQRbutton;
        private System.Windows.Forms.Label Cameralabel;
        private System.Windows.Forms.ComboBox QRcomboBox;
        private System.Windows.Forms.PictureBox ReadQRpictureBox;
        private System.Windows.Forms.TextBox ReadQRtextBox;
        private System.Windows.Forms.Timer QRtimer;
    }
}