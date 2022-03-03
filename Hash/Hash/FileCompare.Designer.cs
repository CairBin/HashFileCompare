namespace Hash
{
    partial class FileCompare
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
            this.TextBox_Path1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Path1 = new System.Windows.Forms.Button();
            this.TextBox_Path2 = new System.Windows.Forms.TextBox();
            this.Button_Path2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Path1
            // 
            this.TextBox_Path1.Location = new System.Drawing.Point(12, 46);
            this.TextBox_Path1.Name = "TextBox_Path1";
            this.TextBox_Path1.Size = new System.Drawing.Size(227, 23);
            this.TextBox_Path1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件目录";
            // 
            // Button_Path1
            // 
            this.Button_Path1.Location = new System.Drawing.Point(254, 45);
            this.Button_Path1.Name = "Button_Path1";
            this.Button_Path1.Size = new System.Drawing.Size(84, 24);
            this.Button_Path1.TabIndex = 2;
            this.Button_Path1.Text = "...";
            this.Button_Path1.UseVisualStyleBackColor = true;
            this.Button_Path1.Click += new System.EventHandler(this.Button_Path1_Click);
            // 
            // TextBox_Path2
            // 
            this.TextBox_Path2.Location = new System.Drawing.Point(12, 101);
            this.TextBox_Path2.Name = "TextBox_Path2";
            this.TextBox_Path2.Size = new System.Drawing.Size(227, 23);
            this.TextBox_Path2.TabIndex = 3;
            // 
            // Button_Path2
            // 
            this.Button_Path2.Location = new System.Drawing.Point(254, 101);
            this.Button_Path2.Name = "Button_Path2";
            this.Button_Path2.Size = new System.Drawing.Size(84, 24);
            this.Button_Path2.TabIndex = 4;
            this.Button_Path2.Text = "...";
            this.Button_Path2.UseVisualStyleBackColor = true;
            this.Button_Path2.Click += new System.EventHandler(this.Button_Path2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件目录";
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(12, 145);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(326, 40);
            this.Button_Run.TabIndex = 6;
            this.Button_Run.Text = "比较";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // FileCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Path2);
            this.Controls.Add(this.TextBox_Path2);
            this.Controls.Add(this.Button_Path1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Path1);
            this.Name = "FileCompare";
            this.Text = "FileCompare";
            this.Load += new System.EventHandler(this.FileCompare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox_Path1;
        private Label label1;
        private Button Button_Path1;
        private TextBox TextBox_Path2;
        private Button Button_Path2;
        private Label label2;
        private Button Button_Run;
    }
}