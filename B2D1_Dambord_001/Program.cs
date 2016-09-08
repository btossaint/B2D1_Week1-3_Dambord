using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2D1_Dambord_001.Model;

namespace B2D1_Dambord_001
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dambord Dbord = new Dambord();
            Dbord.toonBord();
            Dbord.setSteen(33,1);
            Dbord.toonBord();
            Dbord.setSteen(44, 1);
            Dbord.setSteen(42, 1);
            Dbord.toonBord();
            Dbord.toonRechts();
            Dbord.toonLinks();
        }
    }
}
