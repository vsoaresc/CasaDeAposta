using Business;

CasaBusiness casa = new CasaBusiness();
ApostaBusiness aposta = new ApostaBusiness();
CalculoBusiness calculo = new CalculoBusiness();


Console.WriteLine("Insira o valor pago pela casa: ");
var valorCasa = Convert.ToDouble(Console.ReadLine());
casa.GetValorCasa(valorCasa);

Console.WriteLine("Insira o valor pago pelo empate: ");
var valorEmpate = Convert.ToDouble(Console.ReadLine());
casa.GetValorEmpate(valorEmpate);

Console.WriteLine("Insira o valor pago por fora: ");
var valorFora = Convert.ToDouble(Console.ReadLine());
casa.GetValorFora(valorFora);

Console.WriteLine("Insira o valor que deseja apostar: ");
var valorAposta = Convert.ToDouble(Console.ReadLine());
aposta.GetValorAposta(valorAposta);

calculo.ValorFinal(valorAposta,valorCasa);
calculo.ValorFinal(valorAposta, valorEmpate);
calculo.ValorFinal(valorAposta, valorFora);

