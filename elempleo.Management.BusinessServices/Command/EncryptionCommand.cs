using elempleo.Management.Model.Section;
using elempleo.Management.Services.Command;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;

namespace elempleo.Management.BusinessServices.Command
{
	public class EncryptionCommand : IEncryptionCommand
	{
		private readonly EncryptSection options;

		public EncryptionCommand(IOptions<EncryptSection> options)
		{
			this.options = options.Value;
		}

		public async Task<string> Execute(string clearText)
		{
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes encryptor = Aes.Create())
			{
				var pdb = new Rfc2898DeriveBytes(this.options.Key, this.options.Ive, 10000, HashAlgorithmName.SHA256);
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(clearBytes, 0, clearBytes.Length);
						cs.Close();
					}
					clearText = Convert.ToBase64String(ms.ToArray());
				}
			}
			return clearText;
		}
	}
}
