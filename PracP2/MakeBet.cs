using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP2
{
    class MakeBet
    {       
        //# Instance variables
        private int _playerBetAmount;
        private int _startAmount;

        //# Constructor
        /// <summary>
        /// This constructor method will initialise the fields to default values
        /// </summary>
        public MakeBet()
        {
            int _playerBetAmount = 0;
            int _startAmount = 100;
        }

        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="player_bet"></param>
        /// <param name="start_amount"></param>
        public MakeBet(int player_bet, int start_amount)
        {
            player_bet = _playerBetAmount;
            start_amount = _startAmount;
        }

        /// <summary>
        /// Gets and Sets the starting total amount the player can use 
        /// </summary>
        public int StartAmount
        {
            get { return _startAmount; }
            set { _startAmount = value; }
        }

        /// <summary>
        /// Gets and Sets the amount to bet
        /// </summary>
        public int BetAmount
        {
            get { return _playerBetAmount; }
            set { _playerBetAmount = value; }
        }

        /// <summary>
        /// Gets amount and doubles it
        /// </summary>
        /// <param name="doubleBet"></param>
        /// <returns></returns>
        public int PlayerWin(int doubleBet)
        {
            
        }


        // player starts off with $100
        // player gets to view the 1st card then gets to enter an amount of money to bid
        // 2nd card is revealed for both player and computer and compared
        // IF player hand > 21 (goes bust) or player hand<dealer's sum (player loses their money)
        // IF player sum > dealer's sum or dealer > 21 (goes bust) (player gets paid the amount of their bid as well as keeping their bid)
        // IF player == dealer then they just get to keep their bid

    }
}
