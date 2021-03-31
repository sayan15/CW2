
namespace CW2
{
    partial class CloseIcon
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
            this.clostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clostButton
            // 
            this.clostButton.BackgroundImage = global::CW2.Properties.Resources.close;
            this.clostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clostButton.Location = new System.Drawing.Point(0, 0);
            this.clostButton.Name = "clostButton";
            this.clostButton.Size = new System.Drawing.Size(21, 23);
            this.clostButton.TabIndex = 0;
            this.clostButton.UseVisualStyleBackColor = true;
            
            // 
            // CloseIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clostButton);
            this.Name = "CloseIcon";
            this.Size = new System.Drawing.Size(21, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clostButton;
    }
}
