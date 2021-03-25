namespace SWDflashlightState
{
    public abstract class SWDflashlightState
    {
        public virtual void OnEnter(FlashlightGof context) { }
        public virtual void  HandlePower(FlashlightGof context)
        { }
        public virtual void HandleMode(FlashlightGof context)
        { }
    }

    public class On : SWDflashlightState
    {
        public override void OnEnter(FlashlightGof context)
        {
            context.StartSolid();
            context.SetState(new Solid());
        }
        public override void HandlePower(FlashlightGof context)
        {
            //Denne kode burde aldrig køre
            context.LightOff();
            context.SetState(new Off());
        }
    }
    public class Off : SWDflashlightState
    {
        public override void HandlePower(FlashlightGof context)
        {
            
            context.SetState(new On());
        }
    }
    public class Flashing : On
    {
        public override void OnEnter(FlashlightGof context)
        {
            //Nothing
        }

        public override void HandleMode(FlashlightGof context)
        {
            context.StartSolid();
            context.SetState(new Solid());
        }
    }
    public class Solid : On
    {
        public override void OnEnter(FlashlightGof context)
        {
           //Nothing
        }
        public override void HandleMode(FlashlightGof context)
        {
            context.StartFlash();
            context.SetState(new Flashing());
        }
    }
}