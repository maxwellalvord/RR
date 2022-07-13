using System;
using System.Collections.Generic;


namespace ToDoList.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do list!");
      string Response1 = "";
       while(Response1 != "end")
        {
          Console.WriteLine("Would you like to add an item or view your list?");
          Console.WriteLine("Answer with add, view, or end");
          Response1 = Console.ReadLine();

          if (Response1 == "add")
          {
            Add();
          }
          else if (Response1 == "view")
          {
            View();
          }
        }    
    }
    public static void Add()
    {
      Console.WriteLine("what is the description of this list item?");
        string addResponse1 = Console.ReadLine();
        Item addResponse = new Item(addResponse1);
    }  
    public static void View()
    {
      List<Item> ItemList = Item.GetAll();
        for(int i = 0; i <= ItemList.Count - 1; i++)
          {
            Console.WriteLine((i + 1) + ". " + ItemList[i].Description);
          } 
    } 
  }
}