using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOP
{
    class Student: Person
    {
        private int _mathGrade;
        private int _physicsGrade;
        private int _historyGrade;

        public Student(int mathGrade, int physicsGrade, int historyGrade)
        {
            _mathGrade = mathGrade;
            _physicsGrade = physicsGrade;
            _historyGrade = historyGrade;
        }
        public float AverageScoreSession()
        {
            return (_mathGrade + _historyGrade + _physicsGrade) / 3;
        }
        public override int Info()
        {
            return Math.Max(Math.Max(_mathGrade, _physicsGrade), _historyGrade);
        }
    }
}
