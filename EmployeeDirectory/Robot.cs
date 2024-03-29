﻿using System;

namespace EmployeeDirectory
{
    //Publik synlig för alla, Internal synlig inne i den här Assemblyn (Det här programmet)
    public class Robot
    {
        //Struktur på en klass
        // 1. privata fält
        // 2. publika properties (privata properties make no sense)
        // 3. Konstruktor/Konstruktorer
        // 4. Metoder


        // private string name;

        //1. privata fält
        //private enbart tillgängligt inne i den här klassen!
        //Sätts här vi det publika propertyt
        private int height;

        //Exempel på publikt fält. OBS! Använd property istället
        //public int Height;

        //2. Publika properties
        //När vi försöker sätta ett värde (set) till height så kastar vi ett undantag (exception) om värdet är lägre än 0.
        //Returnerar alltid värdet på det bakomliggande privata fältet (get)
        //Snippet propfull för att skapa ett property med bakomliggande fält.
        public int Height
        {
            
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(Height));
                }
                else
                {
                    height = value;
                }
            }
        }

        //Autoproperty om du inte behöver validera eller göra något, dvs skriva kod i gettern eller settern
        //Använd den här syntaxen istället för publika fält!
        //Snippet prop
        public string Name { get; set; }

        //3. Konstruktor
        //Snippet ctor
        //Det här en default konstruktor den finns även om den inte syns. Tills man skapar en annan konstuktor. Då måste man skriva ut den manuellt för att få tillgång till den.
        //public Robot()
        //{

        //}


        //Konstruktor med en parameter
        //En konstruktor har aldrig någon retur typ och heter samma sak som klassen
        //Konstruktorn körs direkt när man skapar ett ny instans av klassen med nyckelordet new
        //Tex Robot robot = new Robot("Kalle");
        //Nu måste vi alltid skicka med ett namn för att få skapa en ny Robot
        public Robot(int height, string name)
        {
            Height = height;
            Name = name;
        }

        //4. Metoder
        //Så här gör man oftast i andra språk tex Java.
        //I C# används nästan alltid properties istället om det inte är så att det är mer komplex logik.
        //Tex att man anropar andra metoder och klasser.

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{

        //    //Validate
        //    name = newName;
        //}
    }
}