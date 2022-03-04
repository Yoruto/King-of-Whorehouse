using PureMVC.Interfaces;
using PureMVC.Patterns.Observer;

public class SimpleCommand : Notifier,ICommand,INotifier
{
    public virtual void Execute(INotification notification)
    {
        
    }
}
