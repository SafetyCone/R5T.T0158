using System;


namespace R5T.T0158.F000
{
    public class Values : IValues
    {
        #region Infrastructure

        public static IValues Instance { get; } = new Values();


        private Values()
        {
        }

        #endregion
    }
}
