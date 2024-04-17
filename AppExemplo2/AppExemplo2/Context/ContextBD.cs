using AppExemplo2.Model;

namespace AppExemplo2.Context
{
    public class ContextBD
    {
        public ContextBD()
        {
            Pessoas = new List<Pessoa>();
           
            
        }

        public List<Pessoa>? Pessoas { get; set; }
       
    }
}
