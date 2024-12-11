namespace Console_History.Models
{
    public class PlatformConsoles
    {
        public int PlatformID { get; set; }

        public int ConsoleID { get; set; }

        public Platform Platform { get; set; }

        public Consoles Console { get; set; }
    }
}
