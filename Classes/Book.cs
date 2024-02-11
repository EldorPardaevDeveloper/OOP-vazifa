namespace VAZIFA.Classes
{
    class Book
    {
       public string Muallif {get; set;}
       public string KitobNomi {get; set;}
      
       public string KitobNarxi {get; set;}
       private int narx;

       public int Narx
       {
         get
         {
            return narx;
         }
         set
         {
            narx = value;
         }
       }
       
       public Book(string kitobNomi,int kitobNarxi)
       {  
          
          Narx = kitobNarxi;
          KitobNomi = kitobNomi; 
          
          Muallif = $" \"Abu Xomid G'azzoliy\"";
         
       }

       public void KitobningNomi()
       {
         System.Console.WriteLine($"Men bugundan {KitobNomi}kitobini o'qishni boshladim");
       }

       public void KitobningMuallifi()
       {
         System.Console.WriteLine($"Kitobninig muallifi {Muallif}");
       }

       public void KitobningNarxi()
       {
         System.Console.WriteLine($"Kitobning narxi {Narx} so'm");
       }

       public void KitobChiqarilganYil(int Yil)
       {
         System.Console.WriteLine($"Kitob {Yil}-yilda Toshkentda ishlab chiqarilgan ");
       }
    }
}