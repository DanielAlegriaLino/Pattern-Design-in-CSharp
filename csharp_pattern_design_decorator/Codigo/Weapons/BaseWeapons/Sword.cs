public class Sword : Weapon
{
	public Sword()
	{
		damage = 3;
		description = getDescription();
	}

	public override int getDamage()
	{
		return damage;
	}

	public override string getDescription()
	{
		return "Is a sword";
	}
}