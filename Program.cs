using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace WriteLines
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("nome? ");
            string nome = Console.ReadLine();

            Console.Write("cognome? ");
            string cognome = Console.ReadLine();

            Thread.Sleep(2000);

            Console.Write($"Ciao {nome} {cognome}! Come stai? ");
            string risposta = Console.ReadLine();

            if (risposta == "bene")
                {
                Thread.Sleep(1000);
                Console.WriteLine("Perfetto!");
                }




            if (risposta == "male")
                {
                Thread.Sleep(1000);
                Console.WriteLine("Mi dispiace!");
                }




                  
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }       
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }













}
