public interface IButton
{
	void onClick();
	void Display();
}
 
public abstract class ILabel 
{
	protected string _text = "";
	public abstract void Display();

	public ILabel(string a_text) 
	{ 
		
	}

}

public abstract class UIFactory	
{
	public abstract IButton CreateButton();
	public abstract ILabel CreateLabel(string text);
}






