namespace ConsoleApp1
{
    public interface IMensagemCelular
    {
        void EnviarMensagem(IContato cliente, string mensagem);
    }
}