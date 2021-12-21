public class WindowsUIFactory : UIFactory
{
	public override IButton CreateButton()
	{
		return new WindowsUIButton();
	}

	public override ILabel CreateLabel(string text)
	{
		return new WindowsUILabel(text);
	}
}

public class WindowsUIButton : IButton
{
	void IButton.Display()
	{
		Console.WriteLine("Se muestra en pantalla el boton");
	}

	void IButton.onClick()
	{
		Console.WriteLine("Efecto de hover");
		Console.WriteLine("Hacer sonido de Windows");
	}
}

public class WindowsUILabel : ILabel
{
	public WindowsUILabel(string a_text) : base(a_text)
	{
		Console.WriteLine("Se ha cerado esta etiqeta optimizada para Windows ((:<");
	}

	public override void Display()
	{
		Console.WriteLine($"El texto redacta lo siguiente {_text}");
	}

}