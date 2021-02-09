using System;

namespace contrato_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Salario mensual: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("tipo de contrato(dependiente = 1 o independiente = 2): ");
            int contrato = int.Parse(Console.ReadLine());
            double cotizacion = salario * 0.4;
            double SMMLV = 908526;
            if (cotizacion <= SMMLV)
            {
                cotizacion = SMMLV;
            }


            switch (contrato)
            {
                case 1:
                    int ARL = 0;
                    Console.WriteLine("ARL: " + ARL);
                    double EPS = cotizacion * 0.04;
                    Console.WriteLine("EPS: " + EPS);
                    double Pension = cotizacion * 0.04;
                    Console.WriteLine("Pension: " + Pension);
                    double deducciones = EPS + Pension;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salario + salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                    break;

                default:

                    Console.WriteLine("Clase de riesgo: ");
                    double riesgo = double.Parse(Console.ReadLine());

                    double EPS1 = cotizacion * 0.125;
                    Console.WriteLine("EPS: " + EPS1);

                    double Pension1 = cotizacion * 0.16;
                    Console.WriteLine("Pension: " + Pension1);

                    switch (riesgo)
                    {
                        case 1:
                            double ARL1 = cotizacion * 0.00522;
                            Console.WriteLine("ARL: " + ARL1);
                            double deducciones1 = EPS1 + Pension1 + ARL1;
                            Console.WriteLine("deducciones: " + deducciones1);
                            double salarioR1 = salario - deducciones1;
                            Console.WriteLine("salario Real: " + salarioR1);
                            double salaAU1 = salarioR1 * 12;
                            Console.WriteLine("salario Anual: " + salaAU1);
                            break;

                        case 2:
                            double ARL2 = cotizacion * 0.01044;
                            Console.WriteLine("ARL: " + ARL2);
                            double deducciones2 = EPS1 + Pension1 + ARL2;
                            Console.WriteLine("deducciones: " + deducciones2);
                            double salarioR2 = salario - deducciones2;
                            Console.WriteLine("salario Real: " + salarioR2);
                            double salaAU2 = salarioR2 * 12;
                            Console.WriteLine("salario Anual: " + salaAU2);
                            break;

                        case 3:

                            double ARL3 = cotizacion * 0.02436;
                            Console.WriteLine("ARL: " + ARL3);
                            double deducciones3 = EPS1 + Pension1 + ARL3;
                            Console.WriteLine("deducciones: " + deducciones3);
                            double salarioR3 = salario - deducciones3;
                            Console.WriteLine("salario Real: " + salarioR3);
                            double salaAU3 = salarioR3 * 12;
                            Console.WriteLine("salario Anual: " + salaAU3);
                            break;

                        case 4:
                            double ARL4 = cotizacion * 0.04350;
                            Console.WriteLine("ARL: " + ARL4);
                            double deducciones4 = EPS1 + Pension1 + ARL4;
                            Console.WriteLine("deducciones: " + deducciones4);
                            double salarioR4 = salario - deducciones4;
                            Console.WriteLine("salario Real: " + salarioR4);
                            double salaAU4 = salarioR4 * 12;
                            Console.WriteLine("salario Anual: " + salaAU4);
                            break;

                        case 5:
                            double ARL5 = cotizacion * 0.06960;
                            Console.WriteLine("ARL: " + ARL5);
                            double deducciones5 = EPS1 + Pension1 + ARL5;
                            Console.WriteLine("deducciones: " + deducciones5);
                            double salarioR5 = salario - deducciones5;
                            Console.WriteLine("salario Real: " + salarioR5);
                            double salaAU5 = salarioR5 * 12;
                            Console.WriteLine("salario Anual: " + salaAU5);
                            break;

                    }
                    break;

            }

        }
    }
}
