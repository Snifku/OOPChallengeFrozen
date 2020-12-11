using System;
using System.Collections.Generic;
using System.IO;

namespace OOPChallangeFrozen
{
    class Program
    {

        class Frozen
        {

            string character;
            string title;

            public Frozen(string _title, string _character)
            {
                character = _character;
                title = _title;

            }

            public string Character { get { return character; } }
            public string Title { get { return title; } }


        }

        class FrozenList
        {
            List<Frozen> frozens;


            public FrozenList()
            {
                frozens = new List<Frozen>();
            }


            public void AddFrozentoList(string title, string character)
            {
                Frozen newFrozen = new Frozen(title, character);
                frozens.Add(newFrozen);
            }

            public void PrintAllFrozen()
            {
                foreach (Frozen character in frozens)
                {
                    Console.WriteLine($"{character.Character} wants {character.Title} for christmas ");
                }
            }

        }


        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\";
            string fileName = @"frozenl.txt";
            string fullFilePath = Path.Combine(filePath, fileName);

            
            string[] linesFromfile = File.ReadAllLines(fullFilePath);
            
            FrozenList myFrozens = new FrozenList();
            foreach (string line in linesFromfile)
            {
                
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                string frozenTitle = tempArray[1];
                string frozenCharacter = tempArray[0];

                
                myFrozens.AddFrozentoList(frozenTitle, frozenCharacter);
            }
            myFrozens.PrintAllFrozen();
        }
    }
}