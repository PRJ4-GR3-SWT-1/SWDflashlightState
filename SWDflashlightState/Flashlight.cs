using System;

namespace SWDflashlightState
{
    public class Flashlight
    {
        private bool IsOn=false;
        private int Mode = 0;

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
        public void ModePress()
        {
            switch (Mode)
            {
                case 1:
                    Mode =0;
                    //Swith on IsOn
                    break;
                
                default:
                    Mode = 1;
                    //Swith on IsOn
                    break;
            }
        }

        private void TurnOn()
        {
            switch (Mode)
            {
                case 1:
                    //something
                    break;
                default:
                    //somehting else
                    break;
            }
        }

        private void TurnOff()
        {
            Console.WriteLine("Aww off");
        }
    }
}