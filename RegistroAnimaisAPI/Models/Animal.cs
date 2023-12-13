using RegistroAnimaisAPI.Models.Enums;

namespace RegistroAnimaisAPI.Models {
    public class Animal {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public Classificacao Classificacao { get; set; }
        public DateTime? PeriodoCio { get; set; }
        public Boolean EstaPrenha { get; set; }
        public DateTime? PeriodoGestacao { get; set; }
        public double Peso { get; set; }
        public int? FiliacaoId { get; set; }
        public string? Observacao { get; set; }

        public Animal() { }

        public Animal(int id, string nome, string observacao, Genero genero, Classificacao classificacao,
                        DateTime periodoCio, bool estaPrenha, DateTime periodoGestacao, double peso, int filiacaoId) {
            Id = id;
            Nome = nome;
            Observacao = observacao;
            Genero = genero;
            Classificacao = classificacao;
            PeriodoCio = periodoCio;
            EstaPrenha = estaPrenha;
            PeriodoGestacao = periodoGestacao;
            Peso = peso;
            FiliacaoId = filiacaoId;
        }
    }
}
