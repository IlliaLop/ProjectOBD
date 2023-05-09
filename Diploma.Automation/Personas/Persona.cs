namespace Diploma.Automation.Personas
{
    public class Persona : IPersona
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return this.Username;
        }
    }
}