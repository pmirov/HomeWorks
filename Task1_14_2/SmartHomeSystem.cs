using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_14_2
{
    public enum DeviceType
    {
        Light,
        Thermostat,
        Door
    }
    public delegate void DeviceOperationHandler(string message, DeviceType deviceType);
    internal class SmartHomeSystem
    {
        public event DeviceOperationHandler DeviceStateChanged;

        private bool _onOffLight;
        private bool _lock;
        private double _temp;

        public SmartHomeSystem()
        {

        }

        public void TurnOffLight()
        {

            _onOffLight = false;
            DeviceStateChanged?.Invoke("Свет выключен", DeviceType.Light);
        }
        public void TurnOnLight()
        {

            _onOffLight = true;
            DeviceStateChanged?.Invoke("Свет включен", DeviceType.Light);

        }
        public void SetTemperature(int newTemp)
        {
            //нужна проверка на диапазон температуры

            if (newTemp <= 0 || newTemp > 50)
                throw new ArgumentException("Температура должна быть в диапазоне от 0 до 50°C");
            _temp = newTemp;
            DeviceStateChanged?.Invoke($"Установлена температура: {newTemp}°C", DeviceType.Thermostat);

        }
        public void LockDoor()
        {
            _lock = true;
            DeviceStateChanged?.Invoke("Дверь закрыта", DeviceType.Door);

        }
        public void UnlockDoor()
        {
            _lock = false;
            DeviceStateChanged?.Invoke("Дверь открыта", DeviceType.Door);

        }
    }
}
