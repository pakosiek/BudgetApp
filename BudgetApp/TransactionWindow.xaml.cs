using BudgetApp.Model;
using System.Text.RegularExpressions;
using System.Windows;
namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        public Transaction? Transaction { get; set; }
        public TransactionWindow(Transaction transaction)
        {
            InitializeComponent();
            Transaction = transaction;
            tbDate.Text = Transaction.Date;
            tbDescription.Text = Transaction.Description;
            tbCategory.Text = Transaction.Category;
            tbAmount.Text = Transaction.Amount;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            if(
                !Regex.IsMatch(tbDate.Text, @"^(0[1-9]|[12][0-9]|3[01]) (0[1-9]|1[0-2]) \d{4}$")||
                !Regex.IsMatch(tbDescription.Text, @"\S") ||
                !Regex.IsMatch(tbCategory.Text, @"\S") ||
                !Regex.IsMatch(tbAmount.Text, @"^-?\d+([.,]\d{1,2})?$")
                ) {
                MessageBox.Show("The entered data is incorrect");
                return;
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
            => DialogResult = false;
        private void Window_Loaded(object sender, RoutedEventArgs e)
            => tbDate.Focus();
    }
}
