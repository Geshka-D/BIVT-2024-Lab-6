using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace BIVT_2024_Lab_6
{
    internal class Purple_3
    {
        public struct Participant
        {
            private string _name;
            private string _surname;
            private double[] _marks;
            private int[] _places;
            private int index;
            public string Name => _name;
            public string Surname => _surname;
            public int[] Places
            {
                get
                {
                    if (_places == null) return default(int[]);
                    var newArray = new int[_places.Length];
                    Array.Copy(_places, newArray, _places.Length);
                    return newArray;
                }
            }
            public double[] Marks
            {
                get
                {
                    if (_marks == null) return default(double[]);
                    var newArray = new double[_marks.Length];
                    Array.Copy(_marks, newArray, _marks.Length);
                    return newArray;
                }
            }
            public int Score
            {
                get
                {
                    if (_places == null || _marks == null) return 0;
                    int score = 0;
                    for (int i = 0; i < _places.Length; i++)
                    {
                        score += _places[i];
                        
                    }
                    
                    return score;
                }
            }
            public double TotalMark
            {
                get
                {
                    if (_places == null || _marks == null) return 0;
                    double t = 0;
                    for (int i = 0; i < _marks.Length; i++)
                        t += _marks[i];
                    return t;
                }
            }
            public Participant(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _places = new int[7];
                _marks = new double[7];
                index = 0;
            }
            public void Evaluate(double result)
            {
                if (_marks == null) return;
                _marks[index] = result;
                index++;
            }
            public static void SetPlaces(Participant[] participants)
            {
                for (int i = 0; i < participants[0].Places.Length; i++)
                {
                    for (int j = 0; j < participants.Length; j++)
                    {
                        double min = participants[j].Marks[i];
                        int ind = j;
                        for (int k = j + 1; k < participants.Length; k++)
                        {
                            if (participants[k].Marks[i] < min)
                            {
                                min = participants[k].Marks[i];
                                ind = k;
                            }
                        }
                        Participant temp = participants[j];
                        participants[j] = participants[ind];
                        participants[ind] = temp;
                    }
                    for (int k = 0; k < participants.Length; k++)
                        participants[k]._places[i] = participants.Length - k;
                }


            }
            public static void Sort(Participant[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        SortPlaces(array[j]);
                        SortPlaces(array[j + 1]);
                        if (SumP(array[j]) > SumP(array[j + 1]))
                        {
                            Participant temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                        else if (SumP(array[j]) == SumP(array[j + 1]))
                        {


                            if (array[j].Places[0] > array[j + 1].Places[0])
                            {
                                Participant temp = array[j];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }

                            else if (array[j].Places[0] == array[j + 1].Places[0])
                            {
                                if (SumM(array[j]) > SumM(array[j + 1]))
                                {
                                    Participant temp = array[j];
                                    array[j] = array[j + 1];
                                    array[j + 1] = temp;

                                }
                            }

                        }
                    }

                }

            }

            private static void SortPlaces(Participant a)
            {
                for (int i = 0; i < a.Places.Length; i++)
                {
                    for (int j = 0; j < a.Places.Length - 1 - i; j++)
                    {
                        if (a.Places[j] > a.Places[j + 1])
                        {
                            int temp = a._places[j];
                            a._places[j] = a._places[j + 1];
                            a._places[j + 1] = temp;
                        }
                    }
                }
            }
            private static int SumP(Participant a)
            {
                int sum = 0;
                for (int i = 0; i < a.Places.Length; i++)
                    sum += a.Places[i];
                return sum;
            }
            private static double SumM(Participant a)
            {
                double sum = 0;
                for (int i = 0; i < a.Marks.Length; i++)
                    sum += a.Marks[i];
                return sum;
            }
            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {Score} {Places[0]} {TotalMark}");
            }
        }
    }
        
        
        
}
