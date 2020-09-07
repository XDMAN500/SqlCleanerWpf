using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SqlCleanserWPF
{
    public class TextData : INotifyPropertyChanged
    {

        private Regex symbols = new Regex(@"""|\+");
        private Regex prepParams = new Regex(@"\?");
        private string _rawtext;
        private string _cleantext;


        public TextData() {
            _rawtext = "";
            _cleantext = "";
        }

        public string RawText { 
            set {
                _rawtext = value;

                OnPropertyChanged("RawText");
            }
            get => _rawtext; 
        }


        public string CleanText
        {
            set
            {
                _cleantext = value;

                OnPropertyChanged("CleanText");
            }
            get => _cleantext;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void RunClean()
        {

            String intermediate = RawText;
            intermediate = cleanSymbols(intermediate);
            intermediate = cleanPrepParams(intermediate);


            CleanText = intermediate;
        }

        private String cleanSymbols(String input) 
        {
            return symbols.Replace(input, "");
        }

        private String cleanPrepParams(String input)
        {
            return prepParams.Replace(input, "1");
        }

    }
}
