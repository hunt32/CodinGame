﻿using System;
class Player 
{
    static void Main(string[] args)
    {
        string[] i = Console.ReadLine().Split(' '); 
        int a = int.Parse(i[0]); 
        int b = int.Parse(i[1]); 
        int c = int.Parse(i[2]); 
        int d = int.Parse(i[3]);
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); 
            object[] m = a < c && b < d ? new object[] { -1, -1, "NW" } : a > c && b < d ? new object[] { 1, -1, "NE" } : a > c && b > d ? new object[] { 1, 1, "SE" } : a < c && b > d ? new object[] { -1, 1, "SW" } : a == c && b < d ? new object[] { 0, -1, "N" } : a == c && b > d ? new object[] { 0, 1, "S" } : a < c ? new object[] { -1, 0, "W" } : a > c ? new object[] { 1, 0, "E" } : new object[0]; 
            c += (int)m[0]; 
            d += (int)m[1]; 
            Console.WriteLine(m[2]);
        }
    } 
}