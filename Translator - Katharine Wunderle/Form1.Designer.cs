
namespace Translator___Katharine_Wunderle
{
    partial class japaneseTranslator
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
            this.englishTranslation = new System.Windows.Forms.Label();
            this.ichiButton = new System.Windows.Forms.Button();
            this.niButton = new System.Windows.Forms.Button();
            this.sanButton = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // englishTranslation
            // 
            this.englishTranslation.AutoSize = true;
            this.englishTranslation.Location = new System.Drawing.Point(23, 50);
            this.englishTranslation.Name = "englishTranslation";
            this.englishTranslation.Size = new System.Drawing.Size(99, 13);
            this.englishTranslation.TabIndex = 0;
            this.englishTranslation.Text = "English Translation:";
            // 
            // ichiButton
            // 
            this.ichiButton.Location = new System.Drawing.Point(26, 100);
            this.ichiButton.Name = "ichiButton";
            this.ichiButton.Size = new System.Drawing.Size(75, 23);
            this.ichiButton.TabIndex = 1;
            this.ichiButton.Text = "ichi";
            this.ichiButton.UseVisualStyleBackColor = true;
            this.ichiButton.Click += new System.EventHandler(this.ichiButton_Click);
            // 
            // niButton
            // 
            this.niButton.Location = new System.Drawing.Point(131, 100);
            this.niButton.Name = "niButton";
            this.niButton.Size = new System.Drawing.Size(75, 23);
            this.niButton.TabIndex = 2;
            this.niButton.Text = "ni";
            this.niButton.UseVisualStyleBackColor = true;
            this.niButton.Click += new System.EventHandler(this.niButton_Click);
            // 
            // sanButton
            // 
            this.sanButton.Location = new System.Drawing.Point(231, 100);
            this.sanButton.Name = "sanButton";
            this.sanButton.Size = new System.Drawing.Size(75, 23);
            this.sanButton.TabIndex = 3;
            this.sanButton.Text = "san";
            this.sanButton.UseVisualStyleBackColor = true;
            this.sanButton.Click += new System.EventHandler(this.sanButton_Click);
            // 
            // translationLabel
            // 
            this.translationLabel.Location = new System.Drawing.Point(128, 50);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(49, 13);
            this.translationLabel.TabIndex = 4;
            // 
            // japaneseTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 153);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.sanButton);
            this.Controls.Add(this.niButton);
            this.Controls.Add(this.ichiButton);
            this.Controls.Add(this.englishTranslation);
            this.Name = "japaneseTranslator";
            this.Text = "Japanese Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label englishTranslation;
        private System.Windows.Forms.Button ichiButton;
        private System.Windows.Forms.Button niButton;
        private System.Windows.Forms.Button sanButton;
        private System.Windows.Forms.Label translationLabel;
    }
}

