﻿namespace DevopsDavidson.Models
{
    public class Aluno

    {
        public Aluno()
        {
            
        }

        public Guid Id { get; set; }
        public String ?Nome { get; set; }
        public String ?Rgm { get; set; }
        public String ?Professor { get; set; }
        public String ?Email { get; set; }
        public DateTime Idade { get; set; }
      
    }
}
