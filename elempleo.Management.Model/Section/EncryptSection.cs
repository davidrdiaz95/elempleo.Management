using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elempleo.Management.Model.Section
{
    public class EncryptSection
    {
		public string Key { get; set; }
		public byte[] Ive { get; set; }
	}
}
