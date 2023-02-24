using System;


namespace R5T.T0158.T000
{
    /// <summary>
    /// Outputs text to the console.
    /// </summary>
    public sealed class ConsoleHumanOutput : IHumanOutput
    {
        public void Write(string text)
        {
            Console.Write(text);
        }
    }
}
