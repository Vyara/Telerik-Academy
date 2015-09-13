# **Creational Patterns Homework**

## **Singleton**


### Мотивация:
Предполага улеснено изграждене на координация за обекти, ползващи тази инстанция, тъй като нейните променливи ще са еднакви за всички обекти които я извикват. Това е полезно в случаи, в които единствен обект е нужно да координира различни дейности в системата. 

### Цел:
Подсигурява ограничаването на клас до единствен обект и осигурява глобална достъпност до този клас. Гарантира, че всички обекти, използващи този клас, ползват една и съща негова инстанция. 

### Приложение:
Трябва да задоволява принципите на единствена инстанция и глобален достъп. Нуждае се от механизъм за достъп до класовия член без да създава класов обект, както и механизъм за запазване на стонойноста на класов член сред класови обекти. Прилага се чрез създаване на клас с метод, който създава нова инстанция на класа, ако такава не съществува. В противен случай, просто връща референция към този обект. Конструкторът се създава *private*, за да се предотврати инициализирането на обекта по какъвто и да е друг начин.

### Често използван при:
Шаблоните *Abstract Factory*, *Builder*, и *Prototype* могат да използват *Singleton*-и при своето приложение. *Facade* обектите, често биват *Singleton*-и, тъй като е нужен само един *Facade* обект. *Singleton*-те често биват предпочитани пред глобалните променливи, поради факта, че не замърсяват глобалното(или локалното) именно пространство(namespace) с ненужни променливи и разрешават "мързелива" алокация и инициализация, докато глобалните променливи в много езици винаги ще консумират ресурси. 

### Проблеми:
Труден за тестване(tight coupling) и други.
 
Примерен *C#* код:

```
using System;

  class MainApp
  {
 
    static void Main()
    {
      Singleton s1 = Singleton.Instance();
      Singleton s2 = Singleton.Instance();

      if (s1 == s2)
      {
        Console.WriteLine("Objects are the same instance");
      }

      // Wait for user 
      Console.Read();
    }
  }

  // "Singleton" 
  class Singleton
  {
    private static Singleton instance;

    // Note: Constructor is 'protected' 
    protected Singleton() 
    {
    }

    public static Singleton Instance()
    {
      // Use 'Lazy initialization' 
      if (instance == null)
      {
        instance = new Singleton();
      }

      return instance;
    }
  }
}
```

#### UML диаграма:

