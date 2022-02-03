namespace TesteGFT.financas
{
    public class InvestimentoComIR:Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais):base(valorInicial, jurosMensais){

        }
        public double calcularLucro(int meses){
            double semDesconto = valorInicial * Math.Pow((1 + jurosMensais), meses) - valorInicial;
            if (meses>=24){
                return semDesconto - semDesconto*0.15;
            }else if(meses>=12){
                return semDesconto - semDesconto*0.175;
            }else{
                return semDesconto - semDesconto*0.225;
            }
        }
    }
}