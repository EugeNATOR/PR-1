using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1
{
    internal abstract class MeansOfTransportation
    {
        protected string title;
        protected string type;
        protected double speed;    
        protected string typeOfCargo;
        
        public sbyte MovementProcess { protected set; get; } = 0;
        string message;
        public MeansOfTransportation(string title, string type, double speed,  string typeOfCargo)
        {
            this.title = title;
            this.type = type;
            this.speed = speed;
            this.typeOfCargo = typeOfCargo;
            //Incident();
            GetInfo();
        }
        //void Incident()
        //{
        //    Random rnd = new Random();
        //    int chance = rnd.Next(1);
        //    switch (chance)
        //    {
        //        case 0:
        //            message = "Топливо на исходе, траспортное средство вынужденно остановиться в ближайшей точке для дозаправки";
        //            //if (MovementProcess == 0) { MovementProcess = 0; }
        //            //else if (MovementProcess < 10) { MovementProcess -= MovementProcess; }
        //            //else MovementProcess -= 10;
        //            break;
        //        case 1:
        //            message = "Случилась авария, груз разлетелся";
        //            //if (MovementProcess == 0) { MovementProcess = 0; }
        //            //else if (MovementProcess < 50) { MovementProcess -= MovementProcess; }
        //            //else MovementProcess -= 50;
        //            break;
                    
        //    }
        //}
        void GetInfo()
        {
            MessageBox.Show("Транспортное средство в пути", "Новое транспортное средство", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected abstract void Speed();
    }
}
