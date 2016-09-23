using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerCoaster3
{
    class Program
    {
        static void Main(string[] args)
        {
            string shakespeareString = "To be, or not to be: that is the question.";

            //Whether 'tis nobler in the mind to suffer.
            //The slings and arrows of outrageous fortune.
            //Or to take arms against a sea of troubles.
            //And by opposing end them, to die: to sleep.

            char[] array = shakespeareString.ToCharArray();

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                char let = array[i];
                counter++;

                if (char.IsLetter(let))
                    {
                    if (counter % 2 == 0)
                    {
                        array[i] = char.ToUpper(let);
                        
                    }
                   


                    if (counter % 2 != 0)
                    {
                        array[i] = char.ToLower(let);
                        
                    }
                    
                }
            }    
            
            string result = new string(array);
            Console.WriteLine(result);
            
        }
       


        }
    }

