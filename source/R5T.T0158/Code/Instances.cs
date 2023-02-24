using System;


namespace R5T.T0158
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static IHumanOutputOperations HumanOutputOperations => T0158.HumanOutputOperations.Instance;
        public static Z0000.IStrings Strings => Z0000.Strings.Instance;
        public static F0000.ITextOperator TextOperator => F0000.TextOperator.Instance;
    }
}