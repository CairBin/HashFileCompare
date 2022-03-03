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
    public partial class FileHash : Form
    {
        public FileHash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FileHash_Load(object sender, EventArgs e)
        {
            this.Text = "FileHash";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

            this.ComBox.DataSource = HashTran.hashName;
            this.ComBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.TextBox_Path.ReadOnly = true;

        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            ofd.Filter = "所有文件(*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
                this.TextBox_Path.Text = ofd.FileName;

        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            if(this.TextBox_Path.Text == String.Empty)
            {
                MessageBox.Show("文件目录不能为空!");
                return;
            }

            if(!File.Exists(this.TextBox_Path.Text))
            {
                MessageBox.Show("文件不存在！");
                return;
            }

            this.TextBox_Value.Text = HashTran.GetFileHashValue(this.TextBox_Path.Text, this.ComBox.Text);
        }
    }
}
