using System.ComponentModel.DataAnnotations;

namespace Examples_MVC.Models
{
    public class EditorTexto
    {
        public EditorTexto(string content)
        {
            Content = content;
        }

        public EditorTexto()
        {

        }

        [Required(ErrorMessage = "Erro")]
        public string? Content { get; set; } = string.Empty;
    }
}
