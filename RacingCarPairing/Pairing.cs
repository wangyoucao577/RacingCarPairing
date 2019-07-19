using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RacingCarPairing
{
    class TeamCarPair
    {
        public TeamCarPair(string team, string car)
        {
            Team = team;
            Car = car;
        }


        public string Team { get; set; }
        

        public string Car { get; set; }
    }


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

        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }


        public bool RandomPair()
        {
            if (!IsPairable())
            {
                return false;
            }

            //only shuffle one list will get better performance
            //teams = ShuffleList(teams);   
            cars = ShuffleList(cars);

            pairs = new List<TeamCarPair>();
            for (int i = 0; i < teams.Count; i++)
            {
                pairs.Add(new TeamCarPair(teams[i], cars[i]));
            }
            Debug.Assert(pairs.Count == teams.Count);
            Debug.Assert(pairs.Count <= cars.Count);
            pairs.Sort(
                delegate (TeamCarPair p1, TeamCarPair p2)
                {
                    return p1.Team.CompareTo(p2.Team);
                }
            );

            return true;
        }

        public string ErrorMessage
        {
            get
            {
                return errMsg;
            }
        }

        public List<TeamCarPair> Pairs
        {
            get
            {
                return pairs;
            }
        }

        private List<string> teams;
        private List<string> cars;
        private string errMsg = "";

        private List<TeamCarPair> pairs = null;
    }
}
