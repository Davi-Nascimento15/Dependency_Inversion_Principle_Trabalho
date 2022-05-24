namespace ConsoleApp1
{
    public interface IEmail
    {
        void EnviarEmail(IContato cliente, string assunto, string mensagem);
    }
}