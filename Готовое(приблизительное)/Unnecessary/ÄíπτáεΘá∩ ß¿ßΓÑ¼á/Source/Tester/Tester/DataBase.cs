using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Tester.Data;
using Tester.Models;

namespace ShoolTester
{
    public static class DataBase
    {
        private static User user;

        public static int UserId
        {
            get
            {
                if (user != null) return user.Id;
                return -1;
            }
        }

        public static bool IsAdmin
        {
            get { return user.Status; }
        }

        public static String Fio
        {
            get { return user.Fio; }
        }

        public static void Connect(string parServerName)
        {
            MessageBox.Show("Соединение установлено");
        }

        public static Dictionary<int, Test> GetAllTests()
        {
            return DataBaseWorker.Instance.SelectAllTests();
        }

        private static String GetMd5Hash(string parInput)
        {
            var md5Hasher = MD5.Create();
            // Переводим вводимую строку в массив байтов и подсчитываем MD5
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(parInput));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }

        public static void Login(String parUserLogin, String parPassword)
        {
            var pass = GetMd5Hash(parPassword);
            user = DataBaseWorker.Instance.Login(parUserLogin, pass);
        }

        public static int AddNewUser(String parUserFio, String parPassword, String parUserLogin)
        {
            var pass1 = GetMd5Hash(parPassword);
            var res = DataBaseWorker.Instance.Login(parUserLogin, pass1);
            if (res == null)
            {
                DataBaseWorker.Instance.SaveUser(new User() { Fio = parUserFio, Status = false, pass = pass1, login = parUserLogin });
                return 0;
            }
            return 1;
        }

        public static List<TableNoEval> GetQuest(int parTestId)
        {
            return DataBaseWorker.Instance.GetTableNoEvals(parTestId);
        }

        public static TestFlow FillTest(int parTestId)
        {
            var res = GetQuest(parTestId);
            var questions = new List<Question>();
            List<Ansver> ansvers;
            var allQuests = new List<int>();
            var d = new DateTime();
            int trueAns = 0;
            int idq = 0;
            var alLquestions = res.Select(temp => temp.IDQuest).ToList();
            byte[] img = new byte[0];
            byte[] imgQuestion = new byte[0];
            allQuests.AddRange(alLquestions.Distinct());

            foreach (var q in allQuests)
            {
                ansvers = new List<Ansver>();
                foreach (var temp in res)
                {
                    if (q == temp.IDQuest)
                    {
                        var aa = new Ansver { ID = temp.AnsverID, Text = temp.Ansver };
                        ansvers.Add(aa);
                        trueAns = temp.TrueAns;
                        d = temp.Constraint;
                        idq = temp.IDQuest;
                        img = temp.Image;
                        imgQuestion = temp.QuestImage;

                    }
                }
                String name =
                      (from score in res
                       where score.IDQuest == q
                       select score.Quest).First();

                var question = new Question(ansvers, name, trueAns, img, imgQuestion) { ID = idq };
                questions.Add(question);
            }
            return new TestFlow(d, questions) { ID = parTestId };
        }

        public static void InsertResults(List<ResultRecord> parRes)
        {
            DataBaseWorker.Instance.InsertResults(parRes);
        }


        public static List<ResultView> GetResults(int parTestId, int parUserId)
        {
            var results = DataBaseWorker.Instance.GetResults(parTestId, parUserId);
            var res = new List<ResultView>();
            foreach (var oneResult in results)
            {
                var quest = DataBaseWorker.Instance.GetQuestById(oneResult.Quest);
                var answer = DataBaseWorker.Instance.GetAnswerById(oneResult.Ans);
                var sucess = oneResult.Ans == oneResult.Trues;

                if (quest != null && answer != null)
                {
                    var t = new ResultView
                    {
                        Quest = quest.Question,
                        Aansver = answer.Answer,
                        TrueOrfalse = sucess ? "+" : "-"
                    };

                    res.Add(t);
                }

            }
            return res;
        }

        public static void ClearResults(int parUserId, int parTestId)
        {
            DataBaseWorker.Instance.RemoveResults(parUserId, parTestId);
        }

        private static int InsertQuestion(string parQuestion, byte[] parImage, byte[] parImageQuest)
        {
            return DataBaseWorker.Instance.AddQuestion(new QuestionRecord() { Question = parQuestion, IamgeQuest = parImageQuest, Image = parImage });
        }

        private static int InsertAnsver(string parAnsver)
        {
            return DataBaseWorker.Instance.AddAnswer(new AnswerRecord() { Answer = parAnsver });
        }

        private static int InsertTask(int parIDQuest, int parIDAnsv, int parIDTrue)
        {
            TaskRecord record = new TaskRecord { AnsverID = parIDAnsv, QuestID = parIDQuest, TrueID = parIDTrue };
            return DataBaseWorker.Instance.AddTask(record);
        }

        private static int InsertTestInTable(string parName, DateTime parTimeConstraint)
        {
            TestRecord record = new TestRecord { Name = parName, TimeConstraint = parTimeConstraint };
            return DataBaseWorker.Instance.AddTest(record);
        }

        private static void InsertTaskTest(int parTestId, int parTaskId)
        {
            TaskTestRecord record = new TaskTestRecord() { Task = parTaskId, Test = parTestId };
            DataBaseWorker.Instance.AddTaskTest(record);
        }

        public static void DeleteTest(int parTestID)
        {
            // TODO !!!

            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "EXECUTE DELETETEST @TestID";
            //cmd.Parameters.Add("@TestID", SqlDbType.Int).Value = parTestID;
            //cmd.ExecuteNonQuery();
        }

        public static void InsertTest(BindingList<Question> test, String parName, DateTime parTimeConstraint)
        {
            // инициализиреем ID для последующей связи
            foreach (var quest in test)
            {
                quest.IDInTable = InsertQuestion(quest.Name, quest.Image, quest.QuestionImage);
                foreach (var ansver in quest.Ansvers)
                {
                    ansver.IDInTable = InsertAnsver(ansver.Text);
                    if (quest.TrueAnsverID == ansver.ID)
                        quest.TrueAnsverID = ansver.IDInTable;
                }
            }
            // Вставляем задания
            var tasksID = new List<int>();
            foreach (var quest in test)
            {
                foreach (var ansver in quest.Ansvers)
                {
                    tasksID.Add(
                    InsertTask(quest.IDInTable, ansver.IDInTable, quest.TrueAnsverID));
                }
            }

            // Вставляем тест
            int testID = InsertTestInTable(parName, parTimeConstraint);
            // Вписываем в тест задания.
            foreach (var id in tasksID)
                InsertTaskTest(testID, id);
        }

    }
}
