namespace elempleo.Management.Services.Command
{
    public interface IEncryptionCommand
    {
		Task<string> Execute(string clearText);
	}
}
