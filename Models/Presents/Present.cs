using System;
using System.Collections.Generic;
using System.Text;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Utilities.Messages;

namespace SantaWorkshop.Models.Presents
{
    public class Present : IPresent
    {
        private string name;
        private int energyRequired;


        public Present(string name, int energyRequired)
        {
            this.Name = name;
            this.EnergyRequired = energyRequired;
        }



        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPresentName);
                }

                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get => this.energyRequired;
            private set
            {
                if (energyRequired < 0)
                {
                    energyRequired = 0;
                }
                else
                {
                    this.energyRequired = value;
                }
            }
        }
        public void GetCrafted()
        {
            if (this.EnergyRequired > 10)
            {
                this.EnergyRequired -= 10;
            }
            else
            {
                this.EnergyRequired = 0;
            }
        }

        public bool IsDone() => this.EnergyRequired == 0;
       
    }
}
