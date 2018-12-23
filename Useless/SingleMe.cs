namespace Useless
{
    /// <summary>
    /// SingleMe classs.
    /// </summary>
    public class SingleMe
    {
        public static readonly SingleMe Instance = new SingleMe();

        private SingleMe() { }

        public override string ToString()
        {
            return "Single Me!";
        }
    }
}
