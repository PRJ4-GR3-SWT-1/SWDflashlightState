using System;

namespace SWDflashlightState
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Flashlight
    {
        private bool IsOn=false;

        public void ButtonPress()
        {
            switch (IsOn)
            {
                case true:
                    TurnOff();
                    IsOn = false;
                    break;
                case false:
                    TurnOn();
                    IsOff = true;
                    break;
                default:
                    break;
            }
        }

        private void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}
