## Tipo String
String es un tipo por referencia

## Secuencias de Escape de String
Secuencias de escape de un string:

\\\	Barra invertida

\\'	Comilla simple 

\\"	Comilla doble 

\n	Nueva línea 

\r	Retorno de carro 

\t	Tabulación horizontal 

\b	Retroceso 

\f	Avance de página

\v	Tabulación vertical 

\a	Campana 

\0	Carácter nulo

## Uso de @ y $
Los caracteres @ y $ se utilizan como prefijos de cadenas de texto para proporcionar funcionalidades especiales
El prefijo @ se usa para crear cadenas verbatim (textuales). Las cadenas verbatim permiten incluir caracteres especiales, como barras invertidas \ y saltos de línea, sin necesidad de usar secuencias de escape. Además, se pueden escribir múltiples líneas directamente dentro de la cadena.

Ejemplo:
string path = @"C:\Users\Nombre\Documentos\Archivo.txt";

string multiline = @"Esta es una cadena

que abarca

múltiples líneas.";

El prefijo $ se utiliza para habilitar la interpolación de cadenas, lo que permite insertar expresiones dentro de una cadena. Las expresiones se escriben entre llaves {} y se evalúan en tiempo de ejecución, lo que facilita la construcción de cadenas dinámicas.

Ejemplo:

int age = 30;

string name = "Alice";

string message = $"Name: {name}, Age: {age}";

En este caso, la cadena resultante será "Name: Alice, Age: 30", con los valores de name y age insertados en la cadena.
