using EspacioCalculadora;

int codigo = 0;
double num;
Calculadora calc = new();

while (true)
{
    if(calc.Dato == 0)
    {
        Console.WriteLine("------------CALCULADORA------------");
        Console.WriteLine("Ingrese un valor para operar : ");
        double.TryParse(Console.ReadLine(), out num);
        calc.Dato = num;
        num = 0;
    }
    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine("SUMAR : 1");
    Console.WriteLine("RESTAR : 2");
    Console.WriteLine("MULTIPLICAR : 3");
    Console.WriteLine("DIVIDIR: 4");
    Console.WriteLine("Limpiar: 5");
    Console.WriteLine("SALIR : 0");
    int.TryParse(Console.ReadLine(), out codigo);
    //--------------------//
    if(codigo == 0)
    {
        return;
    }
    // ---------------- //
    if(codigo == 5){
        calc.Limpiar();
    }
    else
    {    
        Console.WriteLine("Ingrese el otro operando:");
        double.TryParse(Console.ReadLine(), out num);
        switch (codigo)
        {
            case 1 :
                calc.Sumar(num);
                break;
            case 2 :
                calc.Restar(num);
                break;
            case 3 :
                calc.Multiplicar(num);
                break;
            case 4 :
                calc.Dividir(num);
                break;
        }
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Resultado: " + calc.Resultado);
        Console.WriteLine("--------------------------------");
    }
}




