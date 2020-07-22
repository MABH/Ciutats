using System;

namespace Ciutats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            string ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6;

            Console.WriteLine("Introduce la ciudad 1: ");
            ciutat1 = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad 2: ");
            ciutat2 = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad 3: ");
            ciutat3 = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad 4: ");
            ciutat4 = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad 5: ");
            ciutat5 = Console.ReadLine();
            Console.WriteLine("Introduce la ciudad 6: ");
            ciutat6 = Console.ReadLine();

            Console.WriteLine("Las ciudades introducidas son: " + ciutat1 + ", " + ciutat2 + ", " + ciutat3 + ", " + ciutat4 + ", " + ciutat5 + ", " + ciutat6);
            Console.WriteLine(" ");

            // Fase2
            string[] ciutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };
            string[] ciutatsModificades = ciutats;

            int compare;
            string temp; 

            // Ordenem l'array
            for (int i=0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    compare = string.Compare(ciutatsModificades[i], ciutatsModificades[j], true);
                    if (compare <0)
                    {
                        temp = ciutatsModificades[i];
                        ciutatsModificades[i] = ciutatsModificades[j];
                        ciutatsModificades[j] = temp;
                    }
                }
            }

            //Lo mostramos por pantalla
            foreach(string value in ciutatsModificades)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(" ");

            //Fase 3
            int maxLong=0;

            foreach (string value in ciutats)
            {
                if (value.Length > maxLong) maxLong = value.Length; //Obtenemos la longitud máxima de las ciudades para inicializar el array de chars
            }

            char[] cadena = new char[maxLong];
            
            for (int index1 = 0; index1 < ciutats.Length; index1++)
            {
                cadena = ciutats[index1].ToCharArray();
                for (int index2 = 0; index2 < ciutats[index1].Length; index2++) //recorremos el char array hasta la longitud de la ciudad actual
                {
                    if (cadena[index2] == 'a')
                    {
                        cadena[index2] = '4';
                    }
                }
                ciutats[index1] = new string(cadena);
            }

            //Volvemos a ordenar el array
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    compare = string.Compare(ciutatsModificades[i], ciutatsModificades[j], true);
                    if (compare < 0)
                    {
                        temp = ciutatsModificades[i];
                        ciutatsModificades[i] = ciutatsModificades[j];
                        ciutatsModificades[j] = temp;
                    }
                }
            }

            foreach (string value in ciutatsModificades)
            {
                Console.WriteLine(value);
            }

            //Creamos los arrays con la longitud correspondiente a cada ciudad
            char[] char1 = new char[ciutat1.Length],
                   char2 = new char[ciutat2.Length],
                   char3 = new char[ciutat3.Length],
                   char4 = new char[ciutat4.Length],
                   char5 = new char[ciutat5.Length],
                   char6 = new char[ciutat6.Length];
                     
            for (int indice=0; indice< maxLong; indice++) //Se introducen los valores uno a uno 
            {
                if (indice < ciutat1.Length)             //Limitamos los caracteres a las longitudes de cada string
                    char1[indice] = ciutat1[indice];
                if (indice < ciutat2.Length)
                    char2[indice] = ciutat2[indice];
                if (indice < ciutat3.Length)
                    char3[indice] = ciutat3[indice];
                if (indice < ciutat4.Length)
                    char4[indice] = ciutat4[indice];
                if (indice < ciutat5.Length)
                    char5[indice] = ciutat5[indice];
                if (indice < ciutat6.Length)
                    char6[indice] = ciutat6[indice];                
            }

            //Se muestran los chars en orden inverso
            Console.WriteLine("");
            for (int indice = char1.Length - 1; indice >= 0; indice--)
            {
                Console.Write(char1[indice]);
            }
            Console.WriteLine("");
            for (int indice= char2.Length-1; indice>=0; indice-- )
            {
                Console.Write(char2[indice]);
            }
            Console.WriteLine("");
            for (int indice = char3.Length - 1; indice >= 0; indice--)
            {
                Console.Write(char3[indice]);
            }
            Console.WriteLine("");
            for (int indice = char4.Length - 1; indice >= 0; indice--)
            {
                Console.Write(char4[indice]);
            }
            Console.WriteLine("");
            for (int indice = char5.Length - 1; indice >= 0; indice--)
            {
                Console.Write(char5[indice]);
            }
            Console.WriteLine("");
            for (int indice = char6.Length - 1; indice >= 0; indice--)
            {
                Console.Write(char6[indice]);
            }
            Console.WriteLine("");

        }
    }
}
