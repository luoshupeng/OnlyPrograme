namespace OnlyPrograme
{
    partial class FormChild
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
            this.btnGetMainText = new System.Windows.Forms.Button();
            this.btnSetMainText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetMainText
            // 
            this.btnGetMainText.Location = new System.Drawing.Point(85, 85);
            this.btnGetMainText.Name = "btnGetMainText";
            this.btnGetMainText.Size = new System.Drawing.Size(114, 23);
            this.btnGetMainText.TabIndex = 0;
            this.btnGetMainText.Text = "GetMainText";
            this.btnGetMainText.UseVisualStyleBackColor = true;
            this.btnGetMainText.Click += new System.EventHandler(this.btnGetMainText_Click);
            // 
            // btnSetMainText
            // 
            this.btnSetMainText.Location = new System.Drawing.Point(85, 114);
            this.btnSetMainText.Name = "btnSetMainText";
            this.btnSetMainText.Size = new System.Drawing.Size(114, 23);
            this.btnSetMainText.TabIndex = 1;
            this.btnSetMainText.Text = "SetMainText";
            this.btnSetMainText.UseVisualStyleBackColor = true;
            this.btnSetMainText.Click += new System.EventHandler(this.btnSetMainText_Click);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSetMainText);
            this.Controls.Add(this.btnGetMainText);
            this.Name = "FormChild";
            this.Text = "FormChild";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetMainText;
        private System.Windows.Forms.Button btnSetMainText;
    }
}