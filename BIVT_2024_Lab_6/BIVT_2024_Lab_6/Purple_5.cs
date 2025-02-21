﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static BIVT_2024_Lab_6.Purple_4;

namespace BIVT_2024_Lab_6
{
    internal class Purple_5
    {
        public struct Response
        {
            private string _animal;
            private string _charactertrait;
            private string _concept;
            
            public string Animal => _animal;
            public string CharacterTrait => _charactertrait;
            public string Concept => _concept;
            public Response(string animal, string charactertrait, string concept)
            {
                _animal = animal;
                _charactertrait = charactertrait;
                _concept = concept;
            }
            public int CountVotes(Response[] responses,int number)
            {
                if (responses.Length == 0 || responses == null || number < 1 || number > 3) return 0;
                int count = 0;
                for (int i = 0; i< responses.Length;i++)
                {
                    switch (number)
                    {
                        case 1:
                            {
                                if (responses[i].Animal != "" || responses[i].Animal != null)
                                    count++;
                                break;
                            }
                        case 2:
                            {
                                if (responses[i].CharacterTrait != "" || responses[i].CharacterTrait != null)
                                    count++;
                                break;
                            }
                        case 3:
                            {
                                if (responses[i].Concept != "" || responses[i].Concept != null)
                                    count++;
                                break;
                            }
                    }
                }
                return count;
            }
            public void Print()
            {
                    Console.WriteLine($"{Animal} {CharacterTrait} {Concept}");
            }
        }
        public struct Research
        {
            private string _name;
            private Response[] _responses;

            public string Name => _name;
            public Response[] Responses => _responses;

                
            
            public Research(string name)
            {
                _name = name;
                _responses = new Response[0];

            }
            public void Add(string[] answers)
            {
                if (_responses == null || answers.Length != 3) return;
                Response a = new Response(answers[0], answers[1], answers[2]);
                Array.Resize(ref _responses, _responses.Length + 1);
                _responses[_responses.Length - 1] = a;
            }
            public string[] GetTopResponses(int q)
            {
                if (_responses == null || q < 1 || q > 3) return null;
                string[] answerq = new string[0];
                int[] coutans = new int[0];
                string[] topresp;
                for (int i = 0; i < _responses.Length; i++)
                {
                    string ans = null;
                    switch (q)
                    {
                        case 1:
                            {
                                if (_responses[i].Animal != "-" && _responses[i].Animal != null)
                                    ans = _responses[i].Animal;
                                break;
                            }
                        case 2:
                            {
                                if (_responses[i].CharacterTrait != "-" && _responses[i].CharacterTrait != null)
                                    ans = _responses[i].CharacterTrait;
                                break;
                            }
                        case 3:
                            {
                                if (_responses[i].Concept != "-" && _responses[i].Concept != null)
                                    ans = _responses[i].Concept;
                                break;
                            }
                    }
                    if (ans != null)
                    {
                        if (answerq.Count(s =>s==ans) == 0)
                        {
                            Array.Resize(ref answerq, answerq.Length + 1);
                            answerq[answerq.Length - 1] = ans;
                            Array.Resize(ref coutans, coutans.Length + 1);
                            coutans[coutans.Length - 1] = 1;
                        }
                        else
                        {
                            coutans[Array.IndexOf(answerq, ans)]++;
                        }
                    }

                }
                if (answerq.Length >= 5)
                {
                    topresp = new string[5];

                    int k = 0;
                    for (int i = 0; i <5; i++)
                    {
                        int index = Array.IndexOf(coutans, coutans.Max());
                        topresp[k] = answerq[index];

                        k++;
                        string[] t1 = new string[answerq.Length - 1];
                        int[] t2 = new int[coutans.Length - 1];
                        for (int j =0; j< answerq.Length - 1; j++)
                        {
                            if (j >= index)
                            {
                                t1[j] = answerq[j + 1];
                                t2[j] = coutans[j + 1];
                            }
                            else
                            {
                                t1[j] = answerq[j];
                                t2[j] = coutans[j];
                            }
                        }
                        answerq = t1;
                        coutans = t2;
                    }
                    

                }
                else
                {
                    topresp = new string[answerq.Length];
                    for (int i = 0; i < answerq.Length; i++)
                    {
                        topresp[i] = answerq[i];

                    }
                }
                return topresp;
            }

            
        }
    }
}
