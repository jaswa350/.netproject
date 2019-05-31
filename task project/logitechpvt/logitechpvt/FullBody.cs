using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logitechpvt
{
    sealed class  FullBody:MidLayer
    {
        public FullBody()
        {

        }
        ~FullBody()
        {

        }
        public int ScrewHalfInch;
        private int SplitCover, Spring;
        public int SplitCoverQ
        {
            get { return (SplitCover); }
            set { SplitCover = value; }
        }
        public int springq
        {
            get { return (Spring); }
            set { Spring = value; }
        }
        public void print()
        {
            Console.WriteLine("                            Logitech Pvt. Ltd                                                                     ");
            Console.WriteLine("<------------------------------------------------------------------------------------------------------------------>");
            Console.WriteLine("item--------------------------------------------------------------quantity--------------------------------------->");
            Console.WriteLine("Wire 1 meter(with connector)--------------------------------------"+this.Wire);
            Console.WriteLine("Screw Half inch---------------------------------------------------"+ this.ScrewHalfInch);
            Console.WriteLine("LED light---------------------------------------------------------"+ this.LEDlight);
            Console.WriteLine("Scroll Wheel 34N--------------------------------------------------"+ this.Scrollwheel34N);
            Console.WriteLine("Scroll Wheel 14N--------------------------------------------------"+ this.ScrollWheel14N);
            Console.WriteLine("Springs-----------------------------------------------------------"+ this.Spring);
            Console.WriteLine("Split cover (for top)---------------------------------------------"+ this.SplitCover);
            Console.WriteLine("Base cover (for bottom)-------------------------------------------"+ this.baseCover);
            Console.WriteLine("Wheel Assembly----------------------------------------------------"+ this.wheelAssembly);
        }

    }
}
