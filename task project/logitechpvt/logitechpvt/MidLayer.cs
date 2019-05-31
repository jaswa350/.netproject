using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logitechpvt
{
    class MidLayer:MainBoard
    {
       public  int Scrollwheel34N, ScrollWheel14N, LEDlight, Wire;

        public override void Quantity()
        {
            Console.WriteLine("enter the quantity for base cover and wheel assembly");
            baseCover =Convert.ToInt32( Console.ReadLine());
            wheelAssembly= Convert.ToInt32(Console.ReadLine());
           
        }
        public void MiddleLayer()
        {
            int scrollwheel34N, scrollWheel14N, ledlight, wire;
            Console.WriteLine("enter the quantity for  Scrollwheel34N,  Scrollwheel14N, LEDlight, wire");
            scrollwheel34N = Convert.ToInt32(Console.ReadLine());
            scrollWheel14N = Convert.ToInt32(Console.ReadLine());
            ledlight = Convert.ToInt32(Console.ReadLine());
            wire = Convert.ToInt32(Console.ReadLine());
            MidLayerItems(scrollwheel34N, scrollWheel14N, ledlight);
            MidLayerItems(wire);
        }
    public void MidLayerItems(int Scrollwheel34N, int  Scrollwheel14N, int LEDlight)
        {
            this.Scrollwheel34N = Scrollwheel34N;
            this.ScrollWheel14N = Scrollwheel14N;
            this.LEDlight = LEDlight;
            
        }
        public void MidLayerItems(int wire)
        {
            this.Wire = wire;
            
        }
    }
}
