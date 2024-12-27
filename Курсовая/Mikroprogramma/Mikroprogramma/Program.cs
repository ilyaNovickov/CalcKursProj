using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroprogramma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Work();
            Console.ReadLine();
        }

        static void Work()
        {
            const int a0 = 0b000;
            const int a1 = 0b001;
            const int a2 = 0b010;
            const int a3 = 0b011;
            const int a4 = 0b100;
            const int a5 = 0b101;
            const int a6 = 0b110;
            //const int a7 = 0b111;

            const int y0 = 0b0;
            const int y1 = 0b10000;
            const int y2 = 0b1000;
            const int y3 = 0b100;
            const int y4 = 0b10;
            const int y5 = 0b1;
            

            List<int> sourse = new List<int>();
            List<int> target = new List<int>();
            List<int> enter = new List<int>();
            List<int> exit = new List<int>();

            
            #region n1
            //A0 
            //Простой
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a0);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append( '0' );
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a0);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a0);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a0);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a0);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a1);
                    exit.Add(y1);
                }
                else
                {
                    target.Add(a0);
                    exit.Add(y0);
                }
            }

            //A1
            //Ввод А для +
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a1);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a1);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a1);
                    exit.Add(y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a4);
                    exit.Add(y2+y3);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a3);
                    exit.Add(y3);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a1);
                    exit.Add(y1);
                }
                else
                {
                    target.Add(a1);
                    exit.Add(y0);
                }
            }

            //A2
            //Ввод А для ИЛИ
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a2);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a2);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a2);
                    exit.Add(y2+y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a4);
                    exit.Add(y2 + y3);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a3);
                    exit.Add(y3);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a2);
                    exit.Add(y1+y2);
                }
                else
                {
                    target.Add(a2);
                    exit.Add(y2);
                }
            }

            //A3
            //Ввод В для +
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a3);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a5);
                    exit.Add(y3+y5);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a1);
                    exit.Add(y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a4);
                    exit.Add(y2 + y3);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a3);
                    exit.Add(y3);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a3);
                    exit.Add(y1+y3);
                }
                else
                {
                    target.Add(a3);
                    exit.Add(y3);
                }
            }

            //A4
            //Ввод В для ИЛИ
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a4);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a6);
                    exit.Add(y2+y3+y5);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a2);
                    exit.Add(y2+y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a4);
                    exit.Add(y2 + y3);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a3);
                    exit.Add(y3);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a4);
                    exit.Add(y1+y2+y3);
                }
                else
                {
                    target.Add(a4);
                    exit.Add(y3+y2);
                }
            }

            //A5
            //Получить res для +
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a5);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a5);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a1);
                    exit.Add(y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a5);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a5);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a5);
                    exit.Add(y0);
                }
                else
                {
                    target.Add(a5);
                    exit.Add(y0);
                }
            }

            //A6
            //ПОлучить res для ИЛИ
            for (int forA = 0; forA < 32; forA++)
            {
                sourse.Add(a6);
                enter.Add(forA);

                IEnumerable<char> val = Convert.ToString(forA, 2).Reverse();

                while (val.Count() < 5)
                {
                    val = val.Append('0');
                }

                if (val.ElementAt<char>(0) == '1')
                {
                    target.Add(a6);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(1) == '1')
                {
                    target.Add(a2);
                    exit.Add(y2+y4);
                }
                else if (val.ElementAt<char>(2) == '1')
                {
                    target.Add(a6);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(3) == '1')
                {
                    target.Add(a6);
                    exit.Add(y0);
                }
                else if (val.ElementAt<char>(4) == '1')
                {
                    target.Add(a6);
                    exit.Add(y0);
                }
                else
                {
                    target.Add(a6);
                    exit.Add(y0);
                }
            }
            #endregion

            List<int> addresses = new List<int>(sourse.Count);
            List<int> output = new List<int>(sourse.Count);

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            sb.AppendLine("A;X;Y;A;");
            sb2.AppendLine("Adress;Value;");
            for (int i = 0; i < sourse.Count; i++)
            {
                sb.AppendLine($"{Convert.ToString(sourse[i], 2)};{Convert.ToString(enter[i], 2)};{Convert.ToString(exit[i], 2)};{Convert.ToString(target[i], 2)};");

                addresses.Add( (sourse[i] << 5) + enter[i] );
                output.Add( (exit[i] << 3) + target[i] );

                sb2.AppendLine($"{Convert.ToString(addresses[i], 16)};{Convert.ToString(output[i], 16)};");
            }

            using (StreamWriter tw = new StreamWriter("table.txt"))
            {
                tw.Write(sb.ToString());
            }

            using (StreamWriter tw = new StreamWriter("adresses.txt"))
            {
                tw.Write(sb2.ToString());
            }

            using (StreamWriter sw = new StreamWriter("prog"))
            {
                BinaryWriter bw = new BinaryWriter(sw.BaseStream);

                foreach (int item in output)
                {
                    bw.Write((byte)item);
                }

            }
        }
    }
}
