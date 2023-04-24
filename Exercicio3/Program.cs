namespace Excecoes;

public class Program
{
    static void Main(string[] args)
    {
        Evento evento = new Evento();
        evento.QtdIngressosvendidos = 15;
        evento.QtdLugares = 12;

        try
        {
            if (evento.QtdLugares > evento.QtdIngressosvendidos)
            {
                System.Console.WriteLine("Ingresso validado!");
                evento.VendaIngressos();
            }
            else
            {
                throw new IngressoException("Não existem mais lugares disponíveis!");
            }
        }
        catch (IngressoException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
