using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero
{
    public class USUARIO
    {
        private string titular;
        private string contra;
        private string cuenta;

        public string Titular { get => titular; set => titular = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contra { get => contra; set => contra = value; }
    }
}
