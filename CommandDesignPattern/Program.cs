using CommandDesignPattern;

class program
{
    static void Main()
    {
        Light light = new Light();
        ICommand lightOn = new LightOnCommand(light);
        RemoteControl remoteControl = new RemoteControl(lightOn);
        remoteControl.PressButton();
    }
}