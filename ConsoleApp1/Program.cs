using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // question (a)
            //Display the value of the seventh element of character array f
            char[] f = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            Console.WriteLine("Question (a): Display the value of the seventh element of character array f.");
            Console.WriteLine("char[] f = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };");
            Console.WriteLine("Display the value of the seventh element of character array f = " + f[6]); // g
            Console.WriteLine();

            // question (b)
            //Initialize each of the five elements of single-subscripted integer array g to 8.
            int[] g = new int[5];
            Console.WriteLine("Question (b): Initialize each of the five elements of single-subscripted integer array g to 8.");
            Console.Write("Elements of g: \t");
            for (int i = 0; i < g.Length; i++)
            {
                g[i] = 8;
                Console.Write(g[i]);
                Console.Write('\t');
            }
            Console.WriteLine('\n');

            // question (c)
            //Total the elements of floating - point array c of 100 elements.
            float[] c = new float[101];
            for (int i = 0; i < c.Length; i++) c[i] = (float)i;
            float total = 0.0f;
            for (int i = 0; i < c.Length; i++) total += c[i];
            Console.WriteLine("Question (c): Total the elements of floating - point array c of 100 elements.");
            Console.WriteLine("Total elements of floating-point array c of 100 elements= " + total); //5050
            Console.WriteLine();

            // question (d)
            //Copy 11-element array a into the first portion of array b containing 34 elements.
            //int a equals to 11 element.
            int[] a = new int[11];
            //Increase 1 by 1 until there are 11 elements in this for loop.
            for (int i = 0; i < a.Length; i++) a[i] = i;
            //int b equals to 34 element.
            int[] b = new int[34];
            //Arrays have been copied.
            Array.Copy(a, b, 11);
            Console.WriteLine("Question (d): Copy 11-element array a into the first portion of array b containing 34 elements.");
            for (int i = 0; i < 11; i++) Console.Write("{0} ", b[i]);
            Console.WriteLine('\n');

            // question (e)
            // Determine the smallest and largest values contained in 99-element floating-point array w.
            float[] w = new float[99];
            for (int i = 0; i < w.Length; i++) w[i] = (float)i;
            float max = float.MinValue;
            float min = float.MaxValue;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] > max) max = w[i];
                if (w[i] < min) min = w[i];
            }
            Console.WriteLine("Question (e): Determine the smallest and largest values contained in 99-element floating-point array w.");
            Console.WriteLine("Max  = {0}, Min = {1}", max, min); // 98 and 0

            Console.ReadKey();
        }
    }
}
