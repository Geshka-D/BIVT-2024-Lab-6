using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Purple_2
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private int _distance;
            private int[] _marks;
            
            public string Name => _name;
            public string Surname => _surname;
            public int Distance => _distance;
            public int[] Marks
            {
                get
                {
                    if (_marks == null) return default(int[]);
                    var newArray = new int[_marks.Length];
                    Array.Copy(_marks, newArray, _marks.Length);
                    return newArray;
                }
            }
            
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _distance = 0;
                _marks = new int[5];
            }
            public int Result
            {
                get
                {
                    if (_marks == null) return 0;
                    int sum = 0, max =-100000,min =100000;
                    for (int i = 0;i <_marks.Length; i++)
                    {
                        sum += _marks[i];
                        if (_marks[i] > max) max = _marks[i];
                        if (_marks[i] < min) min = _marks[i];
                    }
                    sum -= max + min;
                    if (_distance > 90)
                        sum += (_distance - 90) * 2;
                    return sum;
                }
            }
            public void Jump(int distance, int[] marks)
            {
                if (marks == null || marks.Length != 5 || _marks == null) return;
                _distance = distance;
                for (int i = 0; i < marks.Length; i++)
                    _marks[i] = marks[i];
            }
            public static void Sort(Participant[] array)
            {
                double[] sortarr = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                    sortarr[i] = array[i].Result;
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
                Console.WriteLine($"{Name} {Surname}: {Result}");
            }
        }
        
    }
}
