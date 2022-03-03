namespace Hash
{
    partial class TextHash
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
            this.TxtBox_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBox_HashAlg = new System.Windows.Forms.ComboBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.TxtBox_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_Txt
            // 
            this.TxtBox_Txt.Location = new System.Drawing.Point(12, 36);
            this.TxtBox_Txt.Multiline = true;
            this.TxtBox_Txt.Name = "TxtBox_Txt";
            this.TxtBox_Txt.Size = new System.Drawing.Size(380, 97);
            this.TxtBox_Txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入文本";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComBox_HashAlg
            // 
            this.ComBox_HashAlg.FormattingEnabled = true;
            this.ComBox_HashAlg.Location = new System.Drawing.Point(12, 155);
            this.ComBox_HashAlg.Name = "ComBox_HashAlg";
            this.ComBox_HashAlg.Size = new System.Drawing.Size(179, 25);
            this.ComBox_HashAlg.TabIndex = 2;
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(215, 154);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(177, 26);
            this.Button_Run.TabIndex = 3;
            this.Button_Run.Text = "运行";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // TxtBox_Value
            // 
            this.TxtBox_Value.Location = new System.Drawing.Point(12, 218);
            this.TxtBox_Value.Multiline = true;
            this.TxtBox_Value.Name = "TxtBox_Value";
            this.TxtBox_Value.Size = new System.Drawing.Size(380, 97);
            this.TxtBox_Value.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "值";
            // 
            // FileHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_Value);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.ComBox_HashAlg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Txt);
            this.Name = "FileHash";
            this.Text = "FileHash";
            this.Load += new System.EventHandler(this.FileHash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBox_Txt;
        private Label label1;
        private ComboBox ComBox_HashAlg;
        private Button Button_Run;
        private TextBox TxtBox_Value;
        private Label label2;
    }
}