using System;
using System.IO;


namespace R5T.T0158.T000
{
    /// <summary>
    /// Outputs text to a file.
    /// </summary>
    public sealed class TextFileHumanOutput : IHumanOutput, IDisposable
    {
        #region IDisposable

        private bool zDisposed = false;
        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.zDisposed)
            {
                if (disposing)
                {
                    this.FileWriter.Dispose();
                }

                this.zDisposed = true;
            }
        }

        ~TextFileHumanOutput()
        {
            this.Dispose(false);
        }

        #endregion


        private string TextFilePath { get; }
        private StreamWriter FileWriter { get; }


        public TextFileHumanOutput(
            string textFilePath)
        {
            this.TextFilePath = textFilePath;

            this.FileWriter = Instances.FileOperator.NewWrite_Text(
                this.TextFilePath);

            this.FileWriter.AutoFlush = true;
        }

        public void Write(string text)
        {
            this.FileWriter.Write(text);
        }
    }
}
