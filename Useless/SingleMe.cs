namespace Useless
{
    /// <summary>
    /// SingleMe class.
    /// </summary>
    public class SingleMe
    {
        public static readonly SingleMe Me = new SingleMe();

        private SingleMe() { }

        public string Greet(string person)
        {
            return $"Aloha, {person}!";
        }
    }
}
