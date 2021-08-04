namespace HighlightSample
{
    public class ViewModel : ViewModelBase
    {
        private string filter;
        private string fullText;

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
