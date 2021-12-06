using System;
namespace Codigo.ShowLastNotifications;

public abstract class ISujeto
{
	public List<IObserver> observers = new List<IObserver> { };

	public abstract void AddObserver(IObserver a_observer);
	public abstract void RemoveObserver(IObserver a_observer);
	public abstract void NotifyObservers();
}

public interface IObserver
{
	public void Update(string a_last_title, string a_last_url, string a_last_description, string a_last_image);
}

public interface IDisplay 
{
	public void DisplayInfo();
}


