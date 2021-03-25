using System;

namespace SWDflashlightState
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Flashlight flash = new Flashlight();
            //flash.ButtonPress();
            //flash.ButtonPress();
            //flash.ButtonPress();

            Console.WriteLine("Hello World!");
            FlashlightGof flash2 = new FlashlightGof();
            flash2.Power();
            flash2.Power();
            flash2.Power();
        }
    }

    public class FlashlightGof
    {
        public FlashlightGof()
        {
            _state = new Off();
        }
        private SWDflashlightState _state;
        public void SetState(SWDflashlightState state)
        {
            _state = state;
        }

        public void Power()
        {
            _state.HandlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Whuhuhuuu On");
        }

        public void LightOff()
        {
            Console.WriteLine("Øøøøvvøøvøv Off");
        }
    }
}
