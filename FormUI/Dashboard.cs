using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        private List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            people = db.GetPeople(lastNameText.Text);
            UpdateBinding();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var db = new DataAccess();
            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailInsText.Text, phoneInsText.Text);
        }
    }
}