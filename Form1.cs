namespace Lottery
{
    public partial class Form1 : Form
    {
        int money = 100;
        int bet;
        

        public Form1()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBet.Text, out bet ))
            {
                MessageBox.Show("The Bet is an invalid number");
            }
            else
            {

                if (cmbBet.Text == "")
                {
                    MessageBox.Show("You need to choose an option to bet");
                }
                else
                {

                    if (bet <= 0)
                    {
                        MessageBox.Show("The bet cannot be zero or less");
                    }
                    else
                    {
                        if (bet > money)
                        {
                            MessageBox.Show("You cannot bet more money than you have");
                        }
                        else
                        {
                            Random rnd = new Random();
                            int number = rnd.Next(1, 10);
                            lblResult.Text = "The number that is choosen is  " + number.ToString() + Environment.NewLine;

                            bool isTheNumberEven;
                            if (number % 2 == 0)
                            {
                                isTheNumberEven = true;
                                lblResult.Text = lblResult.Text + " The number is even  " + Environment.NewLine;
                            }
                            else
                            {
                                isTheNumberEven = false;
                                lblResult.Text = lblResult.Text + " The number is odd "+ Environment.NewLine;
                            }

                            if (isTheNumberEven)
                            {
                                if (cmbBet.Text == "Even")
                                {
                                    money += bet;
                                    lblResult.Text = lblResult.Text + "You win";
                                }
                                else
                                {
                                    money -= bet;
                                    lblResult.Text = lblResult.Text + "You lost";
                                }
                            }
                            else
                            {
                                if (cmbBet.Text == "Odd")
                                {
                                    money += bet;
                                    lblResult.Text = lblResult.Text + "You win";
                                }
                                else
                                {
                                    money -= bet;
                                    lblResult.Text = lblResult.Text + "You lost";
                                }
                            }

                            lblMoney.Text = money.ToString();
                        }
                    }
                }
            }
        }
    }
}
