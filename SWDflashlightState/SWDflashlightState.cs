namespace SWDflashlightState
{
    public abstract class SWDflashlightState
    {
        public virtual void  HandlePower(FlashlightGof context)
        { }
    }

    public class On : SWDflashlightState
    {
        public override void HandlePower(FlashlightGof context)
        {
            context.LightOff();
            context.SetState(new Off());
        }
    }
    public class Off : SWDflashlightState
    {
        public override void HandlePower(FlashlightGof context)
        {
            context.LightOn();
            context.SetState(new On());
        }
    }
}