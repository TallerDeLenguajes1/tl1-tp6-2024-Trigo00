// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

///Punto 1///
/*Console.Write("Ingrese un numero: ");
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
}*/


//Punto 2
/*string opcion, num1, num2;
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

            float resultado0 = num1Convert + num2Convert;
            Console.WriteLine("La suma entre "+ num1Convert + " y " + num2Convert + " es: " + resultado0);
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
*/

//Punto 3
/*string numeroIngresado;
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
float num1Convertido, num2Convertido;

Console.Write("\n");
Console.Write("Ingrese un numero: ");
num1Ing = Console.ReadLine();
Console.Write("Ingrese otro numero: ");
num2Ing = Console.ReadLine();

bool result1 = float.TryParse(num1Ing, out num1Convertido);
bool result2 = float.TryParse(num2Ing, out num2Convertido);

if(result1 && result2){

    if(num1Convertido > num2Convertido){
        Console.WriteLine("El maximo entre los dos numeros ingresados es: " + num1Convertido);
        Console.WriteLine("El minimo entre los dos numeros ingresados es: " + num2Convertido);
    }else if(num1Convertido < num2Convertido){
        Console.WriteLine("El maximo entre los dos numeros ingresados es: " + num2Convertido);
        Console.WriteLine("El minimo entre los dos numeros ingresados es: " + num1Convertido);
    }else{
        Console.WriteLine("Los numeros ingresados son iguales");
    }
    
}else{
    Console.WriteLine("Ocurrio un error, vuelva a intentarlo");
}*/

//Punto 4
string cadena1, cadena2;

Console.Write("\n");
Console.Write("Ingrese una cadena: ");
cadena1 = Console.ReadLine();
/*Console.Write("Ingrese otra cadena: ");
cadena2 = Console.ReadLine();*/

//Obtener la longitud de la cadena y muestre por pantalla
//Console.WriteLine("La longitud de la cadena 1 es: " + cadena1.Length);

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas
//Console.WriteLine("Las dos cadenas concatenadas queda de la siguiente manera: " + cadena1 + cadena2);

//Extraer una subcadena de la cadena ingresada
//Console.WriteLine("Un substring de la cadena 1 es: " + cadena1.Substring(0, cadena1.Length/2));
//Console.WriteLine("Un substring de la cadena 2 es: " + cadena2.Substring(1, cadena2.Length));

//Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado
/*string opcion, num1, num2;
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

            string resultado0 = (num1Convert + num2Convert).ToString();
            Console.WriteLine("La suma entre "+ num1Convert + " y " + num2Convert + " es: " + resultado0);
            break;
        case 2:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            string resultado2 = (num1Convert - num2Convert).ToString();
            Console.WriteLine("La resta entre " + num1Convert.ToString() + " y " + num2Convert.ToString() + " es: " + resultado2);
            break;
        case 3:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            string resultado3 = (num1Convert * num2Convert).ToString();
            Console.WriteLine("La multiplicacion entre " + num1Convert.ToString() + " y " + num2Convert.ToString() + " es: " + resultado3);
            break;
        case 4:
            Console.Write("Ingrese el numero 1: ");
            num1 = Console.ReadLine();
            Console.Write("Ingrese el numero 2: ");
            num2 = Console.ReadLine();
            float.TryParse(num1, out num1Convert);
            float.TryParse(num2, out num2Convert);

            string resultado4 = (num1Convert / num2Convert).ToString();
            Console.WriteLine("La division de " + num1Convert.ToString() + " entre " + num2Convert.ToString() + " es: " + resultado4);
            break;
        case 5:
            break;
        default:
            break;
    }

} while (opcionConvert != 1 && opcionConvert != 2 && opcionConvert != 3 && opcionConvert != 4 && opcionConvert != 5);
*/


//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
/*foreach (char letra in cadena1)
{
    Console.Write($" {letra} ");
}*/


//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
/*Console.WriteLine("Ingrese la palabra que quiere buscar en la cadena");
string palabraBuscada = Console.ReadLine();
bool ocurrencia = cadena1.Contains(palabraBuscada);
if(ocurrencia){
    Console.WriteLine("La cadena SI contiene la palabra '" + palabraBuscada + "'");
}else{
    Console.WriteLine("La cadena NO contiene la palabra ingresada");
}*/

//Convierta la cadena a mayúsculas y luego a minúsculas.
//Console.WriteLine("La cadena 1 convertida a mayuscula es: " + cadena1.ToUpper());
//Console.WriteLine("La cadena 1 convertida a minuscula es: " + cadena1.ToLower());

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
/*string[] cadenaResultante = cadena1.Split(" ");
foreach (var letra in cadenaResultante)
{
    Console.WriteLine(letra);
}*/

// Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva
static float evaluarEcuacion(string expression)
{
    float primero, segundo;
    char[] operadores = { '+', '-', '*', '/' };

    foreach (char operador in operadores)
    {
        string[] miembros = expression.Split(operador);
        if (miembros.Length == 2)
        {
            if (float.TryParse(miembros[0], out primero) && float.TryParse(miembros[1], out segundo))
            {
                switch (operador)
                {
                    case '+':
                        return primero + segundo;
                    case '-':
                        return primero - segundo;
                    case '*':
                        return primero * segundo;
                    case '/':
                        return primero / segundo;
                    default:
                        return -9999;
                }
            }
            else
            {
                return -9999;
            }
        }
    }
    return -9999;
}

Console.WriteLine("El resultado de la ecuacion es: " + evaluarEcuacion(cadena1));