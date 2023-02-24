using System;


namespace R5T.T0158
{
    public class HumanOutputOperator : IHumanOutputOperator
    {
        #region Infrastructure

        public static IHumanOutputOperator Instance { get; } = new HumanOutputOperator();


        private HumanOutputOperator()
        {
        }

        #endregion
    }
}
