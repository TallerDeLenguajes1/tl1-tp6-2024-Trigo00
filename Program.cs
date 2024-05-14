// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
 int b;
 a=10;
 b=a;
 Console.WriteLine("valor de a:"+a);
 Console.WriteLine("valor de b:"+b);

 ///Punto 1///
Console.Write("Ingrese un numero: ");
string numero = Console.ReadLine();
int numeroConvertido;
bool convertido = int.TryParse(numero, out numeroConvertido);

if(numeroConvertido > 0){

    int invertido = 0;

    while(numeroConvertido > 0 ){


        int ultDig = (numeroConvertido % 10);
        invertido = invertido * 10 + ultDig;
        numeroConvertido /= 10;
    }

    Console.Write("El numero invertido es: "+invertido);

}else{
    Console.WriteLine("Error, ingrese un numero mayor a 0.");
}

string opcion, num1, num2;
int opcionConvert;
float num1Convert, num2Convert;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("Menu Principal:");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Salir");
    Console.Write("Ingrese la opcion deseada:");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionConvert);

    switch (opcionConvert)
    {
        case 1:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            float resultado = num1Convert + num2Convert;
            Console.WriteLine("La suma entre "+ num1Convert + " y " + num2Convert + " es: " + resultado);
            break;
        case 2:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            float resultado2 = num1Convert - num2Convert;
            Console.WriteLine("La resta entre " + num1Convert + " y " + num2Convert + " es: " + resultado2);
            break;
        case 3:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            float resultado3 = num1Convert * num2Convert;
            Console.WriteLine("La multiplicacion entre " + num1Convert + " y " + num2Convert + " es: " + resultado3);
            break;
        case 4:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            float resultado4 = num1Convert / num2Convert;
            Console.WriteLine("La division de " + num1Convert + " entre " + num2Convert + " es: " + resultado4);
            break;
        case 5:
            break;
        default:
            break;
    }

} while (opcionConvert != 1 && opcionConvert != 2 && opcionConvert != 3 && opcionConvert != 4 && opcionConvert != 5);





