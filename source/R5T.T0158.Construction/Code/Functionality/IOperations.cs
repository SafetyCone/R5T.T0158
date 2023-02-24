using System;

using R5T.T0132;


namespace R5T.T0158.Construction
{
    [FunctionalityMarker]
    public partial interface IOperations : IFunctionalityMarker
    {
        public void TestHumanOutput()
        {
            var humanOutputTextFilePath = Instances.HumanOutputOperator.InHumanOutputContext_Synchronous(
                humanOutput =>
                {
                    humanOutput.WriteLine_WithPause(
                        "Human output works!",
                        5000);
                });

            Instances.NotepadPlusPlusOperator.Open(humanOutputTextFilePath);
        }
    }
}
