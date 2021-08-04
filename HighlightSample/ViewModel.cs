namespace HighlightSample
{
    public class ViewModel : ViewModelBase
    {

        #region FindString : string - FindStringed text

        /// <summary>Filtered text</summary>
        private string _FindString;

        /// <summary>FindStringed text</summary>
        public string FindString { get => _FindString; set => Set(ref _FindString, value); }

        #endregion

        #region FullText : string - Full text where will search

        /// <summary>Full text where will search</summary>
        private string _FullText;

        /// <summary>Full text where will search</summary>
        public string FullText { get => _FullText; set => Set(ref _FullText, value); }

        #endregion

        public ViewModel()
        {
            FullText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,"
                       + " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                       + " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris "
                       + "nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in "
                       + "reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla "
                       + "pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa "
                       + "qui officia deserunt mollit anim id est laborum.";
        }

    }
}
