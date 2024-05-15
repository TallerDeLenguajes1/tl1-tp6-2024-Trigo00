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

string numeroIngresado;
float numeroConvert;

Console.Write("\n");
Console.Write("Ingrese un numero: ");
numeroIngresado = Console.ReadLine();
bool resultado = float.TryParse(numeroIngresado, out numeroConvert);

if(resultado){
    Console.WriteLine("El valor absoluto del numero ingresado es: " + Math.Abs(numeroConvert));
    Console.WriteLine("El cuadrado del numero ingresado es: " + (numeroConvert * numeroConvert));
    Console.WriteLine("La raiz cuadrada del numero ingresado es: " + Math.Sqrt(numeroConvert));
    Console.WriteLine("El seno del numero ingresado es: " + Math.Sin(numeroConvert));
    Console.WriteLine("El coseno del numero ingresado es: " + Math.Cos(numeroConvert));
    Console.WriteLine("La parte entera del numero ingresado es: " + Math.Truncate(numeroConvert));
}else{
    Console.WriteLine("Ocurrio un error, vuelva a intentarlo");

}

string num1Ing, num2Ing;
float num1Convert, num2Convert;

Console.Write("\n");
Console.Write("Ingrese un numero: ");
num1Ing = Console.ReadLine();
Console.Write("Ingrese otro numero: ");
num2Ing = Console.ReadLine();

bool result1 = float.TryParse(num1Ing, out num1Convert);
bool result2 = float.TryParse(num2Ing, out num2Convert);

if(result1 && result2){

    if(num1Convert > num2Convert){
        Console.WriteLine("El maximo entre los dos numeros ingresados es: " + num1Convert);
        Console.WriteLine("El minimo entre los dos numeros ingresados es: " + num2Convert);
    }else if(num1Convert < num2Convert){
        Console.WriteLine("El maximo entre los dos numeros ingresados es: " + num2Convert);
        Console.WriteLine("El minimo entre los dos numeros ingresados es: " + num1Convert);
    }else{
        Console.WriteLine("Los numeros ingresados son iguales");
    }
    
}else{
    Console.WriteLine("Ocurrio un error, vuelva a intentarlo");
}






