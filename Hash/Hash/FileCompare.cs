using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class FileCompare : Form
    {
        public FileCompare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button_Path1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            ofd.Filter = "所有文件(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
                this.TextBox_Path1.Text = ofd.FileName;
        }

        private void Button_Path2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            ofd.Filter = "所有文件(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
                this.TextBox_Path2.Text = ofd.FileName;
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            if(this.TextBox_Path1.Text == String.Empty ||
                this.TextBox_Path2.Text == String.Empty)
            {
                MessageBox.Show("目录不能为空");
                return;
            }

            if(!File.Exists(this.TextBox_Path1.Text) || 
                !File.Exists(this.TextBox_Path2.Text))
            {
                MessageBox.Show("文件不存在！");
                return;
            }


            bool flag = true;
            for(int i=0; i<HashTran.hashName.Length; i++)
            {
                string value1 = HashTran.GetFileHashValue(this.TextBox_Path1.Text,
                    HashTran.hashName[i]);

                string value2 = HashTran.GetFileHashValue(this.TextBox_Path2.Text,
                    HashTran.hashName[i]);

                if(value1!=value2)
                {
                    flag = false;
                    break;
                }


            }

            if (flag)
                MessageBox.Show("比较结果：两文件相同！");
            else
                MessageBox.Show("比较结果：两文件不相同！");

        }

        private void FileCompare_Load(object sender, EventArgs e)
        {
            this.Text = "FileCompare";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

            this.TextBox_Path1.ReadOnly = true;
            this.TextBox_Path2.ReadOnly = true;

        }
    }
}
