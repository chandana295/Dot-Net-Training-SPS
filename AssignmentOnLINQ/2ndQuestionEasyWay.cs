using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentOnLINQ
{
    class A
    {
        public string PlayerNAme { get; set; }
        public string Playercountry { get; set; }

    }
    class B
    {
        public string PlayerNAme { get; set; }
        public string Playercountry { get; set; }
    }

    internal class _2ndQuestionEasyWay
    {
        static void Main()
        {
            List<A> l1 = new List<A>()
            {
                new A() { PlayerNAme = "player1", Playercountry = "USA" },
                 new A(){PlayerNAme="playe2",Playercountry="India" },
                  new A(){PlayerNAme="player3",Playercountry="UK" },
            };
            List<B> l2 = new List<B>()
            {
                new B(){PlayerNAme = "player4", Playercountry = "USA" },
                new B() { PlayerNAme="5",Playercountry="India" },
                new B() { PlayerNAme="Player 6",Playercountry="UK" },
            };

            var b = from p in l1 from p2 in l2 where p.Playercountry != p2.Playercountry select new { Player1 = p.PlayerNAme, Player2 = p2.PlayerNAme };
            foreach (var matchup in b)
            {
                Console.WriteLine($"Match: {matchup.Player1} vs {matchup.Player2}");
            }
        }
    }
}
  
