namespace Hash
{
    partial class FileHash
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
            this.TextBox_Path = new System.Windows.Forms.TextBox();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Value = new System.Windows.Forms.TextBox();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.值 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox_Path
            // 
            this.TextBox_Path.Location = new System.Drawing.Point(12, 39);
            this.TextBox_Path.Name = "TextBox_Path";
            this.TextBox_Path.Size = new System.Drawing.Size(276, 23);
            this.TextBox_Path.TabIndex = 0;
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.Location = new System.Drawing.Point(304, 39);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenFile.TabIndex = 1;
            this.Button_OpenFile.Text = "...";
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件目录";
            // 
            // TextBox_Value
            // 
            this.TextBox_Value.Location = new System.Drawing.Point(12, 170);
            this.TextBox_Value.Multiline = true;
            this.TextBox_Value.Name = "TextBox_Value";
            this.TextBox_Value.Size = new System.Drawing.Size(367, 165);
            this.TextBox_Value.TabIndex = 3;
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(12, 96);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(276, 25);
            this.ComBox.TabIndex = 4;
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(304, 96);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 25);
            this.Button_Run.TabIndex = 5;
            this.Button_Run.Text = "运行";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // 值
            // 
            this.值.AutoSize = true;
            this.值.Location = new System.Drawing.Point(12, 150);
            this.值.Name = "值";
            this.值.Size = new System.Drawing.Size(20, 17);
            this.值.TabIndex = 6;
            this.值.Text = "值";
            // 
            // FileHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 347);
            this.Controls.Add(this.值);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.ComBox);
            this.Controls.Add(this.TextBox_Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_OpenFile);
            this.Controls.Add(this.TextBox_Path);
            this.Name = "FileHash";
            this.Text = "FileHash";
            this.Load += new System.EventHandler(this.FileHash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox_Path;
        private Button Button_OpenFile;
        private Label label1;
        private TextBox TextBox_Value;
        private ComboBox ComBox;
        private Button Button_Run;
        private Label 值;
    }
}