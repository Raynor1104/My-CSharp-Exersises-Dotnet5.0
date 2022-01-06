using System;

namespace Exersise2_W1_demo_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = 1;
            string[] one = {$"{i} x 2  = {i*2}  ", $"{i} x 3  = {i*3}  ", $"{i} x 4  = {i*4}  ", $"{i} x 5  = {i*5}  ", $"{i} x 6  = {i*6}  ", $"{i} x 7  = {i*7}  ", $"{i} x 8  = {i*8}  ", $"{i} x 9  = {i*9}  ", $"{i} x 10 = {i*10} "};

            i = 2;
            string[] two = {$"{i} x 2  = {i*2}  ", $"{i} x 3  = {i*3}  ", $"{i} x 4  = {i*4}  ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};

            i = 3;
            string[] three = {$"{i} x 2  = {i*2}  ", $"{i} x 3  = {i*3}  ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};

            i = 4;
            string[] four = {$"{i} x 2  = {i*2}  ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};

            i = 5;
            string[] five = {$"{i} x 2  = {i*2} ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};
            
            i = 6;
            string[] six = {$"{i} x 2  = {i*2} ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};
            
            i = 7;
            string[] seven = {$"{i} x 2  = {i*2} ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};
            
            i = 8;
            string[] eight = {$"{i} x 2  = {i*2} ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};
            
            i = 9;
            string[] nine = {$"{i} x 2  = {i*2} ", $"{i} x 3  = {i*3} ", $"{i} x 4  = {i*4} ", $"{i} x 5  = {i*5} ", $"{i} x 6  = {i*6} ", $"{i} x 7  = {i*7} ", $"{i} x 8  = {i*8} ", $"{i} x 9  = {i*9} ", $"{i} x 10 = {i*10} "};
            
            var sb = new System.Text.StringBuilder();
            sb.Append(String.Format("|{0,2}|{1,2}|{2,2}|{3,2}|{4,2}|{5,2}|{6,2}|{7,2}|{8,2}|\n", "1 x 1  = 1  ", "2 x 1  = 2  ", "3 x 1  = 3  ", "4 x 1  = 4  ", "5 x 1  = 5  ", "6 x 1  = 6  ", "7 x 1  = 7  ", "8 x 1  = 8  ", "9 x 1  = 9  "));
            for (int index = 0; index < one.Length; index++)
                sb.Append(String.Format("|{0,2}|{1,2}|{2,2}|{3,2}|{4,2}|{5,2}|{6,2}|{7,2}|{8,2}|\n", one[index], two[index], three[index], four[index], five[index], six[index], seven[index], eight[index], nine[index]/*equal[index], result[index]*/));
                Console.WriteLine(sb);
        }
    }
}
