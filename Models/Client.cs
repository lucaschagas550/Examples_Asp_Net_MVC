namespace Examples_MVC.Models
{
    public class Client
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;

        public Client()
        {
            
        }

        public Client(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
