using System;


namespace R5T.T0158.F000
{
    public class HumanOutputTextFileNameOperator : IHumanOutputTextFileNameOperator
    {
        #region Infrastructure

        public static IHumanOutputTextFileNameOperator Instance { get; } = new HumanOutputTextFileNameOperator();


        private HumanOutputTextFileNameOperator()
        {
        }

        #endregion
    }
}
