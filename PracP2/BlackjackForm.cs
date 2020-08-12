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

        private Card dealerCard1;
        private Card dealerCard2;

        // declare variables
        int betValue = 0;


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
        }


        //#############################################################################################
        //# Event Handlers
        private void buttonDealFirstCard_Click(object sender, EventArgs e)
        {
            // Generate 4 new random cards
            playerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            playerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            dealerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            dealerCard2 = new Card(randomGenerator.Next(NUM_CARDS));

            // Display the first card to player and dealer
            textBoxPlayerCard1_.Text = playerCard1.ToString();
            textBoxDealerCard1_.Text = dealerCard1.ToString();

            // Clear the second card and totals
            textBoxPlayerCard2_.Text = "";
            textBoxPlayerTotal_.Text = "";
            textBoxDealerCard2_.Text = "";
            textBoxDealerTotal_.Text = "";

            // player starts game with $100
            textBoxMoneyLeft_.Text = START_MONEY.ToString();           
        }

        private void buttonDealSecondCard_Click(object sender, EventArgs e)
        {
            //display second two cards and total
            textBoxPlayerCard2_.Text = playerCard2.ToString();
            textBoxDealerCard2_.Text = dealerCard2.ToString();

            int playerTotal = playerCard1.Points + playerCard2.Points;
            int dealerTotal = dealerCard1.Points + dealerCard2.Points;

            textBoxPlayerTotal_.Text = playerTotal.ToString();
            textBoxDealerTotal_.Text = dealerTotal.ToString();

            // player enters an amount to bet
            MakeBet player = new MakeBet(betValue, START_MONEY);
            

            if (playerTotal > BLACKJACK)
            { 
                // Player bust: loses even if dealer bust.
                LoseGame();
            }
            else if (dealerTotal > BLACKJACK || playerTotal > dealerTotal)
            {
                MessageBox.Show("You win!");
                // add bet amount to total pool  
                player.BetAmount();
            }
            else if (playerTotal == dealerTotal)
            {               
                MessageBox.Show("You tie!");
            }
            else
            { 
                // Player total less than dealer, and dealer did not bust.
                LoseGame();
                // subtract bet amount
                betValue = int.Parse(textBoxBet_.Text) - int.Parse(textBoxBet_.Text);
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
