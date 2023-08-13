using System;

using R5T.T0132;


namespace R5T.T0158
{
    [FunctionalityMarker]
    public partial interface IHumanOutputOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Creates a new null human output instance.
        /// </summary>
        public NullHumanOutput Get_New_Null()
        {
            var output = new NullHumanOutput();
            return output;
        }

        /// <summary>
        /// Returns the <see cref="NullHumanOutput.Instance"/> singleton instance.
        /// </summary>
        public NullHumanOutput Get_Null()
        {
            return NullHumanOutput.Instance;
        }
    }
}
