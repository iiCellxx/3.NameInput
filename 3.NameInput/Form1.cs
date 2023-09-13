namespace _3.NameInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void enterB_Click(object sender, EventArgs e)
        {
            //Strings and INT
            string Fname, Mname, Lname, Barangay, Municipality, Province, Month;
            int Day, Year;
            // Using the Variable using TextBox
            //String
            Fname = fnameTB.Text;
            Mname = mnameTB.Text;
            Lname = lnameTB.Text;
            Barangay = barangayTB.Text;
            Municipality = municipalityTB.Text;
            Province = provinceTB.Text;
            Month = monthTB.Text;
            //Integer
            Day = Int16.Parse(dayTB.Text);
            Year = Int16.Parse(yearTB.Text);
            // Calculate age
            int currentyear = DateTime.Now.Year;
            int age = currentyear - Year;
            //Making The MessageBox
            MessageBox.Show("Hello " + "you are " + Fname + " " + Mname + " " + Lname + " from " + Barangay + " " + Municipality +
                " " + Province + " born on " + Month + ", " + Day + ", " + Year + ", and you are now " + age);



        }
    }
}