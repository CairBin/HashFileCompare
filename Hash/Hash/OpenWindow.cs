namespace Hash
{
    public partial class OpenWindow : Form
    {
        private string[] name = { "�ļ��Ƚ�","�ı�", "�ļ�" };
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
            if(this.ComBox_Choose.Text == "�ı�")
            {
                TextHash tHash = new TextHash();
                tHash.Show();
            }
            else if(this.ComBox_Choose.Text == "�ļ�")
            {
                FileHash fHash = new FileHash();
                fHash.Show();
            }
            else if(this.ComBox_Choose.Text == "�ļ��Ƚ�")
            {
                FileCompare fileCompare = new FileCompare();
                fileCompare.Show();
            }
        }
    }
}