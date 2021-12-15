public abstract class SopaGenerica 
{
	public abstract string getMarca();
	public abstract string getNombre();
	public abstract string getSabor();
	public abstract int getPrecio();
}

public abstract class SopaDecorador : SopaGenerica 
{
	public SopaGenerica sopa_para_decorar;
	public SopaDecorador(SopaGenerica a_sopa_para_decorar) 
	{
		sopa_para_decorar = a_sopa_para_decorar;
	}
}


