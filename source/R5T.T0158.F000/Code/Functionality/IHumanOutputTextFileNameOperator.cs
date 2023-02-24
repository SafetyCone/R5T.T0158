using System;

using R5T.T0132;


namespace R5T.T0158.F000
{
    [FunctionalityMarker]
    public partial interface IHumanOutputTextFileNameOperator : IFunctionalityMarker
    {
        public string GetHumanOutputTextFileName(
            string applicationName,
            DateTime dateTime)
        {
            var dateTimeToken = Instances.DateTimeOperator.ToString_YYYYMMDD_HHMMSS(dateTime);

            var output = $"{applicationName}-{dateTimeToken}";
            return output;
        }

        public string GetHumanOutputTextFileName(
            string applicationName)
        {
            var dateTime = Instances.NowOperator.GetNow();

            var output = this.GetHumanOutputTextFileName(
                applicationName,
                dateTime);

            return output;
        }

        public string GetHumanOutputTextFileName()
        {
            var applicationName = Instances.Values.DefaultApplicationName;

            var output = this.GetHumanOutputTextFileName(
                applicationName);

            return output;
        }
    }
}
