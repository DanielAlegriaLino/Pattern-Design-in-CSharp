public class MacOsUIFactory : UIFactory
{
	public override IButton CreateButton()
	{
		return new MacOsButton();
	}

	public override ILabel CreateLabel(string a_text)
	{
		return new MacOsLabel(a_text);
	}


}


public class MacOsButton : IButton
{
	public void Display()
	{
		throw new NotImplementedException();
	}

	public void onClick()
	{
		throw new NotImplementedException();
	}
}

public class MacOsLabel : ILabel
{
	public MacOsLabel(string a_text) : base(a_text)
	{
		Console.WriteLine("Se ha creado esta etiqueta optimizada para Apple");
	}

	public override void Display()
	{
		Console.WriteLine($"El texto muestra la sigiente info{_text}");
	}
}
