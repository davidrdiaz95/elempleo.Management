namespace elempleo.Management.Services.Command
{
    public interface IDecryptCommand
    {
		Task<string> Execute(string cipherText);
	}
}
