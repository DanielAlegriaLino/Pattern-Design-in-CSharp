using System;
namespace Codigo.ShowLastNotifications;

public class Newsletter : ISujeto
{
	private string last_title;
	private string last_url;
	private string last_description;
	private string last_image;

	public string LastTitle { set { last_title= value; } }
	public string LastUrl { set { last_url= value; } }
	public string LastDescription { set { last_description= value; } }
	public string LastImage { set { last_image= value; } }

	public override void AddObserver(IObserver a_observer)
	{
		observers.Add(a_observer);
	}

	public override void NotifyObservers()
	{
		foreach (IObserver observer in observers) 
		{
			observer.Update(last_title,last_url,last_description,last_image);
		}
	}

	public override void RemoveObserver(IObserver a_observer)
	{
		if (observers.Contains(a_observer) ) 
		{
			int observer2delete_position= observers.IndexOf(a_observer);
			observers.RemoveAt(observer2delete_position);
		}
		else 
		{
			throw new ArgumentException("El observador no se encontraba suscrito", "a_observer");
		}


	}
}

