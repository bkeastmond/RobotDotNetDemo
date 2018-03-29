using WPILib.Commands;
using WPILib.Extras.AttributedCommandModel;

namespace Robot.Subsystems
{
    [ExportSubsystem(DefaultCommandType = typeof(Commands.DrivesWithJoystick))]
    public class DriveTrain : Subsystem
    {
        protected override void InitDefaultCommand()
        {
            //Don't need anything here
        }

        public DriveTrain()
        {
            
        }
    }
}
