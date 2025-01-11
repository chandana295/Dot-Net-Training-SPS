using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnLINQ
{
    class Players
    {
        public string PlayerName { get; set; }
        public string PlayerCountry { get; set; }
    }
    
    internal class _2ndQuestion
    {
        static void Main()
        {
            List<Players> list=new List<Players>()
            {
                new Players() { PlayerName = "Player1", PlayerCountry = "USA" },
                new Players() { PlayerName = "Player2", PlayerCountry = "USA" },
                new Players() { PlayerName = "Player3", PlayerCountry = "Canada" },
                new Players() { PlayerName = "Player4", PlayerCountry = "Canada" },
                new Players() { PlayerName = "Player5", PlayerCountry = "India" },
                new Players() { PlayerName = "Player6", PlayerCountry = "India" },
                new Players() { PlayerName = "Player7", PlayerCountry = "Australia" },
                new Players() { PlayerName = "Player8", PlayerCountry = "Australia" },
                new Players() { PlayerName = "Player9", PlayerCountry = "Germany" },
                new Players() { PlayerName = "Player10", PlayerCountry = "Germany" },
                new Players() { PlayerName = "Player11", PlayerCountry = "France" },
                new Players() { PlayerName = "Player12", PlayerCountry = "France" },
                new Players() { PlayerName = "Player13", PlayerCountry = "USA" },
                new Players() { PlayerName = "Player14", PlayerCountry = "Canada" },
                new Players() { PlayerName = "Player15", PlayerCountry = "India" },
                new Players() { PlayerName = "Player16", PlayerCountry = "Australia" },
                new Players() { PlayerName = "Player17", PlayerCountry = "Germany" },
                new Players() { PlayerName = "Player18", PlayerCountry = "France" },
                new Players() { PlayerName = "Player19", PlayerCountry = "Brazil" },
                new Players() { PlayerName = "Player20", PlayerCountry = "Brazil" },
                new Players() { PlayerName = "Player21", PlayerCountry = "USA" },
                new Players() { PlayerName = "Player22", PlayerCountry = "India" },
                new Players() { PlayerName = "Player23", PlayerCountry = "Australia" },
                new Players() { PlayerName = "Player24", PlayerCountry = "Germany" },
            };

            var r1=from p in list group p by p.PlayerCountry;
            foreach (var k in r1)
            {
                Console.WriteLine($"no.of players in {k.Key} ={k.Count()}");
            }
           //layers TeamA=from p in list where p.PlayerCountry ==("USA","India","France")
        }
    }
}
