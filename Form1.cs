using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_1
{
    public partial class Form1 : Form
    {
        public sbyte movementProcess;
        public Form1()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            progressBarMovementProcess.Minimum = 0;
            progressBarMovementProcess.Maximum = 100;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] type = { "Пассажирское судно", "Танкер", "Рыболовное судно", "Контейнеровоз", "Сухогруз", "Газовоз" };
            comboBoxType.Items.AddRange(type);
            progressBarMovementProcess.Value = 0;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] typeOfCargo = { "Пассажиры", "Товары", "Нефть", "Рыба", "Газ", "Зерно", "Удобрения" };
            comboBoxTypeOfCargo.Items.AddRange(typeOfCargo);
            comboBoxTypeOfCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void buttonCreateWaterVehicle_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string type = comboBoxType.SelectedItem.ToString();
            double speed = double.Parse(textBoxSpeed.Text);
            double length = double.Parse( textBoxLength.Text);
            string typeOfCargo = comboBoxTypeOfCargo.SelectedItem.ToString();
            int tonnage = Int32.Parse(textBoxTonnage.Text);
            
            WaterVehicle waterVehicle = new WaterVehicle(title, type, speed, length,typeOfCargo, tonnage);
            movementProcess = waterVehicle.MovementProcess;
            progressBarMovementProcess.Value = movementProcess;
        }


    }
}
