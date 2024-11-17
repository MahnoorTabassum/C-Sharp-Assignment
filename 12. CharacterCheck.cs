using System;

class vowels 
{
  static void Main() 
  {
       Console.WriteLine("Enter Letter");
      char letter= Convert.ToChar(Console.ReadLine());
      switch(letter) 
{
      case 'A':
      case 'a':
        {
          Console.WriteLine(letter + " is a vowel");
          break;
        }
      case 'E':
      case 'e':
        {
          Console.WriteLine(letter + " is a vowel");
          break;
        }
      case 'I':
      case 'i':
        {
          Console.WriteLine(letter + " its a vowel");
          break;
        }
      case 'O':
      case 'o':
        {
          Console.WriteLine(letter + " is a vowel");
          break;
        }
      case 'U':
      case 'u':
        {
          Console.WriteLine(letter + " is a vowel");
          break;
        }
               
       default:
        {
           Console.WriteLine("it's a consonant");
           break;
        }
            }

        }
    }

    