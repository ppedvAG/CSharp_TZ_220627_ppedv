﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //KLASSEN sind Vorlagen für Objekte. Sie bestimmen Eigenschaften und Funktionen dieser.
    public abstract class Lebewesen //zur Verwendung vgl. Program.cs
    {
        #region Felder und Eigenschaften
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private string name = "Hugo";
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        //Snippet: propfull
        public string Name
        {
            get { return name; }
            set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value.Length > 0)
                    name = value;
            }
        }

        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        //Snippet: prop
        public string Lieblingsnahrung { get; set; }

        //Property, welche einen komplexen Datentypen abbildet
        public DateTime Geburtsdatum { get; set; }
        //Read-only Property mit Rückbezug auf andere Property
        public int Alter
        {
            get { return ((DateTime.Now - this.Geburtsdatum).Days / 365); }
        }
        #endregion

        #region Konstruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Lebewesen(string name, string lieblingsnahrung, DateTime geburtsdatum)
        {
            this.Name = name;
            this.Lieblingsnahrung = lieblingsnahrung;
            this.Geburtsdatum = geburtsdatum;

            Lebewesen.AnzahlLebewesen++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        public Lebewesen()
        {

        }
        #endregion

        #region Methoden

        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell mit diesem Objekt interagiert
        //public Lebewesen GebäreKind(string kindname)
        //{
        //    return new Lebewesen(kindname, "Muttermilch", DateTime.Now);
        //}

        #endregion       

        #region Destruktor

        //Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn das Objekt nicht
        //mehr referenziert ist. Hier können Aktionen definiert werden,
        //welche zusätzlich zur 'Zerstörung' erfolgen sollen.
        ~Lebewesen()
        {
            Console.WriteLine($"{this.Name} ist gestorben.");
            AnzahlLebewesen--;
        }

        #endregion 

        #region Statische Member

        //STATISCHE Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten. Sie existieren demnach unabhängig von der Anzahl
        ///der Objekte genau einmal. Der Aufruf erfolgt über den Klassenbezeichner.
        public static int AnzahlLebewesen { get; set; } = 0;

        public static string ZeigeAnzahlLebewesen()
        {
            return $"Es gibt {AnzahlLebewesen} Lebewesen.";
        }

        #endregion


        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        public override string ToString()
        {
            return $"{this.Name} ist {this.Alter} Jahre alt und mag gerne {this.Lieblingsnahrung}.";
        }

        //Abstrakte Methoden dürfen nur in abstrakten Klassen existieren und definieren nur
        ///eine Signatur. Die erbenden Klassen werden gezwungen eine Implementierung vorzunehmen
        public abstract void Essen();
    }
}
