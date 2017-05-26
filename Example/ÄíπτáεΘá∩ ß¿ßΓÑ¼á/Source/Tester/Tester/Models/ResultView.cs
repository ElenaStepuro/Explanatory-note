namespace Tester.Models
{
    public class ResultView
    {
        string _quest;
        string _aansver;
        string _trueOrfalse;

        public string Quest
        {
            get { return _quest; }
            set { _quest = value; }
        }

        public string Aansver
        {
            get { return _aansver; }
            set { _aansver = value; }
        }

        public string TrueOrfalse
        {
            get { return _trueOrfalse; }
            set { _trueOrfalse = value; }
        }

    }
}
