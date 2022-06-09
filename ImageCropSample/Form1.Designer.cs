namespace ImageCropSample
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
            this.crop1Button = new System.Windows.Forms.Button();
            this.crop2Button = new System.Windows.Forms.Button();
            this.embeddedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crop1Button
            // 
            this.crop1Button.Location = new System.Drawing.Point(34, 110);
            this.crop1Button.Name = "crop1Button";
            this.crop1Button.Size = new System.Drawing.Size(112, 34);
            this.crop1Button.TabIndex = 0;
            this.crop1Button.Text = "Crop1";
            this.crop1Button.UseVisualStyleBackColor = true;
            this.crop1Button.Click += new System.EventHandler(this.crop1Button_Click);
            // 
            // crop2Button
            // 
            this.crop2Button.Location = new System.Drawing.Point(173, 110);
            this.crop2Button.Name = "crop2Button";
            this.crop2Button.Size = new System.Drawing.Size(112, 34);
            this.crop2Button.TabIndex = 1;
            this.crop2Button.Text = "Crop2";
            this.crop2Button.UseVisualStyleBackColor = true;
            this.crop2Button.Click += new System.EventHandler(this.crop2Button_Click);
            // 
            // embeddedButton
            // 
            this.embeddedButton.Location = new System.Drawing.Point(317, 110);
            this.embeddedButton.Name = "embeddedButton";
            this.embeddedButton.Size = new System.Drawing.Size(112, 34);
            this.embeddedButton.TabIndex = 2;
            this.embeddedButton.Text = "Embedded";
            this.embeddedButton.UseVisualStyleBackColor = true;
            this.embeddedButton.Click += new System.EventHandler(this.embeddedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.embeddedButton);
            this.Controls.Add(this.crop2Button);
            this.Controls.Add(this.crop1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crop1Button;
        private System.Windows.Forms.Button crop2Button;
        private System.Windows.Forms.Button embeddedButton;
    }
}
