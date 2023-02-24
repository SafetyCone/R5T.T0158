using System;


namespace R5T.T0158.F000
{
    public class HumanOutputTextFilePathOperator : IHumanOutputTextFilePathOperator
    {
        #region Infrastructure

        public static IHumanOutputTextFilePathOperator Instance { get; } = new HumanOutputTextFilePathOperator();


        private HumanOutputTextFilePathOperator()
        {
        }

        #endregion
    }
}
