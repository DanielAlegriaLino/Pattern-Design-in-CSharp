public abstract class Weapon
{
	public string description = "";
	public abstract string getDescription();


	protected int damage = 0;
	public abstract int getDamage();

}

public abstract class WeaponDecorator : Weapon
{
	Weapon weapon2decorate;
	public WeaponDecorator(Weapon a_weapon)
	{
		weapon2decorate = a_weapon;
	}
	public Weapon Weapon2Decorate { get { return weapon2decorate; } }

}













