using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scramblr
{
    class Question
    {
        string question;
        string answer1;
        string answer2;
        string answer3;
        string answer4;
        string answer5;

        public Question(string q, string a1, string a2, string a3, string a4, string a5)
        {
            question = q;
            answer1 = a1;
            answer2 = a2;
            answer3 = a3;
            answer4 = a4;
            answer5 = a5;
        }

        public string getQuestion() { return question; }
        public string getA1() { return answer1; }
        public string getA2() { return answer2; }
        public string getA3() { return answer3; }
        public string getA4() { return answer4; }
        public string getA5() { return answer5; }

    }
}
