public abstract class Condimentos : SopaDecorador
{
	public Condimentos(SopaGenerica a_sopa_para_decorar) : base(a_sopa_para_decorar) { }
	public override string getMarca()
	{
		return sopa_para_decorar.getMarca();
	}

	public override string getNombre()
	{
		return sopa_para_decorar.getNombre();
	}

}
public class SalsaValentina : Condimentos
{
	public SalsaValentina(SopaGenerica a_sopa_para_decorar) : base(a_sopa_para_decorar) { }
	public override int getPrecio()
	{
		return sopa_para_decorar.getPrecio() + 2;
	}

	public override string getSabor()
	{
		return sopa_para_decorar.getSabor() + ", con un toque medio picoso";
	}
}

public class SalsaSanLuis : Condimentos
{
	public SalsaSanLuis(SopaGenerica a_sopa_para_decorar) : base(a_sopa_para_decorar) { }
	public override int getPrecio()
	{
		return sopa_para_decorar.getPrecio() + 3;
	}

	public override string getSabor()
	{
		return sopa_para_decorar.getSabor() + ", con un toque levemente picoso";
	}
}

public class Limon : Condimentos 
{
	public Limon(SopaGenerica a_sopa_para_decorar) : base(a_sopa_para_decorar) 
	{

	}

	public override int getPrecio()
	{
		return sopa_para_decorar.getPrecio() + 5;
	}

	public override string getSabor()
	{
		return sopa_para_decorar.getSabor() + ", con un toque acido"; 
	}
}