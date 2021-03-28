using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbit_race_assign
{
    public  class Player1
    {
        
        //here i am going to set the constuctor 
        public String Name = "";
        public int rabit = 0;
        public int Bet = 0;
        public int Budget= 0;

        //here is the constructor of the working 
        public Player1(String name, int rabt,int bet,int budget) {
            this.Name = name;
            rabit = rabt;
            Bet = bet;
            Budget = budget;
        }

        //this code is used to set the budget after partcipating into the bet 
        public int resetBudget(int Winner) {
            if (rabit == Winner)
            {
                return Budget + Bet;
            }
            else {
                return Budget - Bet;
            }
        }


    }
}
