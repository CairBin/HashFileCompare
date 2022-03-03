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
    public partial class TextHash : Form
    {

        public TextHash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FileHash_Load(object sender, EventArgs e)
        {
            this.Text = "TextHash";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.ComBox_HashAlg.DataSource = HashTran.hashName;
            this.ComBox_HashAlg.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            this.TxtBox_Value.Text = HashTran.GetTxtHashValue(this.TxtBox_Txt.Text,
                ComBox_HashAlg.Text);
        }
    }
}
