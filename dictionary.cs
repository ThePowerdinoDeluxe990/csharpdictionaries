using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //Los tipos de datos se ponen en el <>
        var dictionary = new Dictionary<string, string>();
        dictionary.Add("Primero", "1r");
        dictionary.Add("Segundo", "2n");
        dictionary.Add("tercero", "3r");
        dictionary.Add("quarto", "4r");
        dictionary.Add("quinto", "5t");

        dictionary.Remove("Primero");
      //dictionary.Clear();

        //Console.WriteLine(dictionary["Primero"]);
        foreach (var item in dictionary)
        {
            Console.WriteLine(item);
        }
       
        

            //myList.Remove("primero");

  /*
    foreach(var item in myList){
      Console.WriteLine(item);
     
    }
    */

  }
}
