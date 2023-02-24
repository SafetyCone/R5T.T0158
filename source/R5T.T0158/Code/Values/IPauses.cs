using System;

using R5T.T0131;


namespace R5T.T0158
{
    [ValuesMarker]
    public partial interface IPauses : IValuesMarker
    {
        public const int QuarterSecond_Milliseconds_Constant = 250;
        public int QuarterSecond_Milliseconds => IPauses.QuarterSecond_Milliseconds_Constant;

        public const int Standard_Milliseconds_Constant = IPauses.QuarterSecond_Milliseconds_Constant;
        public int Standard_Milliseconds => IPauses.Standard_Milliseconds_Constant;
    }
}
