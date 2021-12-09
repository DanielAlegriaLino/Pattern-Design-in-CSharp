public class FireEnchantment : WeaponDecorator
{

	public FireEnchantment(Weapon a_weapon2decorate) : base(a_weapon2decorate) { }

	public override int getDamage()
	{
		return 5 + Weapon2Decorate.getDamage();
	}

	public override string getDescription()
	{
		return Weapon2Decorate.getDescription() + ", In fire";
	}
}