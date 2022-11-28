using System;
public class Demo {
   public static void Main(string[] args) {
      int k1 = 1, k2 = 1, k3, i, n;
      n = 5;
      Console.Write(k1+" "+k2+" ");
      for(i=2;i<n;++i) {
         k3 = k1 + k2;
         Console.Write(k3+" ");
         k1 = k2;
         k2 = k3;
      }
   }
}
