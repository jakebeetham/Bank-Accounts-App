using System.Security;

namespace Bank_Accounts_App
{
    public partial class Form1 : Form
    {
        //creating empty list
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            //checks if Owner text box is empty
            if (string.IsNullOrEmpty(OwnerTxt.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text); //grabs text from Owner Label
            BankAccounts.Add(bankAccount); //adds text from Owner using above + Account Number and Balance from constructor
            RefreshGrid(); //calls Refresh Grid method

            OwnerTxt.Text = string.Empty; //clears text box after submitting new bank account

        }
        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null; //clears grid
            BankAccountsGrid.DataSource = BankAccounts; //updates grid with new list
        }
    }
}
