using System;

using R5T.T0158;


namespace System
{
    public static class IHumanOutputExtensions
    {
        public static void WriteLine(this IHumanOutput humanOutput,
            string text,
            string newLine)
        {
            Instances.HumanOutputOperations.WriteLine(humanOutput,
                text,
                newLine);
        }

        public static void WriteLine(this IHumanOutput humanOutput,
            string text)
        {
            Instances.HumanOutputOperations.WriteLine(humanOutput,
                text);
        }

        public static void WriteLine_WithPause(this IHumanOutput humanOutput,
            string text,
            int pause_Milliseconds = IPauses.Standard_Milliseconds_Constant)
        {
            Instances.HumanOutputOperations.WriteLine_WithPause(
                humanOutput,
                text,
                pause_Milliseconds);
        }
    }
}
