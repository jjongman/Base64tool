using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Base64tool
{
    class Processor
    {
        private string _base64;

        public string Filepath { set; private get; }

        public string Base64
        {
            get
            {
                Byte[] bytes = File.ReadAllBytes(Filepath);
                _base64 = Convert.ToBase64String(bytes);
                return _base64;
            }
            set { _base64 = value; }
       
        }

        public Byte[] Filebytes
        {
            get { return Convert.FromBase64String(_base64); }
        }

    }
}
