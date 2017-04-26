using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp2
{
    public class Names
    {
        public string Name { get; set; }
        public string FavouriteTeam { get; set; }

        public Names()
        {

        }
        public static List<Names> GetNames()
        {
            var nameList = new List<Names>();

            nameList.Add(new Names()
                {
                Name = "Cherry",
                FavouriteTeam = "Barca"
                }
            );
            nameList.Add(new Names(){ Name = "Mark", FavouriteTeam = "Arsenal" });
            nameList.Add(new Names(){ Name = "Mes", FavouriteTeam = "Germany" });
			nameList.Add(new Names() { Name = "Dave", FavouriteTeam = "Arsenal" });

            return nameList;
        }
    }
}
