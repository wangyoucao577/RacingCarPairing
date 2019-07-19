using System;
using System.Collections.Generic;
using System.Text;

namespace RacingCarPairing
{
    class Pairing
    {
        public Pairing(List<string> teams, List<string> cars)
        {
            this.teams = teams;
            this.cars = cars;
        }

        private bool IsPairable()
        {
            if (teams.Count == 0 || cars.Count == 0)
            {
                errMsg = "No valid team or car.";
                return false;
            }

            if (teams.Count > cars.Count)
            {
                errMsg = teams.Count.ToString() + " cars are not enough for "
                    + cars.Count.ToString() + " teams.\nPlease fill in more cars!";
                return false;
            }
            return true;
        }

        public bool RandomPair()
        {
            if (!IsPairable())
            {
                return false;
            }

            //TODO: pairing

            return true;
        }

        public string ErrorMessage
        {
            get
            {
                return errMsg;
            }
        }

        private List<string> teams;
        private List<string> cars;
        private string errMsg = "";
    }
}
