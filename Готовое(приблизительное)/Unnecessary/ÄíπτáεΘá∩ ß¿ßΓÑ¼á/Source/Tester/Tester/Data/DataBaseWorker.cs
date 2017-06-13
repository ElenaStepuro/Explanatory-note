using System;
using System.Collections.Generic;
using System.Linq;
using ShoolTester;
using Tester.Models;

namespace Tester.Data
{
    public class DataBaseWorker
    {
        private static DataBaseWorker instance;

        public readonly List<User> Users;
        public readonly List<QuestionRecord> QuestionTable;
        public readonly List<AnswerRecord> AnswerTable;
        public readonly List<TaskRecord> TaskTable;
        public readonly List<TestRecord> TestTable;
        public readonly List<TaskTestRecord> TaskTestTable;
        public readonly List<ResultRecord> ResultsTable;

        public DataBaseWorker()
        {
            Users = new List<User>();
            QuestionTable = new List<QuestionRecord>();
            AnswerTable = new List<AnswerRecord>();
            TaskTable = new List<TaskRecord>();
            TestTable = new List<TestRecord>();
            TaskTestTable = new List<TaskTestRecord>();
            ResultsTable = new List<ResultRecord>();
        }

        public static DataBaseWorker Instance
        {
            get
            {
                if (instance == null)
                {
                    if (Casher.Exists(typeof(DataBaseWorker)))
                    {
                        instance = (DataBaseWorker)Casher.Load(typeof(DataBaseWorker));
                        instance.Initialize();
                        return instance;
                    }
                    instance = new DataBaseWorker();
                    instance.Initialize();
                    Casher.Save(instance);
                    return instance;
                }
                return instance;
            }
        }


        private void Initialize()
        {
            Users.Add(new User { Id = 0, Fio = "Admin", Status = true, login = "admin", pass = "202cb962ac59075b964b07152d234b70" });
        }

        public User Login(String parUserLogin, String parPassword)
        {
            return Users.FirstOrDefault(parOne => parOne.pass == parPassword && parOne.login == parUserLogin);
        }

        public Dictionary<int, Test> SelectAllTests()
        {
            var tests = new Dictionary<int, Test>();

            foreach (var testRecord in TestTable)
            {
                Test temp = new Test { Id = testRecord.ID, Name = testRecord.Name, TimeConstraint = testRecord.TimeConstraint };

                HashSet<int> testCount = new HashSet<int>();
                foreach (var taskTest in TaskTestTable)
                    if (taskTest.Test == temp.Id)
                    {
                        var task = GetTaskById(taskTest.Task);
                        testCount.Add(task.QuestID);
                    }
            
                temp.QuestCount = testCount.Count;

                tests.Add(temp.Id, temp);
            }

            return tests;
        }

        public List<TableNoEval> GetTableNoEvals(int parTestId)
        {
            List<TableNoEval> result = new List<TableNoEval>();

            HashSet<int> tasks = new HashSet<int>();
            foreach (var taskTest in TaskTestTable)
                if (taskTest.Test == parTestId)
                    tasks.Add(taskTest.Task);

            foreach (var task in tasks)
            {
                var taskObj = GetTaskById(task);
                var ansObj = GetAnswerById(taskObj.AnsverID);
                var qstObj = GetQuestById(taskObj.QuestID);
                var testObj = GetTestById(parTestId);

                if (taskObj != null && ansObj != null && qstObj != null && testObj != null)
                {
                    TableNoEval temp = new TableNoEval
                    {
                        TrueAns = taskObj.TrueID,
                        AnsverID = taskObj.AnsverID,
                        Ansver = ansObj.Answer,
                        Quest = qstObj.Question,
                        IDQuest = qstObj.ID,
                        Image = qstObj.Image,
                        QuestImage = qstObj.IamgeQuest,
                        Constraint = testObj.TimeConstraint
                    };
                    result.Add(temp);
                }
            }
            return result;
        }

        public List<ResultRecord> GetResults()
        {
            return ResultsTable;
        }

        public List<ResultRecord> GetResults(int parTestId, int parUserId)
        {
            return ResultsTable.Where(parOne => parOne.TestID == parTestId && parOne.UserID == parUserId).ToList();
        }

        public void SaveUser(User parUser)
        {
            parUser.Id = Users.Count;
            Users.Add(parUser);
        }

        public void InsertResults(List<ResultRecord> parRes)
        {
            ResultsTable.AddRange(parRes);
            Casher.Save(this);
        }

        public void RemoveResults(int parUserId, int parTestId)
        {
            var allResults = GetResults();
            allResults.RemoveAll(parResult => (parResult.TestID == parTestId && parResult.UserID == parUserId));
            Casher.Save(this);
        }

        public int AddQuestion(QuestionRecord parRecord)
        {
            var res = QuestionTable.Count;
            parRecord.ID = res;
            QuestionTable.Add(parRecord);
            Casher.Save(this);
            return res;
        }

        public int AddAnswer(AnswerRecord parRecord)
        {
            var res = AnswerTable.Count ;
            parRecord.ID = res;
            AnswerTable.Add(parRecord);
            Casher.Save(this);
            return res;
        }

        public int AddTask(TaskRecord parTaskRecord)
        {
            var res = TaskTable.Count ;
            parTaskRecord.ID = res;
            TaskTable.Add(parTaskRecord);
            Casher.Save(this);
            return res;
        }

        public int AddTest(TestRecord parRecord)
        {
            var res = TestTable.Count ;
            parRecord.ID = res;
            TestTable.Add(parRecord);
            Casher.Save(this);
            return res;
        }

        public void AddTaskTest(TaskTestRecord parRecord)
        {
            TaskTestTable.Add(parRecord);
            Casher.Save(this);
        }

        public QuestionRecord GetQuestById(int parId)
        {
            return QuestionTable.FirstOrDefault(parOne => parOne.ID == parId);
        }

        public AnswerRecord GetAnswerById(int parId)
        {
            return AnswerTable.FirstOrDefault(parOne => parOne.ID == parId);
        }

        public TaskRecord GetTaskById(int parId)
        {
            return TaskTable.FirstOrDefault(parOne => parOne.ID == parId);
        }

        public TestRecord GetTestById(int parId)
        {
            return TestTable.FirstOrDefault(parOne => parOne.ID == parId);
        }

    }


}
