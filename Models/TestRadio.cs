namespace Examples_MVC.Models
{
    public class TestRadio
    {
        public bool Dia { get; set; }
        public bool Noite { get; set; }
        public int Periodo { get; set; }

        public TestRadio()
        {
            
        }

        public TestRadio(bool dia, bool noite)
        {
            Dia = dia;
            Noite = noite;
        }

    }
}
