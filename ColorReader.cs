using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp
{
    public class ColorReader : IColorReader
    {
        #region Members

        public delegate void CallBackHandler(string message);
        public event CallBackHandler CallBack = null;

        private List<Color> _loadedList = null;

        #endregion

        #region Implementation

        /// <summary>
        /// Raises the CallBack event. All communication with the UI should be handled through this method.
        /// </summary>
        /// <param name="message">The string to be raised as a status update to the UI</param>
        public void RaiseCallback(string message)
        {
            // TODO: Implement the RaiseCallback method.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the specified csv data file.
        /// Callback to display the R,G,B value of every color found where the R value is greater than both the G and B values.
        /// Data rows in the csv may be malformed, contain non-parsable data, or otherwise be unusable.
        /// The data will contain row headers to specify which column contains which color.
        /// The possible headers are: "Red", "Green", and "Blue" (but without the quotation marks)
        /// </summary>
        /// <param name="fullFilePath">The full path to the data file in question</param>
        public IEnumerable<Color> LoadDataFile(string fullFilePath)
        {
            // TODO: Implement the LoadDataFile method.
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns the total number of rows that were successfully parsed by the LoadDataFile method.
        /// </summary>
        public int MatchesFound
        {
            get
            {
                // TODO: Implement the MatchesFound method.
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns the total number of rows where Red was the most significant color in all successfully parsed results.
        /// </summary>
        public int ColorsFound
        {
            get
            {
                // TODO: Implement the ColorsFound method.
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Methods

        public void StartProcessing(string filePath)
        {
            this.RaiseCallback("Loading data file...");

            _loadedList = this.LoadDataFile(filePath).ToList();

            this.RaiseCallback("Processing complete.");
        }

        #endregion
    }
}
