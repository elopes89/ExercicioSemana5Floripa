namespace Excecoes;

public class IngressoException : Exception{
    public IngressoException(String msg): base(msg){

    }
    public IngressoException(string msg, Exception causa) : base(msg, causa){

    }
    public IngressoException(){
        
    }
}