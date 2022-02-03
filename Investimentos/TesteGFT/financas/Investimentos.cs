namespace TesteGFT.financas
{
    public class Investimento {
            protected double valorInicial { get ; set;}
            protected double jurosMensais { get ; set;}
            public Investimento(double valorInicial, double jurosMensais){
                this.valorInicial = valorInicial;
                this.jurosMensais = jurosMensais;
            }
            public double calcularLucro(int meses){
                return valorInicial * Math.Pow((1 + jurosMensais), meses) - valorInicial;
            }
        }
}