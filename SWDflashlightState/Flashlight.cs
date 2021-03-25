using System;

namespace SWDflashlightState
{
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
                    IsOn = true;
                    break;
                default:
                    break;
            }
        }

        private void TurnOn()
        {
            Console.WriteLine("Wuhuuu On");
        }

        private void TurnOff()
        {
            Console.WriteLine("Aww off");
        }
    }
}