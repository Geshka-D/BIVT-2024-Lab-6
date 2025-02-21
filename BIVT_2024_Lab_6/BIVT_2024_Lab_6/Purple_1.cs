using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BIVT_2024_Lab_6
{
    internal class Purple_1
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _coefs;
            private int[,] _marks;
            private int indexJumper;
            public string Name => _name;
            public string Surname => _surname;
            public double[] Coefs
            { get
                {
                    if (_coefs == null) return default(double[]);
                    var newArray = new double[_coefs.Length];
                    Array.Copy(_coefs, newArray, _coefs.Length);
                    return newArray;
                }
            }
            public int[,] Marks
            {
                get
                {
                    if (_marks == null) return default(int[,]);
                    var newMatrix = new int[_marks.GetLength(0),_marks.GetLength(1)];
                    Array.Copy(_marks, newMatrix, _marks.Length);
                    return newMatrix;
                }
            }
            public double TotalScore
            {
                get
                {
                    if (_marks == null || _coefs == null) return 0;
                    double tsum = 0;
                    
                    for (int i = 0; i < _marks.GetLength(0); i++)
                    {
                        int sum = 0, max = -100000, min = 100000;
                        for (int j =0; j< _marks.GetLength(1);j++)
                        {
                            sum += _marks[i, j];
                            if (_marks[i, j] > max) max = _marks[i, j];
                            if (_marks[i, j] < min) min = _marks[i, j];
                        }
                        sum -= max + min;
                        tsum += sum * _coefs[i];
                    }
                    
                    return tsum;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _coefs = new double[] { 2.5, 2.5, 2.5, 2.5 };
                _marks = new int[4, 7];
                indexJumper = 0;
            }
            public void SetCriterias(double[] coefs)
            {
                if (coefs == null || _coefs == null || coefs.Length != 4) return;
                for (int i = 0; i < 4; i++)
                    if (coefs[i] > 3.5 || coefs[i] < 2.5) return;
                for (int i = 0; i < 4; i++)
                    _coefs[i] = coefs[i];
            }
            public void Jump(int[] marks)
            {
                if (marks == null || _marks == null || marks.Length != 7) return;
                for (int i = 0; i < marks.Length; i++)
                {
                    _marks[indexJumper, i] = marks[i];
                    
                }
                indexJumper++;
            }

            public static void Sort(Participant[] array)
            {
                double[] sortarr = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                    sortarr[i] = array[i].TotalScore;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (sortarr[j] < sortarr[j + 1])
                        {
                            double temp = sortarr[j];
                            sortarr[j] = sortarr[j + 1];
                            sortarr[j + 1] = temp;
                            Participant t = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = t;
                        }
                    }
                }

            }
            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {TotalScore}");
            }
        }
       

    }
}
