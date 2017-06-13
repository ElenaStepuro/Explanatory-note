using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace ShoolTester
{
    public class Ansver
    {
        public string Text { get; set; }
        public int ID { get; set; }
        public int IDInTable { get; set; }
    }

    public class Question : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Question() { }
        public int IDInTable { get; set; }
        public Question(List<Ansver> parAnsvers, string parName, int trueAnsv, byte[] parImage, byte[] ImageQuest)
        {
            Image = parImage;
            Ansvers = parAnsvers;
            Name = parName;
            TrueAnsverID = trueAnsv;
            QuestionImage = ImageQuest;
        }
        public int Count
        {
            get { return Ansvers.Count; }
        }

        public List<Ansver> Ansvers = new List<Ansver>();

        public int ID { get; set; }
        public byte[] Image { get; set; }
        public byte[] QuestionImage { get; set; }
        public string Name { get; set; }

        public int TrueAnsverID { get; set; }

        public string this[int index]
        {
            get
            {
                return Ansvers[index].Text;
            }
        }

        public int this[string index]
        {
            get
            {
                foreach (var s in Ansvers)
                    if (s.Text == index)
                        return s.ID;
                return -1;
            }
        }
    }

    public class TestFlow
    {
        public int ID;
        public delegate void TestComplited(EventArgs e);
        public event TestComplited TestFinished;
        public delegate void TestTickEventHandler(EventArgs e);
        public event TestTickEventHandler TestTick;
        private readonly DateTime _timeConstraint;
        private readonly MyTimeSpan _span;

        public int Current { get { return _currentQuestion; } }

        private readonly System.Windows.Forms.Timer _timer;
        private readonly List<Question> _questions = new List<Question>();
        private int _currentQuestion = -1;
        private bool _isTimeOut;
        private bool _isComplited;
        private bool _started;

        public DateTime TimeConstraint()
        {
            return _timeConstraint;
        }

        public MyTimeSpan Span()
        {
            return _span;
        }

        public TestFlow(DateTime parConstarint, List<Question> parQuestions)
        {
            _questions = parQuestions;
            _timeConstraint = parConstarint;
            _timer = new System.Windows.Forms.Timer();
            _span = new MyTimeSpan(_timeConstraint.Hour, _timeConstraint.Minute, _timeConstraint.Second);
            _timer.Interval = 1000;
            _timer.Tick += TimerTick;
        }

        public int QuestionCount()
        {
            return _questions.Count;
        }
        public bool IsComplited
        {
            get { return _isComplited; }
        }

        public void Start()
        {
            _started = true;
            // если интервал не равен 0 
            // запускаем таймер
            if (!_span.IsTimeZero)
                _timer.Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            // Время вышло
            if (_span.IsTimeZero)
            {
                _timer.Stop();
                _isTimeOut = true;
                var ee = new EventArgs();
                if (TestFinished != null)
                    TestFinished(ee);
            }
            else
            {
                _span.TickBack();
                var ev = new EventArgs();
                if (TestTick != null)
                    TestTick(ev);
            }
        }

        public Question GetNextQuestion()
        {
            // если есть еще вопросы
            if (_questions.Count > _currentQuestion + 1)
            {
                _currentQuestion = _currentQuestion + 1;
                return _questions[_currentQuestion];
            }
            // вопросы закончились тест закончен
            _isComplited = true;
            _timer.Stop();
            var e = new EventArgs();
            if (TestFinished != null)
                TestFinished(e);

            return new Question();
        }

        public Question GetBackQuestion()
        {
            // если есть еще вопросы
            if (_currentQuestion > 0)
            {
                _currentQuestion = _currentQuestion - 1;
                return _questions[_currentQuestion];
            }
            return new Question();
        }


    }

    public class MyTimeSpan
    {

        public int _hours;
        public int _minutes;
        public int _seconds;
        private bool _finish;

        public bool IsTimeZero
        {
            get
            {
                if (_hours == 0 && _minutes == 0 && _seconds == 0)
                    return true;
                return false;
            }
        }

        public MyTimeSpan(int h, int m, int s)
        {
            _hours = h;
            _minutes = m;
            _seconds = s;
        }
        public void TickBack()
        {
            if (_seconds-- == 0)
            {
                _seconds = 60;
                if (_minutes-- == 0)
                {
                    _minutes = 60;
                    if (_hours-- == 0)
                        _finish = true;
                }
            }
        }

        public override string ToString()
        {
            return _hours + ":" + _minutes + ":" + _seconds;
        }
    }

    public class TableNoEval
    {
        public string Quest;
        public string Ansver;
        public int AnsverID;
        public int TrueAns;
        public int IDQuest;
        public DateTime Constraint;
        public byte[] Image;
        public byte[] QuestImage;
    }
}
