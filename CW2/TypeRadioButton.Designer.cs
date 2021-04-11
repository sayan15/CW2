
namespace CW2
{
    partial class TypeRadioButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneTimeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.repeatRadioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // oneTimeRadioButton1
            // 
            this.oneTimeRadioButton1.AutoSize = true;
            this.oneTimeRadioButton1.Checked = true;
            this.oneTimeRadioButton1.Location = new System.Drawing.Point(3, 17);
            this.oneTimeRadioButton1.Name = "oneTimeRadioButton1";
            this.oneTimeRadioButton1.Size = new System.Drawing.Size(98, 24);
            this.oneTimeRadioButton1.TabIndex = 0;
            this.oneTimeRadioButton1.TabStop = true;
            this.oneTimeRadioButton1.Text = "OneTime";
            this.oneTimeRadioButton1.UseVisualStyleBackColor = true;
            this.oneTimeRadioButton1.CheckedChanged += new System.EventHandler(this.oneTimeRadioButton1_CheckedChanged);
            // 
            // repeatRadioButton1
            // 
            this.repeatRadioButton1.AutoSize = true;
            this.repeatRadioButton1.Location = new System.Drawing.Point(153, 17);
            this.repeatRadioButton1.Name = "repeatRadioButton1";
            this.repeatRadioButton1.Size = new System.Drawing.Size(87, 24);
            this.repeatRadioButton1.TabIndex = 1;
            this.repeatRadioButton1.Text = "Repeat";
            this.repeatRadioButton1.UseVisualStyleBackColor = true;
            this.repeatRadioButton1.CheckedChanged += new System.EventHandler(this.repeatRadioButton1_CheckedChanged);
            // 
            // TypeRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.repeatRadioButton1);
            this.Controls.Add(this.oneTimeRadioButton1);
            this.Name = "TypeRadioButton";
            this.Size = new System.Drawing.Size(265, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton oneTimeRadioButton1;
        private System.Windows.Forms.RadioButton repeatRadioButton1;
    }
}
