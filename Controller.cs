using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Controller : Session
    {
        public Session ses1 = new Session();
        public Controller(Session ses1)
        {
            this.ses1 = ses1;
        }
        public void MinGradExam()
        {
            int GradExam = 0;
            int el = 0;
            for (int i = 0; i < ses1.Session1.Count; i++)
            {
                if (GradExam > ses1.Session1[i].GradExam)
                {
                    GradExam = ses1.Session1[i].GradExam;
                    el = i;
                }
            }
            Console.WriteLine($"Component whith a minimal GradExam : {ses1.Session1[el].GradExam}  is ");
            ses1.Session1[el].Show();
        }
        public void Sort()
        {
            Isp temp;
            for (int i = 0; i < ses1.Session1.Count - 1; i++)
            {
                for (int j = i + 1; j < ses1.Session1.Count; j++)
                {
                    if (ses1.Session1[i].GradExam > ses1.Session1[j].GradExam)
                    {
                        temp = ses1.Session1[i];
                        ses1.Session1[i] = ses1.Session1[j];
                        ses1.Session1[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sort : ");
            for (int f = 0; f < ses1.Session1.Count; f++)
            {
                ses1.Session1[f].Show();
            }
        }
        //кол-во всех испытаний
        public int GetCount()
        {
            return ses1.Session1.Count;
        }
        //кол-во тестов с заданным числом вопросов
        public int GetTestCount(int qCount)
        {
            return ses1.Session1.Count(isp => isp is Test && ((Test)isp).Questions.Count == qCount);
        }

        public Isp this[int index]//generates WrongIndexException(Неверное исключение индекса)
        {
            get
            {
                if (index > ses1.Session1.Count || index < 0)
                {
                    throw new WrongIndexException(index<0 ? $"{nameof(index)} mast not be < 0." : $"{nameof(index)} mast not be > then count of collection.");
                }
                return Session1[index];
            }
        }
    }
}
