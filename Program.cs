namespace calculadora
{
    class program
    {
        static void Main(string[] args)
        
        {
            float n1 = 0;
            float n2 = 0;
            float resultado = 0;
            Console.WriteLine("Ingrese la operación que desea realizar");
            
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");
            Console.WriteLine(" ");
            string opc = Console.ReadLine();
            switch (opc)
            {
                case "suma":
                    Console.WriteLine("Suma");
                    Console.WriteLine("Ingrese el primer valor");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = float.Parse(Console.ReadLine());
                    resultado = n1 + n2;
                    Console.WriteLine("El resultado de la suma es: "+resultado);
                    break;


                case "resta":
                    Console.WriteLine("Resta");
                    Console.WriteLine("Ingrese el primer valor");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = float.Parse(Console.ReadLine());
                    resultado = n1 - n2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;

                case "multiplicacion":
                    Console.WriteLine("multiplicacion");
                    Console.WriteLine("Ingrese el primer valor");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = float.Parse(Console.ReadLine());
                    resultado = n1 * n2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;

                case "division":
                    Console.WriteLine("Division");
                    Console.WriteLine("Ingrese el primer valor");
                    n1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    n2 = float.Parse(Console.ReadLine());
                    resultado = n1 / n2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;

            }

        }
    }
}