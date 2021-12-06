using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codigo.ShowLastNotifications;


namespace Codigo.ShowLastNotifications
{
	class Tablet : IObserver, IDisplay
	{
		string owner_name;
		ISujeto subject;

		string last_title;
		string last_url;
		string last_description;
		string last_image;

		public Tablet(ISujeto a_subject, string a_owner_name) 
		{
			owner_name = a_owner_name;
			subject = a_subject;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Hola {owner_name}. Se ha actualiazado la ultima informacion");
			Console.WriteLine("Mostrar pantalla 4k full hd todo color");
			Console.WriteLine($"El ultimo video se llama {last_title}");
			Console.WriteLine($"Puedes ver el ultimo video en el link {last_url}");
			Console.WriteLine($"La thumbnail del ultimo video subido es {last_image}");
			Console.WriteLine($"La descripcion dicta lo siguiente {last_description}");
		}

		public void Update(string a_last_title, string a_last_url, string a_last_description, string a_last_image)
		{
			last_description = a_last_description;
			last_url = a_last_url;
			last_image = a_last_image;
			last_title = a_last_title;
			DisplayInfo();
		}
	}
}
