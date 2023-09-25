namespace Contacorrente
{
    public class conta
    {
        public string titular { get; set; }

        private double saldo { get; set; }
       

        
       public conta (string nomePessoa, double saldoPessoa)
            {
                this.titular = nomePessoa;
                this.saldo = saldoPessoa;
            }
        public void depositar()
        {
            Console.WriteLine( "Digite o valor que deseja depositar" );
            double novoValor  = double.Parse(Console.ReadLine());

            if (novoValor > 0){
                saldo = novoValor + saldo;
                 Console.WriteLine( "Deposito efetuado com sucesso!" );
            }else{
                Console.WriteLine( "Digite um valor maior que 0" );
            }    
        }

        public void consultarSaldo(){
           Console.WriteLine($"Seu saldo é de R${saldo}");
        }

        public void Sacar(){

            Console.WriteLine($"Digite o valor que quer sacar");
            double valor = double.Parse(Console.ReadLine());

            if (saldo > valor)
            {
                saldo = valor - saldo ;
            } else{
                Console.Write("O valor escolhido excede o saldo");
            }
        }

        
    }
}