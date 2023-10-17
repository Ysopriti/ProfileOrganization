using System.Text.RegularExpressions;
namespace ProfileOrganization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _FullName;
        private int _Age;
        private string _ContactNo;
        private long _StudentNo;

        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException formatexception)
            {
                MessageBox.Show("Invalid Student Number !!!");
            }

            return _StudentNo;
        }

        public string ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = Contact;
            }
            else
            {
                MessageBox.Show("Invalid Contact Number !!!");
            }

            return _ContactNo;
        }
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName,
                @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                MessageBox.Show("Please fill up your Full Name !!!");
            }
            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                MessageBox.Show("Enter your Age !!!");
            }

            return _Age;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text,
                   txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = "+63" + ContactNo(txtContactNo.Text.Substring(1));
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyy-MM-dd");

            }
            catch (FormatException formatexception)
            {
                MessageBox.Show("Format Exception");
            }
            catch (ArgumentNullException argument)
            {
                MessageBox.Show("Argument Null Exception");
            }
            catch (OverflowException overflow)
            {
                MessageBox.Show("Overflow Exception");
            }
            catch (IndexOutOfRangeException indexout)
            {
                MessageBox.Show("Index Out Of Range Exception");
            }
            finally
            {
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }

        }

    }
}

