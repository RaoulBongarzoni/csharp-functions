namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Benvenuto ---");
            Console.WriteLine("-- scegli cosa vedere:\n - (1) : esercizio principale\n - (2) : esercizio extra bonus ");
            int optionSelection = Convert.ToInt32(Console.ReadLine());



            switch (optionSelection)
            {
                case (1):
                    {

                        Console.WriteLine("--- quanti elementi vuoi inserire nell'array? ---");
                        int arraylenght = Convert.ToInt32(Console.ReadLine());

                        int[] arrayTest = new int[arraylenght];


                        for (int j = 0; j < arraylenght; j++)
                        {
                            Console.WriteLine($"inserisci dato della {j} cella:");
                            arrayTest[j] = Convert.ToInt32(Console.ReadLine()); ;

                        }



                        int[] arrayTest2 = ElevaArrayAlQuadrato(arrayTest);


                        Console.WriteLine($" -- L'array originale è ");
                        StampaArray(arrayTest);
                        Console.WriteLine($" -- L'array al quadrato è ");
                        StampaArray(arrayTest2);


                        Console.WriteLine($" -- verifica cambiamento array originale ");
                        StampaArray(arrayTest);


                        int sum = sommaElementiArray(arrayTest);
                        Console.WriteLine($" -- La somma degi elementi nell'array base è {sum} ");
                        double sumSquared = sommaElementiArray(arrayTest2);
                        Console.WriteLine($" -- La somma degi elementi nell'array al quadrato è {sumSquared} ");





                    }
                    break;


                /* da qui in poi la parte extra bonus 
- Permette di Calcolare l'area di un cerchio  (I numeri sono in virgola quindi attenzione.)
- Converta i gradi da Celsius a Farenheit 
- Verificare se il numero fornito in input è un numero primo o no
- Concatenare due stringhe date in ingresso (BONUS: Permettere all'utente anche di scegliere il carattere per la concatenazione)
- Verificare se una parola data in input è palindroma (HELP: la funzione Equals delle stringhe ci può aiutare) */
                case (2):
                    {

                        Console.WriteLine("quale esercizio vuoi provare ?");

                        int option2 = Convert.ToInt32(Console.ReadLine());
                        
                        while(!(option2 >= 1) || !(option2 <=3  )) {
                            Console.WriteLine("Non è un opzione valida, scegli un valore intero tra 1 e 3 compresi");
                            option2 = Convert.ToInt32(Console.ReadLine());
                        }

                        switch (option2){

                            case (1):
                                {
                                    Console.WriteLine("inserisci il raggio del cerchio");
                                    decimal radiusTest = Convert.ToDecimal(Console.ReadLine());

                                    decimal answer = (Math.Round(areaOfACrircle(radiusTest), 2));
                                    Console.WriteLine($"{answer} è la risposta che cercavi");


                                }
                                break;

                            case (2): {

                                    Console.WriteLine("Inserisci ora i gradi celsius te li restituisco in farenheit (fino a 2 numeri dopo la virgola)");
                                    decimal userCelsius = Convert.ToDecimal(Console.ReadLine());

                                    decimal userFare = Math.Round(celToFar(userCelsius), 2);
                                    Console.WriteLine($"{userFare} è la risposta che cercavi");
                                }
                                break;

                            case (3):
                                {
                                    Console.WriteLine("inserisci un numero ti dico se è primo");

                                    bool answer = isPrime(Convert.ToInt32(Console.ReadLine()));


                                    if (answer == true)
                                        Console.WriteLine("il numero è primo");
                                    else if (answer == false)
                                        Console.WriteLine("il numero non è primo");
                                    else
                                        Console.WriteLine("ops c'è un problema");
                                }
                                break;



                                //da finire 


                            case (4): {
                                
                                }
                                break;


                        }


                        





                        decimal areaOfACrircle(decimal radius)
                        {
                            decimal pi = Convert.ToDecimal(Math.PI);
                            decimal newRadius = radius * radius;
                            
                            return (newRadius * pi);                         
                        }


                        decimal celToFar(decimal celsius)
                        {
                            decimal faren = ((celsius * 9 / 5) + 32);
                            return faren;

                        }


                        bool isPrime(int number)
                        {
                           
                            for (int i=2; i <= number/2; i++)
                            {
                                if (number % i == 0)
                                    return false;
                                    

                            }

                            return true;
                        }


                    }
                    break;

            }


            void StampaArray(int[] array)
            {
                int i = 0;
                foreach (int element in array)
                {
                    if (i == 0)
                        Console.Write($"[ {element} -");
                    else if (i == array.Length - 1)
                        Console.Write($"- {element} ]\n");
                    else
                        Console.Write($"- {element} -");
                    i++;
                }

            }

            int Quadrato(int numero)
            {
                int result = numero * numero;
                return result;
            }


            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] arrayElevato = (int[])array.Clone();

                for (int i = 0; i < array.Length; i++)
                {
                    arrayElevato[i] = Quadrato(array[i]);
                }

                return arrayElevato;

            }




            int sommaElementiArray(int[] array)
            {
                int sum = 0;

                foreach (int element in array)
                {
                    sum += element;
                }

                return sum;


            }

        }
    }













}




/*In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
-**void StampaArray(int[] array) * *: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
- **int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.
- **int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
- **int sommaElementiArray(int[] array)**: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
-Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
-Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati
**BONUS:**Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi **di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.*/





