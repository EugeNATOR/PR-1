using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1
{
    internal class WaterVehicle : MeansOfTransportation
    {
        protected double length;
        string message;
        protected int tonnage;
        void IncidentWaterVehicle()
        {
            Random rnd = new Random();
            int chance = rnd.Next(4);
            switch (chance)
            {
                case 0:
                    message = "Впереди очень плохая погода, судно замедлилось";
                    if (MovementProcess == 0) { MovementProcess = 0; }
                    else if (MovementProcess < 10) { MovementProcess -= MovementProcess; }
                    else MovementProcess -= 10; break;
                case 1: message = "Случилась поломка! Судно вынужденно вернуться в пункт отправления"; MovementProcess -= MovementProcess; break;
                case 2: message = "По пути не ожидается плохой погоды, судно спокойно может продолжать движение"; MovementProcess += 20; break;
                case 3:
                    message = "Судно движется с обычной скоростью, как и планировалось"; MovementProcess += 10; break;

            }   
        }
        public WaterVehicle(string title, string type, double speed, double length, string typeOfCargo, int tonnage) : base(title, type, speed, typeOfCargo)
        {
            this.length = length;
            this.tonnage = tonnage;
            IncidentWaterVehicle();
            GetInfo();
            Speed();

        }
        protected override void Speed()
        {

            double speedKilometerPerHour = speed * 1.85;
        }
        void GetInfo()
        {
            MessageBox.Show("Судно создано!\nСобытие: " + message + "\nПроцесс доставки груза: " + MovementProcess+"\nСкорость судна: ", "Новое событие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