![UML](http://www.oodesign.com/images/design_patterns/creational/singleton_implementation_-_uml_class_diagram.gif)





## **Builder**


### Мотивация:
Позволява на клиентски обект да конструира сложен обект, чрез определянето на единствено неговите тип и съдържание, като бива предпазен от детайлите, съврзани с репрезентацияа на обекта. По този начин, процесът на конструкция може да бъде ползван за създаването на различни репрезентации. Логиката на този процес е изолирана от точните стъпки, използвани при създаването на сложния обект, с цел процесът да бъде използван отново, за създаването на друг обект от същия набор от прости обекти, от които е създаден и първият.

### Цел:
Дефинира инстанция за създаване на обект но оставя на подкласовете да решат кой клас да инстанциират. Реферира към новосъздадения обект през общ интерфейс.

### Приложение:
Използва се когато алгоритъмът за създаване на сложен обекти независим от частите, които съставляват обекта или когато системата трябва да позволява различни репрезентации за обектите, които биват конструирани.

По-долу приложение с участници:
* *Builder* - абстрактен интерфейс за създаване на части от обект *Product*.
* *ConcreteBuilder* - конструира и сглобява части от продукта като имплементира интерфейса *Builder*. 
* *Director* - конструира сложния обект, използвайки интерфейса *Builder*.
* *Product* - сложният обект, който бива строен.

 
Примерен *C#* код:

```
using System;
using System.Collections;

  public class MainApp
  {
    public static void Main()
    { 
      // Create director and builders 
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products 
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user 
      Console.Read();
    }
  }

  // "Director" 
  class Director
  {
    // Builder uses a complex series of steps 
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder" 
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1" 
  class ConcreteBuilder1 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2" 
  class ConcreteBuilder2 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product" 
  class Product
  {
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
```

#### UML диаграма:

![UML](http://www.oodesign.com/images/creational/builder-pattern.png)



## **Abstract Factory**


### Мотивация:
Представя начин за енкапсулиране на група от индивидуални *Factories*, които имат обща тема, без да специфицира конкретните им класове. Обикновено, клиентският софтуер създава конкретна имплементация на абстрактната фабрика и след това използва *generic* интерфейса на фабриката, за създаването на конкретните обекти, които са част от темата. Клиентът не се интересува и не знае, кои конкретни обекти получава от всяка от тези вътрешни фабрики, тъй като той използва само *generic* интерфейсите на техните продукти. Шаблонът разделя детайлите на имплементацията на група обекти от тяхната обща употреба и разчита на обектова композиция, тъй като създаването е имплементирано в методи които са показани в интерфейса на фабриката.

### Цел:
Предоставя интерфейс за създаване на семейство от свързани обекти, без да специфицира техните класове.

### Приложение:
Използва се когато:
* Системата трябва да бъде независима от начина на създаване на продуктите, с които работи.
* Системата е или трябва да бъде конфигурирана така, че да работи с множество семейства от продукти.
* Семейство продукти е създадено да работи само целовкупно.
* Създаването на библиотеки от продукти, за които е важен само интерфейсът, но не и имплементацията.

По-долу приложение с участници:
* *AbstractFactory* - интерфейс за операции, които създават абстрактни продукти. 
* *ConcreteFactory* - имплементира операции за създаване на конкретни продукти.
* *AbstractProduct* - интерфейс за тип *product* обекти.
* *Product* - определя продукт, който да бъде създаден от съответната *ConcreteFactory*; имплементира интерефейса *AbstractProduct*.
* *Client* - използва интерфейсите, декларирани от класовете *AbstractFactory* и *AbstractProduct*.

 
Примерен *C#* код:

```
using System;

  class MainApp
  {
    public static void Main()
    {
      // Abstract factory #1 
      AbstractFactory factory1 = new ConcreteFactory1();
      Client c1 = new Client(factory1);
      c1.Run();

      // Abstract factory #2 
      AbstractFactory factory2 = new ConcreteFactory2();
      Client c2 = new Client(factory2);
      c2.Run();

      // Wait for user input 
      Console.Read();
    }
  }

  // "AbstractFactory" 
  abstract class AbstractFactory
  {
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
  }

  // "ConcreteFactory1" 
  class ConcreteFactory1 : AbstractFactory
  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB1();
    }
  }

  // "ConcreteFactory2" 
  class ConcreteFactory2 : AbstractFactory
  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB2();
    }
  }

  // "AbstractProductA" 
  abstract class AbstractProductA
  {
  }

  // "AbstractProductB" 
  abstract class AbstractProductB
  {
    public abstract void Interact(AbstractProductA a);
  }

  // "ProductA1" 
  class ProductA1 : AbstractProductA
  {
  }

  // "ProductB1" 
  class ProductB1 : AbstractProductB
  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
    }
  }

  // "ProductA2" 
  class ProductA2 : AbstractProductA
  {
  }

  // "ProductB2" 
  class ProductB2 : AbstractProductB
  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
    }
  }

  // "Client" - the interaction environment of the products 
  class Client
  {
    private AbstractProductA AbstractProductA;
    private AbstractProductB AbstractProductB;

    // Constructor 
    public Client(AbstractFactory factory)
    {
      AbstractProductB = factory.CreateProductB();
      AbstractProductA = factory.CreateProductA();
    }

    public void Run()
    {
      AbstractProductB.Interact(AbstractProductA);
    }
  }
```

#### UML диаграма:

![UML](http://www.oodesign.com/images/creational/abstract-factory-pattern.png)



