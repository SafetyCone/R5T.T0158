using System;
using System.Threading.Tasks;

using R5T.T0132;

using R5T.T0158.T000;


namespace R5T.T0158.F000
{
    [FunctionalityMarker]
    public partial interface IHumanOutputOperator : IFunctionalityMarker
    {
        public ConsoleHumanOutput Get_Console()
        {
            var output = new ConsoleHumanOutput();
            return output;
        }

        public CompositeHumanOutput GetCompositeHumanOutput_ConsoleAndFile(
            string humanOutputTextFilePath)
        {
            var consoleHumanOutput = this.Get_Console();

            var textFileHumanOutput = new TextFileHumanOutput(
                humanOutputTextFilePath);

            var compositeHumanOutput = new CompositeHumanOutput(
                consoleHumanOutput,
                textFileHumanOutput);

            return compositeHumanOutput;
        }

        public IHumanOutput Get_New_Null()
        {
            var output = new NullHumanOutput();
            return output;
        }

        /// <summary>
        /// Creates a composite console and text-file human output instance, and provides it to the specified action.
        /// </summary>
        public async Task InHumanOutputContext(
            string humanOutputTextFilePath,
            Func<IHumanOutput, Task> humanOutputAction)
        {
            var compositeHumanOutput = this.GetCompositeHumanOutput_ConsoleAndFile(
                humanOutputTextFilePath);

            await humanOutputAction(compositeHumanOutput);
        }

        /// <inheritdoc cref="InHumanOutputContext(string, Func{IHumanOutput, Task})"/>
        public void InHumanOutputContext_Synchronous(
            string humanOutputTextFilePath,
            Action<IHumanOutput> humanOutputAction)
        {
            var compositeHumanOutput = this.GetCompositeHumanOutput_ConsoleAndFile(
                humanOutputTextFilePath);

            humanOutputAction(compositeHumanOutput);
        }

        /// <summary>
        /// <inheritdoc cref="InHumanOutputContext(string, Func{IHumanOutput, Task})" path="/summary"/>
        /// </summary>
        /// <returns>The file path of the human output text file.</returns>
        public async Task<string> InHumanOutputContext(
            Func<string> humanOutputTextFilePathProvider,
            Func<IHumanOutput, Task> humanOutputAction)
        {
            var humanOutputTextFilePath = humanOutputTextFilePathProvider();

            await this.InHumanOutputContext(
                humanOutputTextFilePath,
                humanOutputAction);

            return humanOutputTextFilePath;
        }

        /// <inheritdoc cref="InHumanOutputContext(Func{string}, Func{IHumanOutput, Task})"/>
        public string InHumanOutputContext_Synchronous(
            Func<string> humanOutputTextFilePathProvider,
            Action<IHumanOutput> humanOutputAction)
        {
            var humanOutputTextFilePath = humanOutputTextFilePathProvider();

            this.InHumanOutputContext_Synchronous(
                humanOutputTextFilePath,
                humanOutputAction);

            return humanOutputTextFilePath;
        }

        /// <inheritdoc cref="InHumanOutputContext(Func{string}, Func{IHumanOutput, Task})"/>
        public Task<string> InHumanOutputContext(
            Func<IHumanOutput, Task> humanOutputAction)
        {
            return this.InHumanOutputContext(
                Instances.HumanOutputTextFilePathOperator.GetHumanOutputTextFilePath,
                humanOutputAction);
        }

        /// <inheritdoc cref="InHumanOutputContext(Func{string}, Func{IHumanOutput, Task})"/>
        public string InHumanOutputContext_Synchronous(
            Action<IHumanOutput> humanOutputAction)
        {
            return this.InHumanOutputContext_Synchronous(
                Instances.HumanOutputTextFilePathOperator.GetHumanOutputTextFilePath,
                humanOutputAction);
        }
    }
}
