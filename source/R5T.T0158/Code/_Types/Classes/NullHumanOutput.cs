using System;


namespace R5T.T0158
{
    /// <summary>
    /// Does nothing.
    /// </summary>
    public class NullHumanOutput : IHumanOutput
    {
        #region Static

        public static readonly NullHumanOutput Instance = new NullHumanOutput();

        #endregion


        public void Write(string text)
        {
            // Do nothing.
        }
    }
}
