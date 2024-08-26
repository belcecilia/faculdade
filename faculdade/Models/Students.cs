namespace faculdade.Models
{
    public class Student
    {
        public int IdEstudante { get; set; }  // Propriedade para o ID
        public string NomeEstudante { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public DateTime datanas { get; set; }  // Data de nascimento
        public string nomecurso { get; set; }   // Nome do curso
        public string turno { get; set; }       // Turno
    }
}