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

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                //grabs selected row > retrieves data > converts it to BankAccount type
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                //adds deposit value to balance
                string message = selectedBankAccount.Deposit(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            //checks if a row has been selected 
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                //grabs selected row > retrieves data > converts it to BankAccount type
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                //adds deposit value to balance
                string message = selectedBankAccount.Withdraw(AmountNum.Value);

                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message);
            }
        }
    }
}
