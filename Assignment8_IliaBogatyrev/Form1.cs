namespace Assignment8_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        string[] boyNames;
        string[] girlNames;
        public Form1()
        {
            InitializeComponent();
            boyNames = File.ReadAllLines("BoyNames.txt");
            girlNames = File.ReadAllLines("GirlNames.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchName(string[] names, string name)
        {
            bool found = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                MessageBox.Show(name + " is among the most popular names.");
            }
            else
            {
                MessageBox.Show(name + " is not among the most popular names.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string boyName = boyNameTextBox.Text;
            string girlName = girlNameTextBox.Text;
            if (boyName != "")
            {
                searchName(boyNames, boyName);
            }
            if (girlName != "")
            {
                searchName(girlNames, girlName);
            }
           
        }
    }
}