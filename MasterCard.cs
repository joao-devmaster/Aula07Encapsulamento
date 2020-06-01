using System;

namespace aula07POO
{
    public class MasterCard : Cartao
    {
        
        public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto){
            
            cvv = 456;
            
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }

    }
}