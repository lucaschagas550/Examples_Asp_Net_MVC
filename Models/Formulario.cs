namespace Examples_MVC.Models;

public class Formulario
{
    public TestRadio Radio { get; set; } = new TestRadio();
    
    public string Nome { get; set; } = string.Empty;
    public string ExercicioDe { get; set; } = string.Empty;
    public string ExercicioAte { get; set; } = string.Empty;
    
    public Formulario()
    {
    }
    
    public Formulario(TestRadio radio, string nome)
    {
        Radio = radio;
        Nome = nome;
    }
}