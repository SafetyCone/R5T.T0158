using System;
using System.Threading;

using R5T.T0132;



namespace R5T.T0158
{
    [FunctionalityMarker]
    public partial interface IHumanOutputOperations : IFunctionalityMarker
    {
        public void Write(IHumanOutput humanOutput,
            Action<IHumanOutput> preAction = default,
            Action<IHumanOutput> action = default,
            Action<IHumanOutput> postAction = default)
        {
            Instances.ActionOperator.Run(preAction, humanOutput);
            Instances.ActionOperator.Run(action, humanOutput);
            Instances.ActionOperator.Run(postAction, humanOutput);
        }

        public void WriteLine(IHumanOutput humanOutput,
            string text,
            string newLine)
        {
            var line = Instances.TextOperator.MakeLine(
                text,
                newLine);

            humanOutput.Write(line);
        }

        public void WriteLine(IHumanOutput humanOutput,
            string text)
        {
            this.WriteLine(humanOutput,
                text,
                Instances.Strings.NewLine_ForEnvironment);
        }

        public void WriteLine_WithPause(IHumanOutput humanOutput,
            string text,
            int pause_Milliseconds = IPauses.Standard_Milliseconds_Constant)
        {
            this.WriteLine(humanOutput,
                text);

            Thread.Sleep(pause_Milliseconds);
        }

        public void WriteLine(IHumanOutput humanOutput,
            string text,
            int pause_Milliseconds)
        {
            this.WriteLine_WithPause(humanOutput,
                text,
                pause_Milliseconds);
        }
    }
}
