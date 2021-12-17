static class FactoryAñadirCondimentos
{
	public static SopaGenerica AñadirSalsa(string a_tipo_de_salsa, int a_cantidad_de_salsa, SopaGenerica a_sopa_para_decorar)
	{
		if (a_cantidad_de_salsa <= 0) { return a_sopa_para_decorar; }

		else if (a_tipo_de_salsa.ToLower() == "san luis")
		{
			return new SalsaSanLuis(AñadirSalsa(a_tipo_de_salsa, a_cantidad_de_salsa - 1, a_sopa_para_decorar));
		}

		else if (a_tipo_de_salsa.ToLower() == "valentina")
		{
			return new SalsaValentina(AñadirSalsa(a_tipo_de_salsa, a_cantidad_de_salsa - 1, a_sopa_para_decorar));
		}

		else { throw new ArgumentException("El tipo de salsa no se reconoce"); }

	}

}