namespace Animal
{
    public class Pantera
    {
        public string nome { get; set; }
        public string peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao{ get; set; }


        public void correr(){
            Console.WriteLine($" O animal {nome} está correndo");
        }
        public void cacar(){
            Console.WriteLine($"Eles se alimentam de {alimentacao} e pesa cerca de {peso}");
        }
        
    }
}