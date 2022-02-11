# keywords

## CONSTRUCTORS

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

## OVERLOADING - *Sobrecarga*

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

## OVERRIDE - *Sobrescrever*

Override é uma sobrescrita de métodos ou funções que acontece, quando um método herdado de uma classe mãe, deverá ter critérios novos na class filha.

## GETTERS AND SETTERS

## STATIC