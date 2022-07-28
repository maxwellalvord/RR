using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}







// using System;
// using System.Collections.Generic;


// namespace ToDoList.Models
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Welcome to the To Do list!");
//       string Response1 = "";
//        while(Response1.ToLower() != "end")
//         {
//           Console.WriteLine("Would you like to add an item or view your list?");
//           Console.WriteLine("Answer with add, view, or end");
//           Response1 = Console.ReadLine();

//           if (Response1.ToLower() == "add")
//           {
//             Add();
//           }
//           else if (Response1.ToLower() == "view")
//           {
//             View();
//           }
//         }    
//     }
//     public static void Add()
//     {
//       Console.WriteLine("what is the description of this list item?");
//         string addResponse1 = Console.ReadLine();
//         Item addResponse = new Item(addResponse1);
//     }  
//     public static void View()
//     {
//       List<Item> ItemList = Item.GetAll();
//       if (ItemList.Count <= 0 )
//       {
//         Console.WriteLine("Oh No! You haven't added anything to your to do list yet!");
//       }
//       else if (ItemList.Count >= 1)
//       {
//        for(int i = 0; i <= ItemList.Count - 1; i++)
//           {
//             Console.WriteLine((i + 1) + ". " + ItemList[i].Description);
//           }  
//       }
//     } 
//   }
// }