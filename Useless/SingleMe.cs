namespace Useless
{
    /// <summary>
    /// SingleMe class.
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
