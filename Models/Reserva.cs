namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"Quantidade de hospedes: {hospedes.Count()}, superior a capacidade da suíte: {Suite.Capacidade}.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M);
            }

            return valor;
        }
    }
}