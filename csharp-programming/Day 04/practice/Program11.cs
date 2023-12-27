using System;

class Publisher
{
    public event EventHandler Clicked;

    public void PerformClick()
    {
        Console.WriteLine("Button clicked");
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

class Subscriber
{
    public void HandleClick(object sender, EventArgs e)
    {
        Console.WriteLine("Button click handled");
    }
}

class Program
{
    static void Main()
    {
        Publisher button = new Publisher();
        Subscriber handler = new Subscriber();

        button.Clicked += handler.HandleClick;

        button.PerformClick();

        button.Clicked -= handler.HandleClick;
    }
}
