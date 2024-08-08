using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice
{
    internal class Araba
    {
        // field to identify
        private string _brand;
        private string _modal;
        private string _color;
        private int _doorNumber;

        // doornumber property to identify
        public int DoorNumber
        {
            get
            {
                return _doorNumber;
            }
            set  // If the number of doors is equal to 4 or 2, do  enter successfully. Otherwise, give a warning message and set the number of doors to -1.
            {
                if (value != 4 && value != 2)
                {
                    value = -1;
                    _doorNumber = value;
                    Console.WriteLine($"Kapi sayisi 2 yada 4 disinda bir deger alamaz. Kapi degeri: {_doorNumber}");
                    
                }

                else
                {

                    Console.WriteLine("Kapi Girisi Basarili.");
                }
            }

        }
    }

}

