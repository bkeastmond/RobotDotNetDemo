using WPILib.Commands;

namespace Robot.Commands
{
    public class DrivesWithJoystick : Command
    {
        public DrivesWithJoystick(Subsystem subsystem)
        {
            Requires(subsystem);
        }

        protected override bool IsFinished()
        {
            return false; //We're never really done driving with Joystick
        }
    }
}
