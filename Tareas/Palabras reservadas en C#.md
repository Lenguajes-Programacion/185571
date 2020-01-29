Palabras reservadas de C#
Mariana Abigail Zamora Santillán.
Matricula: 185571.
Son palabras que interpreta el compilador, no se pueden usar como identificadores. En Visual Studio se diferencian utilizando en color azul. 
Si se necesita utilizar una palabra reservada como un identificador es necesario utilizar un @ antes del nombre. 
Las palabras reservadas son: 
Abstract: El modificador abstract indica que el elemento objeto de la modificación tiene una implementación incompleta o que le falta una implementación. 
As: Es para realizar algunos tipos de conversiones entre los tipos de referencia compatibles o tipos que aceptan valores NULL.
Base: Se utiliza para obtener acceso a los miembros de la clase base desde una clase deriva.
Bool: Es un alias de System. Boolean. Se utiliza para declarar variables que almacenan los valores booleanos, true y false.
Break: Permite terminar el bucle envolvente más cercano o la instrucción switch en la cual aparece. El control se transfiere a la instrucción que sigue a la instrucción terminada, si existe alguna.
Byte: Denota un tipo entero que almacena valores.
Switch: Es una instrucción de control que selecciona una sección switch para ejecutarla desde una lista de candidatos.
Try-Catch: Consta de un bloque try seguido de una o más cláusulas catch que especifican controladores para diferentes excepciones.
Char: Se utiliza para declarar una instancia de la estructura de System. Char que .NET Framework utiliza para representar un carácter Unicode. El valor de un objeto de Char es un valor (ordinal) numérico de 16 bits.
Cheked: Se usa con el fin de habilitar explícitamente la comprobación de desbordamiento para operaciones aritméticas y conversiones de tipo integral.
Class: Es una clase.
Const: Se usa para declarar un campo constante o una local constante. Los campos y locales constantes no son variables y no se pueden modificar. Las constantes pueden ser números, valores booleanos, cadenas o una referencia nula. No cree una constante para representar información que esperas que cambie en algún momento.
Continue: La instrucción pasa el control a la siguiente iteración de mientras que agrega, de haga, de para, o la instrucción de foreach en la que aparece.
Decimal: Indica un tipo de datos de 128 bits. Tiene una mayor precisión y un intervalo más reducido.
Defaul: Se puede utilizar en la instrucción switch o en código genérico.
Do: La instrucción ejecuta una instrucción o un bloque de instrucciones repetidamente hasta que una determinada expresión se evalúa como false..
Double: Es un tipo simple que almacena valores de punto flotante de 64 bits.
If-Else: Una instrucción if identifica que sentencia se tiene que ejecutar en función del valor de una expresión Boolean. 
Enum:  Se utiliza para declarar una enumeración, un tipo distinto que consiste en un conjunto de constantes con nombre denominado lista de enumeradores.
Event: Es para declarar un evento en una clase de editor.
Explicit: Declara un operador de conversión de tipos definido por el usuario que se debe invocar con una conversión de tipos. 
Extern: Se usa para declarar un método que se implementa externamente. 
Try-Finally: Limpia los recursos que se asignan en un bloque try.
Fixed: Evita que el recolector de elementos no utilizados vuelva a ubicar una variable móvil. También se puede utilizar para crear búferes de tamaño fijo.
Float: Es un tipo simple que almacena valores de punto flotante de 32 bits.
In: Especifica que el parámetro de tipo es contravariante. 
For: Un bucle for puede ejecutar una instrucción o un bloque de instrucciones varias veces hasta que una expresión especificada se evalúe con false. 
Foreach: Repite un grupo de instrucciones incrustadas para cada elemento de una matriz o colección de objetos que implementa la interfaz System. Se utiliza para recorrer la colección en iteración y obtener la información deseada, pero no se puede utilizar para agregar o quitar elementos de la colección de origen, ya que se pueden producir efectos secundarios imprevisibles. 
Goto: Transfiere el control del programa directamente a una instrucción identificada por una etiqueta.
Impiclit: Se utiliza para declarar un operador de conversión de tipo implícito definido por el usuario. Se utiliza para permitir conversiones implícitas entre un tipo definido por el usuario y otro tipo, si existen garantías de que la conversión no provocará la pérdida de datos.
Int: Es un tipo entero que almacena valores según el tamaño.
Interface: Una interfaz sólo contiene las declaraciones de métodos, propiedades, eventos o indizadores. Una clase o struct que implemente la interfaz debe implementar los miembros de la interfaz que se especifican en la definición de interfaz. 
Internal: Es modificador de acceso para los tipos y miembros de tipo.
Is: Comprueba si un objeto es compatible con un tipo determinado.
Lock: Marca un bloque de instrucciones como una sección crucial, para lo cual utiliza el bloqueo de exclusión mutua de un objeto, la ejecución de una instrucción y, posteriormente, la liberación del bloqueo.
Long: Es un tipo entero que almacena valores según el tamaño.
Namespace: Esta palabra se utiliza para declarar un ámbito que contiene un conjunto de objetos relacionados. Puede utilizar un espacio de nombres para organizar elementos de código y crear tipos globales únicos.
New: En C#, new se puede utilizar como operador, modificador o restricción.
Null: Es un literal que representa una referencia nula, es decir, que no apunta a ningún objeto.
Object: En el sistema de tipos unificado de C#, todos los tipos se heredan directa o indirectamente de Object.
Operator: Es para sobrecargar un operador integrado o proporcionar una conversión definida por el usuario en una declaración de clase o struct.
Out: Puede utilizar la palabra clave contextual out en dos contextos, como un modificador de parámetro o en las declaraciones de parámetro de tipo genérico en interfaces y delegados.
Override: Es necesario para ampliar o modificar la implementación abstracta o virtual de un método, propiedad, indizador o evento heredado.
Params: Usando esta palabra se puede especificar un parámetro de método que acepta un número variable de argumentos.
Private: Es un modificador de acceso de miembros. Los miembros privados sólo son accesibles dentro del cuerpo de la clase o struct en los que se declaran.
Protected: Es un modificador de acceso a miembros. Un miembro protegido es accesible dentro de su clase y por instancias de clases derivadas. Encontrará una comparación de protected con los otros modificadores de acceso en Niveles de accesibilidad.
Public: Es un modificador de acceso para tipos y miembros de tipos. No existen restricciones para obtener acceso a los miembros públicos.
Readondly: Corresponde a un modificador que se puede utilizar en campos. Cuando una declaración de campo incluye un modificador readonly.
Ref: Hace que un argumento se pase por referencia, no por valor. 
Return: La instrucción return termina la ejecución del método en el que aparece y devuelve el control al método que realizó la llamada.
Sealed: Cando se aplica a una clase, impide que otras clases se hereden de él.
Short: Es un tipo de datos integral que almacena valores según el tamaño.
Sizeof: Es para obtener el tamaño en bytes de un tipo no administrado. 
Stackalloc: Se utiliza en un contexto de código no seguro para asignar un bloque de memoria en la pila.
Static: Es para declarar un miembro estático.
String: Representa una secuencia de cero o más caracteres Unicode. 
Struct: Es un tipo de valor que normalmente se usa para encapsular pequeños grupos de variables relacionadas, como las coordenadas de un rectángulo o las características de un elemento en un inventario.
This: Hace referencia a la instancia actual de la clase y también se utiliza como modificador del primer parámetro de un método de extensión.
Throw: Se usa para indicar una situación anómala durante la ejecución del programa.
Unsafe: Denota un contexto no seguro, que es necesario para cualquier operación que involucre a punteros.
Ushort: Indica un tipo de datos integral que almacena valores según el tamaño y el intervalo.
Using: Tiene dos usos principales: Como directiva, cuando se utiliza para crear un alias para un espacio de nombres o para importar tipos definidos en otros espacios de nombres. Y como instrucción, cuando define un ámbito al final del cual el objeto se destruye.
Virtual: Se utiliza para modificar un método, propiedad, indizador o declaración de evento y permite invalidar cualquiera de estos elementos en una clase derivada.
Void: Especifica que el método no devuelve un valor.
Volatile: Indica que varios subprocesos que se ejecutan a la vez podrían modificar un campo.
While: Ejecuta una instrucción o un bloque de instrucciones repetidamente hasta que una expresión especificada se evalúa como false.
Solution: Una solution no es una "respuesta". Es simplemente un contenedor para uno o más proyectos relacionados, junto con información de compilación, configuraciones de ventana de Visual Studio y cualquier otro archivo que no esté asociado con un proyecto en particular. 
