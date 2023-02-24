using System;

using R5T.T0131;


namespace R5T.T0158.F000
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        public string TempHumanOutputDirectoryPath => @"C:\Temp\Human Output\";
    }
}
