using System;

namespace aVideoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Joueur2 = new Character();
            Character Joueur1 = new Character();

            Joueur1.nameOfPerso = "Naim";
            Joueur1.life = 120;
            Joueur1.defense = 10;
            Joueur1.force = 20;

            Joueur2.nameOfPerso = "Bibi";
            Joueur2.life = 150;
            Joueur2.defense = 10;
            Joueur2.force = 40;


            while (Joueur1.life > 0 && Joueur2.life > 0)
            {
                Joueur2.Attack(Joueur1);
                Joueur1.Attack(Joueur2);
            }

            if (Joueur1.life == 0 | Joueur1.life < 0)
            {
                Joueur1.IsAlive();
            }
            else if (Joueur2.life == 0 | Joueur2.life < 0)
            {
                Joueur2.IsAlive();
            }







        }

        public class Character
        {

            public string nameOfPerso;
            public int life;
            public int force;
            public int defense;





            public bool IsAlive()
            {
                bool isAlive;

                if (life == 0 | life <0)
                {

                    isAlive = false;
                    Console.WriteLine("Le joueur est dead!!");
                }
                else
                {
                    isAlive = true;
                    Console.WriteLine("Le joueur est Alive!!");
                }

                return isAlive;
            }

            public void Attack(Character J2)

            {
                J2.life = J2.life - (force - J2.defense);
                Console.WriteLine("Attaque lancé, Il lui reste "+J2.life+" vies à "+J2.nameOfPerso);

            }


        }
    }

        }

