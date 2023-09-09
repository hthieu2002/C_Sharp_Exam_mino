using System;
using System.Collections.Generic;

// Subject (Chủ đề)
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private int state;

    public int State
    {
        get { return state; }
        set
        {
            state = value;
            NotifyObservers();
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update();
        }
    }
}

// Observer
public interface IObserver
{
    void Update();
}

public class ConcreteObserver : IObserver
{
    private string name;
    private Subject subject;

    public ConcreteObserver(string name, Subject subject)
    {
        this.name = name;
        this.subject = subject;
    }

    public void Update()
    {
        Console.WriteLine($"Observer {name} received update. New state: {subject.State}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject();

        ConcreteObserver observer1 = new ConcreteObserver("Observer 1", subject);
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2", subject);

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.State = 5; // Thay đổi trạng thái và thông báo cho các observer.
    }
}
