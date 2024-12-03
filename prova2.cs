using System;

class prova2
{
    static void Main()
    {
        unsafe
        {
            int i = 6;
            int m = 6;
            int* puntatore = &m;  // Dichiarazione del puntatore
            int* puntatore2 = &i;

            // Stampa dell'indirizzo di memoria a cui punta il puntatore
            Console.WriteLine((IntPtr)puntatore);  // Usato IntPtr per stampare l'indirizzo
            Console.WriteLine(*puntatore + "\n");         // Dereferenziamento per stampare il valore a cui punta
            Console.WriteLine((IntPtr)puntatore2);  // Usato IntPtr per stampare l'indirizzo
            Console.WriteLine(*puntatore2);
        }
    }
}