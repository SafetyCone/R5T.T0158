using System;


namespace R5T.T0158
{
    public class Pauses : IPauses
    {
        #region Infrastructure

        public static IPauses Instance { get; } = new Pauses();


        private Pauses()
        {
        }

        #endregion
    }
}
