using System;
using System.Collections.Generic;
using System.Text;
using CheapWow.Helpers;

namespace CheapWow
{
    public class FightingPit
    {
        private readonly IConsole _console;

        public FightingPit(IConsole console)
        {
            this._console = console;
        }

        public FightingPit():this(new ConsoleWrapper())
        {
            
        }


        public void Fight(IFighter fighter1, IFighter fighter2)
        {
            if(!this.ValidateFighters(fighter1,fighter2))
                return;

        }



        private bool ValidateFighters(IFighter fighter1, IFighter fighter2)
        {

            if (fighter1 == null)
            {
                this._console.WriteLine("fighter 1 is missing!");
                return false;
            }

            if (fighter2 == null)
            {
                this._console.WriteLine("fighter 2 is missing!");
                return false;
            }

            return true;
        }
    }
}
