namespace ClientRegistrationProgram
{
    public interface IAuthService
    {
        bool EmailExists(object email);
        bool Register(object email, object password, string v);
    }
}