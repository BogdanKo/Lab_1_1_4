using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {


        // 1) declare enum ComputerType

        enum ComputerType { Desktop, Laptop, Server }

        // 2) declare struct Computer
        struct Computer

        {
            public short memory;
            public short HDD;
            public float CPU;
            public float Freq;
            public ComputerType TypePC;
        }

        static void Main(string[] args)
        {

            short totCompAmount = 0;
            short totDeskAmount = 0;
            short totLapTopAmount = 0;
            short totServersAmount = 0;

            short Big_HDD = 0;
            short Low_CPU = 0;
            short Low_Memory = 0;

            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] departments = new Computer[4][];


            // 4) set the size of every array in jagged array (number of computers)

            departments[0] = new Computer[5];
            departments[1] = new Computer[3];
            departments[2] = new Computer[5];
            departments[3] = new Computer[4];


            departments[0][0].TypePC = ComputerType.Desktop;
            departments[0][1].TypePC = ComputerType.Desktop;
            departments[0][2].TypePC = ComputerType.Laptop;
            departments[0][3].TypePC = ComputerType.Laptop;
            departments[0][4].TypePC = ComputerType.Server;

            departments[1][0].TypePC = ComputerType.Laptop;
            departments[1][1].TypePC = ComputerType.Laptop;
            departments[1][2].TypePC = ComputerType.Laptop;

            departments[2][0].TypePC = ComputerType.Desktop;
            departments[2][1].TypePC = ComputerType.Desktop;
            departments[2][2].TypePC = ComputerType.Desktop;
            departments[2][3].TypePC = ComputerType.Laptop;
            departments[2][4].TypePC = ComputerType.Laptop;

            departments[3][0].TypePC = ComputerType.Desktop;
            departments[3][1].TypePC = ComputerType.Laptop;
            departments[3][2].TypePC = ComputerType.Server;
            departments[3][3].TypePC = ComputerType.Server;


            // 5) initialize array
            // Note: use loops and if-else statements

            for (byte i = 0; i < departments.Length; i++)
            {
                for (byte j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].TypePC == ComputerType.Desktop)

                    {

                        departments[i][j].CPU = 4;
                        departments[i][j].HDD = 500;
                        departments[i][j].memory = 6;
                        departments[i][j].Freq = 2.5f;

                    }

                    else if (departments[i][j].TypePC == ComputerType.Laptop)

                    {

                        departments[i][j].CPU = 2;
                        departments[i][j].HDD = 250;
                        departments[i][j].memory = 6;
                        departments[i][j].Freq = 1.7f;

                    }
                    else if (departments[i][j].TypePC == ComputerType.Server)

                    {

                        departments[i][j].CPU = 8;
                        departments[i][j].HDD = 2000;
                        departments[i][j].memory = 16;
                        departments[i][j].Freq = 3.0f;


                    }




                }

            }
            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            for (byte i = 0; i < departments.Length; i++)
            {

                for (byte j = 0; j < departments[i].Length; j++)
                {

                    switch (departments[i][j].TypePC)
                    {
                        case ComputerType.Desktop:
                            totDeskAmount++;
                            break;
                        case ComputerType.Laptop:
                            totLapTopAmount++;
                            break;
                        case ComputerType.Server:

                            break;

                        default:
                            break;
                    }

                    totCompAmount++;
                }
            }


            // 8) find computer with the largest storage (HDD)
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            byte[] Inner_Arr_For_Big_HD_Pos = new byte[2];
            for (byte i = 0; i < departments.Length; i++)
            {
                for (byte j = 0; j < departments[i].Length; j++)
                {

                    if (departments[i][j].HDD > Big_HDD)
                    {

                        departments[i][j].HDD = Big_HDD;
                        Inner_Arr_For_Big_HD_Pos[0] = i;
                        Inner_Arr_For_Big_HD_Pos[1] = j;

                    }

                }
            }

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            byte[] inner_arr_for_lowest_CPU = new byte[2];
            byte[] inner_arr_for_lowest_Memory = new byte[2];

            for (byte i = 0; i < departments.Length; i++)
            {

                for (byte j = 0; departments[i].Length < j; j++)
                {

                    if ((departments[i][j].CPU < Low_CPU) && (departments[i][j].memory < Low_Memory))
                    {

                        departments[i][j].CPU = Low_CPU;
                        departments[i][j].memory = Low_Memory;

                        inner_arr_for_lowest_CPU[0] = i;
                        inner_arr_for_lowest_CPU[1] = j;
                        inner_arr_for_lowest_Memory[0] = i;
                        inner_arr_for_lowest_Memory[1] = j;


                    }
                }




                // 10) make desktop upgrade: change memory up to 8
                // change value of memory to 8 for every desktop. Don't do it for other computers
                // Note: use loops and if-else statements





            }

            for (byte i = 0; i < departments.Length; i++)
            {

                for (byte j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].TypePC == ComputerType.Desktop)
                    {

                        departments[i][j].memory = 8;
                    }




                }

            }

        }
    }
}
 
           
           



        