using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrazione_numeri_e_aggiornamento_tabellone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INIZIO CODICE
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - "IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI".Length) / 3, 0);
            Console.WriteLine("IL GIOCO DELLA TOMBOLA PER 2 GIOCATORI");
            Console.WriteLine("- ");

            //funzione random
            Random random = new Random();

            //generazione delle due cartelle

            //1 dichiarazione delle due cartelle
            int[,] cartella1 = new int[3, 9];

            //lista che permette di non far rigenerare un numero due volte
            List<int> numeri = new List<int>();

            //generazione 1 cartella
            Console.WriteLine(" CARTELLA PRIMO GIOCATORE ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella1[i, j] = num;
                }
            }

            //ciclo for per test dei valori1 e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //generazione 2 cartella
            Console.WriteLine("- ");
            Console.WriteLine(" CARTELLA SECONDO GIOCATORE ");
            int[,] cartella2 = new int[3, 9];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num;
                    do
                    {
                        num = random.Next(1, 91);
                    } while (numeri.Contains(num));
                    numeri.Add(num);
                    cartella2[i, j] = num;
                }
            }

            //ciclo for per test dei valori1 e per posizionarli in righe e colonne
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(cartella2[i, j] + " ");
                }
                Console.WriteLine();
            }







            //generazione del tabellone del tabellone 

            Console.WriteLine("- ");
            Console.WriteLine("TABELLONE ");
            //dichiarazione tabellone
            int[,] tabellone = new int[9, 10];

            //stampa tabellone
            StampaTabellone(tabellone); //semplificazione del codice con funzione







            //2 estrazione numeri

            Console.WriteLine("ESTRAZIONE NUMERI TOMBOLA");
            // Crea una lista per memorizzare i numeri estratti
            List<int> numeriEstratti = new List<int>();
            //dichiarazione variabili numeri tabellone
            int riga = 0;
            int colonna = 0;


            while (true)
            {
                // Aspetta che l'utente prema il tasto Invio
                Console.ReadLine();

                // Genera un numero casuale compreso tra 1 e 90
                int numeriRandom = random.Next(1, 91);

                // Verifica se il numero è già stato estratto
                if (numeriEstratti.Contains(numeriRandom))
                {
                    // Se il numero è già stato estratto, genera un altro numero
                    continue;
                }

                // Se il numero non è stato ancora estratto, lo aggiunge alla lista
                numeriEstratti.Add(numeriRandom);










                // inserimento numero nel tabellone
                //3 mostrare il tabellone aggiornato
                tabellone[riga, colonna] = numeriRandom;
                colonna++;
                if (colonna == 10)
                {
                    colonna = 0;
                    riga++;
                }
                StampaTabellone(tabellone); //semplifica codice
            }


        }





        //funzione per ottimizzare il codice
        private static void StampaTabellone(int[,] tabellone)
        {
            //generazione tabellone aggiornato
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tabellone[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
