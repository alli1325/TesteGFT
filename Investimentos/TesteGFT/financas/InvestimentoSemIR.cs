namespace TesteGFT.financas
{
    public class InvestimentoSemIR:Investimento
    {
        public InvestimentoSemIR(double valorInicial, double jurosMensais):base(valorInicial, jurosMensais){

        }
        public double calcularLucro(int meses){
            if (valorInicial < 1000.00){
                return 0;
            }else{
                return valorInicial * Math.Pow((1 + jurosMensais), meses) - valorInicial;
            }
        }
        
    }
}