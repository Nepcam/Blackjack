using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PracP2
{
    public partial class BlackjackForm : Form
    {
        //#############################################################################################
        //# Instance variables
        /// <summary>
        /// Random number generator, used to generate cards.
        /// </summary>
        private Random randomGenerator = new Random();

        private Card playerCard1;
        private Card playerCard2;

        List<Card> playerCardList = new List<Card>();

        private Card dealerCard1;
        private Card dealerCard2;

        // declare variables
        int playerBet = 0;
        int totalMoney = 100;

        //#############################################################################################
        //# Constants
        /// <summary>
        /// Total number of cards
        /// </summary>
        private const int NUM_CARDS = 52;
        /// <summary>
        /// Maximum points allowed before going bust
        /// </summary>
        private const int BLACKJACK = 21;
        /// <summary>
        /// Initial amount of money available to the player (to implement betting).
        /// </summary>
        private const int START_MONEY = 100;


        //#############################################################################################
        //# Constructor
        public BlackjackForm()
        {
            InitializeComponent();
            // Prevent the user from resising the form
            MinimumSize = MaximumSize = Size;
            totalMoney = START_MONEY;
            textBoxMoneyLeft_.Text = totalMoney.ToString();
        }


        //#############################################################################################
        //# Event Handlers
        private void buttonDealFirstCard_Click(object sender, EventArgs e)
        {
            // Generate 4 new random cards
            playerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            playerCard2 = new Card(randomGenerator.Next(NUM_CARDS));

            // add generated random cards to List<Card> playerCardList
            playerCardList.Add(playerCard1);
            dealerCard1 = new Card(randomGenerator.Next(NUM_CARDS));

            playerCardList.Add(playerCard2);
            dealerCard2 = new Card(randomGenerator.Next(NUM_CARDS));

            // Display the first card to player and dealer
            //textBoxPlayerCard1_.Text = playerCard1.ToString();
            textBoxDealerCard1_.Text = dealerCard1.ToString();

            // display the first card to the listbox from List<Card> playerCardList
            listBoxPlayerCards.Items.Add(playerCardList[0].ToString());
            //listBoxPlayerCards.Items.Add(playerCardList[1].ToString());

            // Clear the second card and totals
            textBoxPlayerCard2_.Text = "";
            textBoxPlayerTotal_.Text = "";
            textBoxDealerCard2_.Text = "";
            textBoxDealerTotal_.Text = "";

            // player starts game with $100 after the first card is shown
            //textBoxMoneyLeft_.Text = totalMoney.ToString();                          
        }

        private void buttonDealSecondCard_Click(object sender, EventArgs e)
        {
            //display second two cards and total
            listBoxPlayerCards.Items.Add(playerCardList[1].ToString());
            //textBoxPlayerCard2_.Text = playerCard2.ToString();
            textBoxDealerCard2_.Text = dealerCard2.ToString();

            int playerTotal = playerCard1.Points + playerCard2.Points;
            int dealerTotal = dealerCard1.Points + dealerCard2.Points;

            textBoxPlayerTotal_.Text = playerTotal.ToString();
            textBoxDealerTotal_.Text = dealerTotal.ToString();

            // init MakeBet object and pass in the starting amount 
            // MakeBet playBlackJack = new MakeBet();

            try
            {
                // get bet amount from the textBoxBet_ 
                playerBet = int.Parse(textBoxBet_.Text);              
                listBoxPlayerCards.Items.Add(playerCardList[1].ToString());

                if (playerTotal > BLACKJACK)
                {
                    // Player bust: loses even if dealer bust.
                    LoseGame();
                    totalMoney -= playerBet * 2;
                }
                // if player wins 
                else if (dealerTotal > BLACKJACK || playerTotal > dealerTotal)
                {

                    MessageBox.Show("You win!");
                    // add bet amount to total value
                    totalMoney += playerBet * 2;
                }
                // IF player == dealer then they just get to keep their bid
                else if (playerTotal == dealerTotal)
                {
                    MessageBox.Show("You tie!");
                }
                else
                {
                    // Player total less than dealer, and dealer did not bust.
                    LoseGame();
                    // subtract bet amount
                    totalMoney -= playerBet * 2;
                }
                // add total to Money Left textbox
                textBoxMoneyLeft_.Text = totalMoney.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a bet");
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //#############################################################################################
        //# Private Methods
        private void LoseGame()
        {
            MessageBox.Show("You lose!");
        }

    }
}
