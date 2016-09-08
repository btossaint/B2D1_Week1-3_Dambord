using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2D1_Dambord_001.Model
{
    public class Dambord
    {
        private int steen;
        private List<int> dambordBord;

        public int Steen
        {
            get { return steen; }
            set { steen = value; }
        }

        public List<int> DambordBord
        {
            get { return dambordBord; }
            set { dambordBord = value; }
        }

        public Dambord ()
        {
            creeer_dambord();
            
        }

        private void creeer_dambord()
        {
            dambordBord = new List<int>() ;
            for (int i = 0; i < 100; i++)
            {
                dambordBord.Add(0);
            }
            steen = 1;
            setSteen(steen, 1);
        }

        public void setSteen(int plaats, int waarde)
        {
            steen = plaats;
            dambordBord[steen-1] = waarde;            // -1 omdat er een offset is van 0!
        }

        public void toonRechts()
        {
            bool Klaar = false;
            int i = steen;             
            while (!Klaar)
            {
                if (i%10 != 0)
                {
                    Console.Write(dambordBord[i]);
                }
                else
                {
                    Klaar = true;
                }
                i = i + 1;
            }
            Console.ReadLine();
        }

        public void toonLinks()
        {            
            int i = (steen / 10) * 10 ; // steen afronden op heel getal bijv, 42 / 10 = 4 * 10 = 40

            while (i < steen-1) // -1 steen zelf niet meenemen
            {
                Console.Write(dambordBord[i]);
                i = i + 1;
            }
            Console.ReadLine();
        }

        public void toonBord()
        {
            for (int i = 0; i < 100; i++)
            {
                if ((i+1)%10 == 0)
                {
                    Console.WriteLine(dambordBord[i]);
                }
                else
                {
                    Console.Write(dambordBord[i]);
                }
                
            }
            Console.ReadLine();
        }

    }
}
