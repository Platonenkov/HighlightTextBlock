namespace HighlightSample
{
    public class ViewModel : ViewModelBase
    {
        private string filter;
        private string fullText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public string Filter
        {
            get { return filter; }
            set { Set(ref filter, value); }
        }

        public string FullText
        {
            get { return fullText; }
            set { Set(ref fullText, value); }
        }

    }
}
