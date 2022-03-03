namespace Hash
{
    partial class OpenWindow
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
            this.ComBox_Choose = new System.Windows.Forms.ComboBox();
            this.Button_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComBox_Choose
            // 
            this.ComBox_Choose.FormattingEnabled = true;
            this.ComBox_Choose.Location = new System.Drawing.Point(12, 27);
            this.ComBox_Choose.Name = "ComBox_Choose";
            this.ComBox_Choose.Size = new System.Drawing.Size(187, 25);
            this.ComBox_Choose.TabIndex = 0;
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(12, 75);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(187, 37);
            this.Button_Open.TabIndex = 1;
            this.Button_Open.Text = "打开";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // OpenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 133);
            this.Controls.Add(this.Button_Open);
            this.Controls.Add(this.ComBox_Choose);
            this.Name = "OpenWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox ComBox_Choose;
        private Button Button_Open;
    }
}