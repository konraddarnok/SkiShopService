using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopService.Models
{
    public class Ski
    {

        List<Ski> ListOfSki = new List<Ski>();
        


        public Ski (int id, int skiLength, string skiType, int price)
        {
            Id = id;
            SkiLength = skiLength;
            SkiType = skiType;
            Price = price;
        }
        public int Id { get; set; }
        public int SkiLength { get; set; }
        public string SkiType { get; set; }
        public int Price { get; set; }
 

        public Ski()
        {

        }
        
    }
}
