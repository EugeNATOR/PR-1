using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_1
{
    internal class MeansOfTransportation
    {
        protected string title;
        protected string type;
        protected double speed;
        protected double length;
        protected string typeOfCargo;
        protected int tonnage;
        public sbyte movementProcess { protected set; get; } = 0;
        string massage;
        public MeansOfTransportation(string title, string type, double speed, double length, string typeOfCargo, int tonnage)
        {
            this.title = title;
            this.type = type;
            this.speed = speed;
            this.length = length;
            this.typeOfCargo = typeOfCargo;
            this.tonnage = tonnage;
        }
        protected void Incident()
        {
            Random rnd = new Random();
            int chance = rnd.Next();
            switch (chance)
            {
                case 0: massage = "Впереди очень плохая погода, транспортное средство замедлилось";
                    if (movementProcess == 0) { movementProcess = 0; }
                    else if (movementProcess < 10) { movementProcess -= movementProcess; }
                    else movementProcess-=10; break;
                case 1: massage = "Топливо на исходе, траспортное средство вынужденно остановиться в ближайшей точке для дозаправки";
                    if (movementProcess == 0) { movementProcess = 0; }
                    else if (movementProcess < 10) { movementProcess -= movementProcess; }
                    else movementProcess -= 10; break;
                case 2: massage = "Случилась авария, груз разлетелся";
                    if (movementProcess == 0) { movementProcess = 0; }
                    else if (movementProcess < 50) { movementProcess -= movementProcess; }
                    else movementProcess -= 50; break;
                case 3: massage = "Случилась поломка!Транспортное средство вынужденно вернуться в пункт отправления";movementProcess -= movementProcess;break; 
                case 4: massage = "По пути не ожидается плохой погоды, транспортное средство спокойно может продолжать движение";movementProcess += 20;break;
                case 5: massage = ""

            }
        }
    }
}
