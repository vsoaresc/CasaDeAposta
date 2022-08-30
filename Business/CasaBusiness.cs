using Entity;
namespace Business
{
    public class CasaBusiness
    {
        CasaEntity _casa;
        public double GetValorCasa(double valorCasa)
        {
            return _casa.ValorCasa = valorCasa;
        }

        public double GetValorEmpate(double valorEmpate)
        {
            return _casa.ValorEmpate = valorEmpate;
        }

        public double GetValorFora(double valorFora)
        {
            return _casa.ValorFora = valorFora;
        }
    }
}