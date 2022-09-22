using System;
using System.Collections;

namespace TPClass
{
    public class Pokemon
    {
        //Attributs
        private ArrayList lstDresseur;
        private ArrayList lstType;
        private ArrayList lstLocalisation;
        private ArrayList lstAttaque;
        private int numero;
        private string nom;
        private string description;
        private int niveau;

        //constructeur
        public Pokemon(int numero, string nom, string description, int niveau)
        {
            this.numero = numero;
            this.nom = nom;
            this.description = description;
            this.niveau = niveau;
            this.lstDresseur = new ArrayList();
            this.lstType = new ArrayList();
            this.lstLocalisation = new ArrayList();
            this.lstAttaque = new ArrayList();
        }
        //accesseurs
        public int GetNumero()
        {
            return this.numero;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public double GetNiveau()
        {
            return this.niveau;
        }
        public ArrayList GetLstDresseur()
        {
            return this.lstDresseur;
        }
        public ArrayList GetLstType()
        {
            return this.lstType ;
        }
        public ArrayList GetLstLocalisation()
        {
            return this.lstLocalisation;
        }
        public ArrayList GetLstAttaque()
        {
            return this.lstAttaque;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public void SetNiveau(int niveau)
        {
            this.niveau = niveau;
        }

        //ToString() pour l'affichage de chaque attributs
        public string ToString()
        {
            string strRetour = "";
            strRetour = "\nNumero : " + this.numero + "\nnom : " + this.nom + "\ndescription : " + this.description + "\nniveau : " + this.niveau + "\n";
            foreach (Dresseur unDresseur in lstDresseur)
            {
                strRetour += lstDresseur.ToString();
            }
            foreach (Type unType in lstType)
            {
                strRetour += lstType.ToString();
            }
            foreach (Localisation uneLocalisation in lstLocalisation)
            {
                strRetour += lstLocalisation.ToString();
            }
            foreach (Attaque uneAttaque in lstAttaque)
            {
                strRetour += lstAttaque.ToString();
            }
            return strRetour;
        }
        public void MAJLocalisation(Localisation local)
        {
            if(this.lstLocalisation.Contains(local) == false)
                {
                    this.lstLocalisation.Add(local);
                }
        }

    }
    public class Dresseur
    {
        //Attributs
        private ArrayList lstPokemon;
        private int id;
        private string nom;
        private double tempsdejeu;

        //constructeur
        public Dresseur(int id, string nom, double tempsdejeu)
        {
            this.id = id;
            this.nom = nom;
            this.tempsdejeu = tempsdejeu;
            this.lstPokemon = new ArrayList();
        }
        //accesseurs
        public int GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public double GetTempsDeJeu()
        {
            return this.tempsdejeu;
        }
        public ArrayList GetLstPokemon()
        {
            return this.lstPokemon;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public void SetTempsDejeu(double tempsdejeu)
        {
            this.tempsdejeu = tempsdejeu;
        }

        //ToString() pour l'affichage de chaque attributs | Methode
        public override string ToString()
        {
            string strRetour = "";
            strRetour = "\nid : " + this.id + "\nnom : " + this.nom + "\ntempsdejeu : " + this.tempsdejeu + "\nEquipes : " + "\n";
            foreach (Pokemon unPokemon in lstPokemon)
            {
                strRetour += unPokemon.ToString();
            }
            return strRetour;
        }
        public bool AjoutPokemon(Pokemon pkm)
        {
            if (GetLstPokemon().Count < 6)
            {
                this.lstPokemon.Add(pkm);
                return true;
            }
            return false;

        }
        public bool RemplacePokemon(int numero, Pokemon pkm)
        {
            foreach (Pokemon unPokemon in lstPokemon)
            {
                if (unPokemon.GetNumero() == numero)
                {
                    this.lstPokemon.Remove(unPokemon);
                    AjoutPokemon(pkm);
                    return true;
                }
            }
            return false;
        }
        public bool SupprimePokemon(int numero, Pokemon pkm)
        {
            foreach (Pokemon unPokemon in lstPokemon)
            {
                if (unPokemon.GetNumero() == numero)
                {
                    this.lstPokemon.Remove(unPokemon);
                    return true;
                }
            }
            return false;
        }
    }
        public class Type
    {
        //Attributs
        private ArrayList lstPokemon;
        private int id;
        private string nom;

        //constructeur
        public Type(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
            this.lstPokemon = new ArrayList();
        }
        //accesseurs
        public int GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public ArrayList GetLstPokemon()
        {
            return this.lstPokemon;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        //ToString() pour l'affichage de chaque attributs | Methode
        public override string ToString()
        {
            string strRetour = "";
            strRetour = "\nid : " + this.id + "\nnom : " + this.nom;
            return strRetour;
        }
    }
    public class Localisation
    {
        //Attributs
        private ArrayList lstPokemon;
        private int numero;
        private string nom;
        private double frequence;

        //constructeur
        public Localisation(int numero, string nom, double frequence)
        {
            this.numero = numero;
            this.nom = nom;
            this.frequence = frequence;
            this.lstPokemon = new ArrayList();
        }
        //accesseurs
        public int GetNumero()
        {
            return this.numero;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public double GetFrequence()
        {
            return this.frequence;
        }
        public ArrayList GetLstPokemon()
        {
            return this.lstPokemon;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public void SetFrequence(double frequence)
        {
            this.frequence = frequence;
        }

        //ToString() pour l'affichage de chaque attributs | Methode
        public override string ToString()
        {
            string strRetour = "";
            strRetour = "\nnumero : " + this.numero + "\nnom : " + this.nom + "\nfrequence : " + this.frequence;
            return strRetour;
        }
    }
    public class Attaque
    {
        //Attributs
        private ArrayList lstPokemon;
        private int numero;
        private string nom;
        private string effet;
        private int PP;

        //constructeur
        public Attaque(int numero, string nom, string effet, int PP)
        {
            this.numero = numero;
            this.nom = nom;
            this.effet = effet;
            this.PP = PP;
            this.lstPokemon = new ArrayList();
        }
        //accesseurs
        public int GetNumero()
        {
            return this.numero;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public string GetEffet()
        {
            return this.effet;
        }
        public int GetPP()
        {
            return this.PP;
        }
        public ArrayList GetLstPokemon()
        {
            return this.lstPokemon;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public void SetEffet(string effet)
        {
            this.effet = effet;
        }
        public void SetPP(int PP)
        {
            this.PP = PP;
        }

        //ToString() pour l'affichage de chaque attributs | Methode
        public override string ToString()
        {
            string strRetour = "";
            strRetour = "numero : " + this.numero + "\nnom : " + this.nom + "\neffet : " + this.effet + "\nPP : " + this.PP;
            return strRetour;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon unPokemon;
            unPokemon = new Pokemon(1, "Darkrai", "Pokemon sombre", 77);
            Dresseur unDresseur;
            unDresseur = new Dresseur(1, "Distrib", 151);

            Pokemon unPokemon2;
            unPokemon2 = new Pokemon(2, "Pikachu", "Pokemon Electrique", 66);

            Pokemon unPokemon3;
            unPokemon3 = new Pokemon(3, "Lucario", "Pokemon Combat", 72);

            Pokemon unPokemon4;
            unPokemon4 = new Pokemon(4, "Ludicolo", "Sombrero", 50);

            Pokemon unPokemon5;
            unPokemon5 = new Pokemon(5, "Momartil", "Fé froid", 80);

            Pokemon unPokemon6;
            unPokemon6 = new Pokemon(6, "Onix", "Pokemon Sol", 63);

            Pokemon unPokemon7;
            unPokemon7 = new Pokemon(7, "Wailord", "Sous l'océan...", 99);

            /*for(int i = 0; i < 5; i++) { 
                if (unDresseur.AjoutPokemon(unPokemon) == false)
                {
                    Console.WriteLine("Equipe pleine");
                }
            }*/
            unDresseur.AjoutPokemon(unPokemon);
            unDresseur.AjoutPokemon(unPokemon2);
            unDresseur.AjoutPokemon(unPokemon3);
            unDresseur.AjoutPokemon(unPokemon4);
            unDresseur.AjoutPokemon(unPokemon5);
            unDresseur.AjoutPokemon(unPokemon6);
            unDresseur.AjoutPokemon(unPokemon7); //Ne le rajoute pas
            unDresseur.RemplacePokemon(6, unPokemon7); //Remplace le pkm 6 par le 7
            unDresseur.SupprimePokemon(5, unPokemon5); // Supprime le pkm 5
            Console.WriteLine("\n=====POKEMON=====");
            Console.WriteLine(unPokemon.ToString());
            Console.WriteLine(unPokemon2.ToString());
            Console.WriteLine(unPokemon3.ToString());
            Console.WriteLine(unPokemon4.ToString());
            Console.WriteLine(unPokemon5.ToString());
            Console.WriteLine(unPokemon6.ToString());
            Console.WriteLine(unPokemon7.ToString());
            Console.WriteLine("\n=====DRESSEUR=====");
            Console.WriteLine(unDresseur.ToString());



        }
    }
}
