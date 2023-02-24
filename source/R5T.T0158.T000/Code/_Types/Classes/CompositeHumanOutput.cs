using System;


namespace R5T.T0158.T000
{
    /// <summary>
    /// Outputs text to multiple <see cref="IHumanOutput"/> instances.
    /// </summary>
    public sealed class CompositeHumanOutput : IHumanOutput
    {
        private IHumanOutput[] ChildHumanOutputs { get; }


        public CompositeHumanOutput(
            params IHumanOutput[] childHumanOutputs)
        {
            this.ChildHumanOutputs = childHumanOutputs;
        }

        public void Write(string text)
        {
            foreach (var childHumanOutput in this.ChildHumanOutputs)
            {
                childHumanOutput.Write(text);
            }
        }
    }
}
