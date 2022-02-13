# Essentials of POO

## CONSTRUCTORS - Expression

Essencialmente serve para proteção e para ter critérios rigorosos/seletivos durante a criação de dados. A flexibilidade do código é fruto dos contrutores.

**sintaxe:** leva o mesmo nome da classe dentro da própria classe.
```c#
public class Pessoa {
  /*fields*/

  public Pessoa( /* parameters */ ){
    /*parameters using fields*/ 
  }

}
```

## OVERLOADING - *Sobrecarga* - Expression

Overloading pode ser usado em **Constructors** e em **Methods** com objetivo de serem implemetações alternativas e simultâneas dos mesmos.

```c#
public class Pessoa {
  /*field1*/
  /*field2*/

  public Pessoa( /* field1 */ ){
    /*parameters using fields*/ 
  }
  public Pessoa( /* filed1 and field2 */ ){
    /*parameters using fields*/ 
  }

}
```

## OVERRIDE - *Sobrescrever* - Keyword

Override é uma sobrescrita de métodos ou funções que acontece, quando um método herdado de uma classe mãe, heverá ter critérios novos na class filha.

Por enquanto vimos apenas na ToString()

## THIS

Faz referência a atributos, métodos ou construtores associados a classe em questão.

## GETTERS AND SETTERS  - Keyword & Expression

> consultar e configurar

Controlam a privacidade dos atributos de uma classe. São importantes para preservar a flexibilidade do código.

## AUTO PROPERTIES

Durante a criação de um atributo de uma classe, podemos usar as autoproperties para já deixar sua privacidade configurada, em casos mais simples.

> **dica:** use o snippet! digite `prop` e depois aperte `tab` duas vezes.

➕ `prop + tab + tab` :
```C#
  public class MyClass {

    public int MyVar {get; set;}

  }
```

Agora que ambos os métodos *get* e *set* já foram configurados, podemos controlar a privacidade deles.

```C#
  public class MyClass {

    public int MyVar {get; private set;}

  }
```

Neste caso por exemplo imagine que a `MyVar` é uma variável que possui uma manipulação mais restritiva e específica, por isso, removemos a propriedade `set` dela, e deixamos apenas a `get` para que seja possível consultar seu valor.

## STATIC

Gera um método ou atributo que não necessita de instância para ser usado. Apenas uma menção a classe basta.

> **observação** Se você criar um objeto e alterar o atributo static, irá alterar para todos os objetos.

➕ `MyClass.cs`
```C#
public class MyClass{

  public static int MyVar;

  public static void MyMethod( ){
    Console.WriteLine("run my method");
  }

}
```

➕ `Apllication.cs`
```C#
public class Application{
  public static void Main(){

    // posso acessar a MyVar sem instanciar um objeto
    Console.WriteLine(Circle.MyVar);
  
    Circle.MyMethod();
  }
}
```