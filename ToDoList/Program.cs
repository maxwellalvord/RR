using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to your to do list!");
      Console.WriteLine("Would you like to add an item or view your list? answer with add or view");
      string response1 = Console.ReadLine();
      if (response1 == "add")
      {
        Console.WriteLine("what is the description of this list item?");
        string addResponse1 = Console.ReadLine();
        Item addResponse = new Item(addResponse1);
        Console.WriteLine(addResponse.Description + " has been added to your list, would you like to add an item to your list or view you list, reply with add or view.");
        string addResponse2 = Console.ReadLine();
        if (addResponse2 == "view")
        {
          List<Item> ItemList = Item.GetAll();
          for(int i = 0; i <= ItemList.Count -1; i++)
          {
            Console.WriteLine(ItemList[i].Description);
          }  
        } else if (addResponse2 == "add")
        {
          Main(); 
        }
      }   
    }
  }
}