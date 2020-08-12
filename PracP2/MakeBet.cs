using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracP2
{
    class MakeBet
    {
        private int _value;
        private int _betAmount;
        private int _doubleBet;
        
        /// <summary>
        /// Constructor method
        /// </summary>
        public MakeBet()
        {
            _value = 0;
            _betAmount = 0;
            _doubleBet = 0;
        }

        /// <summary>
        /// Initialises the object to it's initial value
        /// </summary>
        /// <param name="initialValue"></param>
        public MakeBet(int initialValue, int bet_amount, int double_bet)
        {
            _value = initialValue;
            _betAmount = bet_amount;
            _doubleBet = double_bet;
        }

        /// <summary>
        /// Gets the value of the MakeBet
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets the amount the player bets
        /// </summary>
        public void BetAmount(int bet_amount)
        {
            bet_amount = _value;
        }

        /// <summary>
        /// Doubles the bet winnings if player wins
        /// </summary>
        /// <param name="doubleBet"></param>
        public void Winner(int doubleBet)
        {
            doubleBet = _value * 2;
        }

        /// <summary>
        /// Subtracts bet from bid
        /// </summary>
        /// <param name="lostBet"></param>
        public void LostBet(int lostBet)
        {
            _value = lostBet - _betAmount;
        }
    }
}
