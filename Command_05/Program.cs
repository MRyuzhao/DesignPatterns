using System;
using Command_05.Commands;
using Command_05.Devices;

namespace Command_05
{
    /// <summary>
    /// 有这样一个可编程的新型遥控器, 它有7个可编程插槽, 每个插槽可连接不同的家用电器设备.
    /// 每个插槽对应两个按钮: 开, 关(ON, OFF). 此外还有一个全局的取消按钮(UNDO).
    /// 现在客户想使用这个遥控器来控制不同厂家的家用电器, 例如电灯, 热水器, 风扇, 音响等等.
    /// 客户提出让我编写一个接口, 可以让这个遥控器控制插在插槽上的一个或一组设备.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region SimpleRemoteControl
            //var remote = new SimpleRemoteControl();

            //var lightOn = new LightOnCommand(new Light());

            //remote.Slot = lightOn;
            //remote.ButtonWasPressed();

            //Console.WriteLine("-----------------------------------------------------------");

            //var doorOpen = new DoorOpenCommand(new Door());

            //remote.Slot = doorOpen;
            //remote.ButtonWasPressed();
            #endregion

            #region RemoteControl
            var remote = new RemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var door = new Door();
            var doorOpen = new DoorOpenCommand(door);
            var doorClose = new DoorCloseCommand(door);
            var stereo = new Stereo();
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, doorOpen, doorClose);
            remote.SetCommand(2, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            remote.OnButtonWasPressed(2);
            remote.OffButtonWasPressed(2);
            remote.UndoButtonWasPressed();
            #endregion

            Console.ReadKey();
        }
    }
}
