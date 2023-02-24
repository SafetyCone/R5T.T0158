using System;


namespace R5T.T0158.F000
{
    public static class Instances
    {
        public static F0000.IDateTimeOperator DateTimeOperator => F0000.DateTimeOperator.Instance;
        public static IDirectoryPaths DirectoryPaths => F000.DirectoryPaths.Instance;
        public static IHumanOutputTextFileNameOperator HumanOutputTextFileNameOperator => F000.HumanOutputTextFileNameOperator.Instance;
        public static IHumanOutputTextFilePathOperator HumanOutputTextFilePathOperator => F000.HumanOutputTextFilePathOperator.Instance;
        public static F0000.INowOperator NowOperator => F0000.NowOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IValues Values => F000.Values.Instance;
    }
}