public class Pato_Violento
{
    public Comportamiento_Quack quakear;

    public Pato_Violento(Comportamiento_Quack a_quaking)
    {
        quakear = a_quaking;
    }

    public void Quack()
    {
        quakear.Quack();
    }

    public void Respirar()
    {
        quakear.Respirar();
    }



}
