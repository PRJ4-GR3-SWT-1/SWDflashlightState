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
            flash2.Mode();
            flash2.Mode();
            flash2.Power();
            flash2.Mode();
            flash2.Mode();
            
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
            _state.OnEnter(this);
        }

        public void Power()
        {
            _state.HandlePower(this);
        }
        public void Mode()
        {
            _state.HandleMode(this);
        }


        public void LightOff()
        {
            Console.WriteLine("Øøøøvvøøvøv Off");
        }
        public void StartFlash()
        {
            Console.WriteLine("Now flashing");
        }

        public void StartSolid()
        {
            Console.WriteLine("Super solid light");
        }
    }
}
