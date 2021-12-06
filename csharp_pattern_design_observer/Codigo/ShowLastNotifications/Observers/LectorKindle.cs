using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Codigo.ShowLastNotifications;

class LectorKindle : IObserver, IDisplay
{
	//Datos de configuracion del sistema
	private Newsletter Sujeto;
	private string name;

	
	private string last_title;
	private string last_url;
	private string last_description;

	public LectorKindle(Newsletter a_Sujeto, string a_nombre_dueño)
	{
		Sujeto = a_Sujeto;
		name = a_nombre_dueño;
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"Hola {name}, se subio un nuevo video");
		Console.WriteLine($" este se titula: {last_title}, puedes ver el video desde tu reproductor multimedia favorito en  {last_url}");
		Console.WriteLine($"La descripcion del ultimo video es {last_description}");
	}


	public void Update(string a_last_title, string a_last_url, string a_last_description, string a_last_image)
	{
		last_description = a_last_description;
		last_title = a_last_title;
		last_url = a_last_url;
		DisplayInfo();
	}


}

