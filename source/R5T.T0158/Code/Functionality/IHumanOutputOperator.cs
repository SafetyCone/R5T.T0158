using System;

using R5T.T0132;


namespace R5T.T0158
{
    [FunctionalityMarker]
    public partial interface IHumanOutputOperator : IFunctionalityMarker
    {
        public NullHumanOutput NewNull()
        {
            var output = new NullHumanOutput();
            return output;
        }
    }
}
