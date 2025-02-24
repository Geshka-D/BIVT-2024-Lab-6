using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Purple_4;

namespace Lab_6
{
    public class Purple_4
    {
        public struct Sportsman
        {
            private string _name;
            private string _surname;
            private double _time;
            public string Name => _name;
            public string Surname => _surname;
            public double Time => _time;
            private int f;
            public Sportsman(string name, string surname)
            {
                _name = name;
                _surname = surname;
                _time = 0;
                f = 0;
            }
            public void Run (double time)
            {
                if (f == 1) return;
                _time = time;
                f = 1;
            }
            public void Print()
            {
                Console.WriteLine($"{Name} {Surname}: {Time}");
            }
        }
        public struct Group
        {
            private string _name;
            private Sportsman[] _sportsmen;
            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsmen;
            public Group(string name)
            {
                _name = name;
                _sportsmen = new Sportsman[0];
            }
            public Group(Group group)
            {
                _name = group.Name;
                _sportsmen = group.Sportsmen;
            }
            public void Add(Sportsman sportsman)
            {
                var s = Sportsmen;
                if (s == null) return;
                _sportsmen = new Sportsman[s.Length + 1];
                Array.Copy(s, _sportsmen, s.Length);
                _sportsmen[s.Length] = sportsman;
            }
            public void Add(Sportsman[] sportsmen)
            {
                if (sportsmen == null) return;
                var s = Sportsmen;
                if (s == null) return;
                _sportsmen = new Sportsman[s.Length + sportsmen.Length];
                Array.Copy(s, _sportsmen, s.Length);
                Array.Copy(sportsmen, 0, _sportsmen, s.Length, sportsmen.Length);
            }
            public void Add(Group group)
            {
                if (group.Sportsmen == null) return;
                var s = Sportsmen;
                if (s == null) return;
                _sportsmen = new Sportsman[_sportsmen.Length + group.Sportsmen.Length];
                Array.Copy(s, _sportsmen, s.Length);
                Array.Copy(group.Sportsmen, 0, _sportsmen, s.Length, group.Sportsmen.Length);
            }
            public void Sort()
            {
                if (_sportsmen == null) return;
                for (int i = 0; i < Sportsmen.Length; i++)
                {
                    for (int j = 0; j < Sportsmen.Length - 1 - i; j++)
                    {
                        if (_sportsmen[j].Time > _sportsmen[j + 1].Time)
                        {
                            var temp = _sportsmen[j];
                            _sportsmen[j] = _sportsmen[j + 1];
                            _sportsmen[j + 1] = temp;
                        }
                    }
                }
            }
            public static Group Merge(Group group1, Group group2)
            {
                Group groupmerge = new Group("Ans");
                if (group1.Sportsmen == null && group2.Sportsmen == null) return group1;
                if (group2.Sportsmen == null) return group2;
                if (group2.Sportsmen == null) return group1;
                groupmerge._sportsmen = new Sportsman[group1.Sportsmen.Length + group2.Sportsmen.Length];
                int i1 = 0, i2 = 0, k = 0;
                while (group1.Sportsmen.Length > i1 && group2.Sportsmen.Length> i2)
                {
                    if (group1.Sportsmen[i1].Time < group2.Sportsmen[i2].Time)
                    {
                        groupmerge._sportsmen[k] = group1.Sportsmen[i1];
                        i1++;k++;
                    }
                    else
                    {
                        groupmerge._sportsmen[k] = group2.Sportsmen[i2];
                        i2++; k++;
                    }
                }
                while (group1.Sportsmen.Length > i1)
                {
                    groupmerge._sportsmen[k] = group1.Sportsmen[i1];
                    i1++; k++;
                }
                while (group2.Sportsmen.Length > i2)
                {
                    groupmerge._sportsmen[k] = group2.Sportsmen[i2];
                    i2++; k++;
                }
                return groupmerge;
            }
            public void Print()
            {
                foreach (var sportsmen in _sportsmen)
                {
                    Console.WriteLine($"{sportsmen.Name} {sportsmen.Surname}: {sportsmen.Time}");
                }
            }
        }
    }  
}
