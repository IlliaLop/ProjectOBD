using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diploma.Automation.Personas
{
    public class KnownPersonas
    {
        public static readonly IPersona SystemAdmin =
            new Persona
            {
                Username = "artem.verenco@gmail.com",
                Password = "123Qwe123!"
            };

        public static readonly IPersona SystemUser =
            new Persona
            {
                Username = "artemverenkotest@gmail.com",
                Password = "123Qwe123!"
            };
    }
}
