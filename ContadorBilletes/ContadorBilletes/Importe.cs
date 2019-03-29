using System;


namespace ContadorBilletes
{
    class Importe
    {
        static void Main(string[] args)
       {
            int Contador1 = 0;
            Console.WriteLine("INGRESE MONTO : " );
            double MONTO = Convert.ToDouble(Console.ReadLine());
            
            double[] P3 = new double[8] {1000,500,200,100,50,20,10,5};
            double[] P4 = new double[7] {  2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            for (int i = 0; i < P3.Length; i++)
            {
                Contador1 = 0;
                while (MONTO >= P3[i])
                {
                    MONTO = MONTO - P3[i];
                    Contador1++;
                }
                if (Contador1 !=0)
                {
                    Console.WriteLine("BILLETES DE " + P3[i] + ": " + Contador1);
                } 
            }
            for (int i = 0; i < P4.Length; i++)
            {
                Contador1 = 0;
                while (MONTO >= P4[i])
                {
                    MONTO = MONTO - P4[i];
                    Contador1++;
                }
                if (Contador1 != 0)
                {
                    Console.WriteLine("MONEDAS DE " + P4[i] + ": " + Contador1);
                }
            }
        }
    }
}
