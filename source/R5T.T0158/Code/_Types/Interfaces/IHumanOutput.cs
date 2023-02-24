using System;


namespace R5T.T0158
{
    /// <summary>
    /// A human-output shows text to a human.
    /// </summary>
    /// <remarks>
    /// Synchronous calling convention since like logging, output to the human is just that, output, not interaction.
    /// (Even though the actual output to a file or some other sink might actually be asynchronous.)
    /// The assumption is that a human will see the output at the time text is written to the human output.
    /// <para>
    /// Similar to a log, except a human-output is only for the "high-points" that are worth a human's time.
    /// With a log you want a full log of everything that's happening.
    /// But even with debug and information levels of logging, logging levels are frequently set too high for content, and too low for filtering.
    /// </para>
    /// <para>
    /// Conversely, you might also output extraneous information to a human, just to show the code is working.
    /// For example, 10%, 20%, etc. complete statuses are extraneous.
    /// But for a human watching the a console perform a long-running operation, nothing is more nerve wracking that just seeing the dark console window sit doing nothing.
    /// </para>
    /// <para>
    /// Finally, a word on implementations.
    /// The motivation for a human-output was to use the console window.
    /// Instead of logging information cluttering up the console window while a script is running, only 
    /// But, human-output sinks are not limited to just the console.
    /// You will probably want a per-run file containing all the same content that was output to the console to make that content available for later use.
    /// And other human-output sinks might be status bars in Windows forms applications, or a blocking modal that displays the human-output as a long operation runs in a web app.
    /// </para>
    /// </remarks>
    public interface IHumanOutput
    {
        /// <summary>
        /// Write text to be seen by a human.
        /// </summary>
        /// <remarks>
        /// For writing a line, see extension methods.
        /// </remarks>
        void Write(string text);
    }
}
