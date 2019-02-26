using System;
using System.Collections.Generic;
using System.Text;
using CheapWow.Helpers;

namespace CheapWow
{
    public interface IFighter
    {
        string Name { get; }
        int Health { get; }
        int DamagePerAttack { get; }
    }

    public class Fighter : IFighter
    {
        #region Members & Constants

        private readonly IRandomGenerator _randomGenerator;
        
        #endregion

        #region Properties
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int DamagePerAttack { get; protected set; }

        #endregion

        #region Constructors
        public Fighter(string name,IRandomGenerator randomGenerator)
        {
            this._randomGenerator = randomGenerator;
            this.Name = name;
            this.Health = this._randomGenerator.GetRandomNumber(400, 800);
            this.DamagePerAttack = this._randomGenerator.GetRandomNumber(10, 20);

        }

        public Fighter(string name) : this(name,new RandomGenerator())
        {}

        #endregion



    }
}
