namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        static string upperCaselist = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string lowerCaselist = "abcdefghijklmnopqrstuvwxyz";
        static string numericCaselist = "0123456789";
        static string symbolCaselist = "!@#$%^&*(){}[]=<>/,.";

        string allCharlist = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtlength.Text = "20";
        }

        private void BuildCharlist()
        {
            allCharlist = string.Empty;

            if (chklowercase.Checked)
                allCharlist += lowerCaselist;
            if (chkuppercase.Checked)
                allCharlist += upperCaselist;
            if (chknumber.Checked)
                allCharlist += numericCaselist;
            if (chksymbols.Checked)
                allCharlist += symbolCaselist;

            if (string.IsNullOrEmpty(allCharlist))
                allCharlist = lowerCaselist + upperCaselist + numericCaselist + symbolCaselist;

        }

        private string GeneratePassword(int length)
        {
            string newPassword = string.Empty;

            if (length < 6)
                throw new Exception("A strong password needs to have more than 6 character");

            for (int i = 0; i < length; i++)
            {
                newPassword += GetRandomChar();
            }

            return newPassword;
        }

        private string GetRandomChar()
        {
            return allCharlist.ToCharArray()[(int)Math.Floor(_random.NextDouble() * allCharlist.Length)].ToString();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            try
            {
                BuildCharlist();
                txtpassword.Text = GeneratePassword(int.Parse(txtlength.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtlength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled= true;

            }
        }
    }
}