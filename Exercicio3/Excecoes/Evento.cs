namespace Excecoes;

public class Evento {
     
     int qtdLugares;
     public int QtdLugares{get; set;}
     public int QtdIngressosvendidos { get; set;}
     
     public Evento(){

     }

     public void VendaIngressos(){
        System.Console.WriteLine("Ingresso vendido com sucesso!");
     }

}