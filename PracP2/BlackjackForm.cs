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
        private Card playerCard3;

        List<Card> playerCardList = new List<Card>();
        List<Card> dealerCardList = new List<Card>();

        private Card dealerCard1;
        private Card dealerCard2;

        // declare variables
        int playerBet = 0;
        int totalMoney = 100;
        int playerTotal = 0;
        int dealerTotal = 0;

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
            // Generate 1st random card for player
            playerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            // add generated 1st random card to List<Card> playerCardList
            playerCardList.Add(playerCard1);

            // Generate 1st random card for dealer
            dealerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            // add generated 1st random card to List<Card> dealerCardList
            dealerCardList.Add(dealerCard1);

            // Display the first card to player and dealer
            listBoxPlayerCards.Items.Add(playerCardList[0].ToString());
            //textBoxDealerCard1_.Text = dealerCard1.ToString();
            listBoxDealerCards.Items.Add(dealerCardList[0].ToString());

            // Clear the second card and totals
            //textBoxPlayerCard2_.Text = "";
            textBoxPlayerTotal_.Text = "";
            //textBoxDealerCard2_.Text = "";
            textBoxDealerTotal_.Text = "";
        }

        private void buttonDealSecondCard_Click(object sender, EventArgs e)
        {
            // generate random card no2
            playerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            // add card no2 to the playerCardList
            playerCardList.Add(playerCard2);
            // dealer card no2
            dealerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            // add card no2 to the dealerCardList
            dealerCardList.Add(dealerCard2);

            if (playerBet == null)
            {
                MessageBox.Show("Please place a bet");
            }
            else if (playerBet == textBoxBet_.SelectionLength)
            {
                // get bet amount from the textBoxBet_ 
                playerBet = int.Parse(textBoxBet_.Text);

                // get the total points for player and dealer
                int playerTotal = playerCard1.Points + playerCard2.Points;
                int dealerTotal = dealerCard1.Points + dealerCard2.Points;

                // player and dealer totals
                textBoxPlayerTotal_.Text = playerTotal.ToString();
                textBoxDealerTotal_.Text = dealerTotal.ToString();
            }
            // display in allocated listBoxes
            listBoxPlayerCards.Items.Add(playerCardList[1].ToString());
            listBoxDealerCards.Items.Add(dealerCardList[1].ToString());
        }


        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoseGame()
        {
            MessageBox.Show("You lose!");
        }

        private void buttonThirdCard_Click(object sender, EventArgs e)
        {
            // get the total points for player and dealer
            int playerTotal = playerCard1.Points + playerCard2.Points;
            int dealerTotal = dealerCard1.Points + dealerCard2.Points;

            // generate 3rd card 
            playerCard3 = new Card(randomGenerator.Next(NUM_CARDS));
            // add card no3 to the playerCardList
            playerCardList.Add(playerCard3);
            // display
            listBoxPlayerCards.Items.Add(playerCardList[2].ToString());

            // check win
            //if (playerTotal > BLACKJACK)
            //{
            //    // Player bust: loses even if dealer bust.
            //    LoseGame();
            //    totalMoney -= playerBet * 2;
            //}
            //// if player wins 
            //else if (dealerTotal > BLACKJACK || playerTotal > dealerTotal)
            //{

            //    MessageBox.Show("You win!");
            //    // add bet amount to total value
            //    totalMoney += playerBet * 2;
            //}
            //// IF player == dealer then they just get to keep their bid
            //else if (playerTotal == dealerTotal)
            //{
            //    MessageBox.Show("You tie!");
            //}
            //else
            //{
            //    // Player total less than dealer, and dealer did not bust.
            //    LoseGame();
            //    // subtract bet amount
            //    totalMoney -= playerBet * 2;
            //}
            //// add total to Money Left textbox
            //textBoxMoneyLeft_.Text = totalMoney.ToString();

        }

        private void buttonCalculateWin_Click(object sender, EventArgs e)
        {

            // player and dealer totals
            //textBoxPlayerTotal_.Text = playerTotal.ToString();
            //textBoxDealerTotal_.Text = dealerTotal.ToString();

            // check if user only takes 2 cards
            if (playerCard3 == null)
            {
                // get the total points for player and dealer
                int playerTotal = playerCard1.Points + playerCard2.Points;
                int dealerTotal = dealerCard1.Points + dealerCard2.Points;

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
            else
            {
                // get the total points for player and dealer
                int playerTotal = playerCard1.Points + playerCard2.Points + playerCard3.Points;
                int dealerTotal = dealerCard1.Points + dealerCard2.Points;
            }

            //    if (playerTotal > BLACKJACK)
            //    {
            //        // Player bust: loses even if dealer bust.
            //        LoseGame();
            //        totalMoney -= playerBet * 2;
            //    }
            //    // if player wins 
            //    else if (dealerTotal > BLACKJACK || playerTotal > dealerTotal)
            //    {

            //        MessageBox.Show("You win!");
            //        // add bet amount to total value
            //        totalMoney += playerBet * 2;
            //    }
            //    // IF player == dealer then they just get to keep their bid
            //    else if (playerTotal == dealerTotal)
            //    {
            //        MessageBox.Show("You tie!");
            //    }
            //    else
            //    {
            //        // Player total less than dealer, and dealer did not bust.
            //        LoseGame();
            //        // subtract bet amount
            //        totalMoney -= playerBet * 2;
            //    }
            //    // add total to Money Left textbox
            //    textBoxMoneyLeft_.Text = totalMoney.ToString();
            //}
        }
    }
}
