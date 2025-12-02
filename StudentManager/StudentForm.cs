using System;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class StudentForm : Form
    {
        public Student Student { get; private set; }

        public StudentForm()
        {
            InitializeComponent();
            Student = new Student();
        }

        public StudentForm(Student student) : this()
        {
            Student = student.Clone();
            txtName.Text = Student.Name;
            txtAge.Text = Student.Age.ToString();
            txtEmail.Text = Student.Email;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student.Name = txtName.Text.Trim();
            Student.Age = age;
            Student.Email = txtEmail.Text?.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}