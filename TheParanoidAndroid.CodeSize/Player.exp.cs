﻿//using System;

//class P
//{
//    static void Main()
//    {
//        var n=Console.ReadLine().Split(' ');
//        int e=int.Parse(n[3]),f=int.Parse(n[4]),g=int.Parse(n[7]);
//        var h=new int[g+1];
//        while(g>0){
//            n=Console.ReadLine().Split(' ');
//            int k=int.Parse(n[0]),l=int.Parse(n[1]);h[k]=l;
//            g--;
//        }
//        for (;;)
//        {
//            n=Console.ReadLine().Split(' ');
//            g=int.Parse(n[0]);
//            int m=int.Parse(n[1]);var o=n[2];

//            Console.WriteLine(o[0]=='N'?"WAIT":o[0]=='L'&&((g==e?f:h[g])>m)||o[0]=='R'&&((g==e?f:h[g])<m)?"BLOCK":"WAIT");
//        }
//    }
//}