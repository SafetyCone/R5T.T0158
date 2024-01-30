using System;

using R5T.T0132;


namespace R5T.T0158.F000
{
    [FunctionalityMarker]
    public partial interface IHumanOutputTextFilePathOperator : IFunctionalityMarker
    {
        public string GetHumanOutputTextFilePath()
        {
            var directoryPath = Instances.DirectoryPaths.TempHumanOutputDirectoryPath;

            var fileName = Instances.HumanOutputTextFileNameOperator.GetHumanOutputTextFileName();

            var output = Instances.PathOperator.Get_FilePath(
                directoryPath,
                fileName);

            return output;
        }
    }
}
