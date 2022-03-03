namespace Hash
{
    public partial class OpenWindow : Form
    {
        private string[] name = { "文件比较","文本", "文件" };
        public OpenWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hash";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

            this.ComBox_Choose.DataSource = name;
            this.ComBox_Choose.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            if(this.ComBox_Choose.Text == "文本")
            {
                TextHash tHash = new TextHash();
                tHash.Show();
            }
            else if(this.ComBox_Choose.Text == "文件")
            {
                FileHash fHash = new FileHash();
                fHash.Show();
            }
            else if(this.ComBox_Choose.Text == "文件比较")
            {
                FileCompare fileCompare = new FileCompare();
                fileCompare.Show();
            }
        }
    }
}