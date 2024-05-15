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