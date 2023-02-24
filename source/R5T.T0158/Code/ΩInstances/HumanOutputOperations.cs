using System;


namespace R5T.T0158
{
    public class HumanOutputOperations : IHumanOutputOperations
    {
        #region Infrastructure

        public static IHumanOutputOperations Instance { get; } = new HumanOutputOperations();


        private HumanOutputOperations()
        {
        }

        #endregion
    }
}
