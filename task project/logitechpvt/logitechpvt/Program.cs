using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logitechpvt;

namespace logitechpvt
{
    class SpeedoMouse
    {
        static void Main(string[] args)
        {
            FullBody Obj = new FullBody();
            Obj.Quantity();
            Obj.MiddleLayer();
            Console.WriteLine("enter the quantity for SplitCover ,spring and ScrewHalfInch");
            Obj.SplitCoverQ = Convert.ToInt32(Console.ReadLine());
            Obj.springq = Convert.ToInt32(Console.ReadLine());
            Obj.ScrewHalfInch = Convert.ToInt32(Console.ReadLine());
            Obj.print();
           

           Console.ReadKey();
        }
    }
}
