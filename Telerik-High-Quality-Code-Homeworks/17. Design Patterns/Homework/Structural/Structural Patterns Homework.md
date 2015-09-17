# **Structural Patterns Homework**

## **Façade**


### Мотивация:
Предоставя унифициран и улеснен интерфейс за група от интерфейси в подсистема, или дефинира интерфейс на по-високо ниво, което прави системата по-лесна за ползване. В общия случай, операциите които биха били желани от гледна точка на потребителя, могат да бъдат изградени от различни селекции от части на подсистетмата.

### Приложение:
Фасадният шаблон е лесен за приложение. Използва C# концепцията за именни пространства(namespaces). Класовете в namespace-овете имат възможността да дефинират нивото на достъп като вътрешно или публично. Ако то е дефинирано като вътрешно, членът е видим само в assembly-то, в което именното пространство е компилирано. В много голяма система, клиентският GUI ще бъде в отделно пространство от библиотеката, така че налагането на фасада да е възможно.

### Често използван при:
Фасадите могат да бъдат полезни при различни обстоятелства. Има много случаи, в които компютърна система е изградена от група от независими в широк смисъл подсистеми. Един добре познат случай е компилатор: той се състои от ясно разграничими подсистеми, наречени лексикален анализатор, синтактичен аналазиатор, семантичен анализатор, кодов аналаизатор и няколко оптимизатори. В модерните компилатори, всяка подсистема има много подзадачи. Различните задачи и подзадачи се извикват в последователност, но понякога не са нужни всички. Например, ако възникне грешка при някоя от анализаторските задачи, компилаторът може да не премине в следваща фаза. Скриването на този детайл зад фасада позволява на програма да извика задачи в подсистеми в логически ред, като пренася нужните данни помежду им. 


 
Структурен *C#* код:

```c#
using System;
 
namespace DoFactory.GangOfFour.Facade.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Facade Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public static void Main()
    {
      Facade facade = new Facade();
 
      facade.MethodA();
      facade.MethodB();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassA' class
  /// </summary>
  class SubSystemOne
  {
    public void MethodOne()
    {
      Console.WriteLine(" SubSystemOne Method");
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassB' class
  /// </summary>
  class SubSystemTwo
  {
    public void MethodTwo()
    {
      Console.WriteLine(" SubSystemTwo Method");
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassC' class
  /// </summary>
  class SubSystemThree
  {
    public void MethodThree()
    {
      Console.WriteLine(" SubSystemThree Method");
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassD' class
  /// </summary>
  class SubSystemFour
  {
    public void MethodFour()
    {
      Console.WriteLine(" SubSystemFour Method");
    }
  }
 
  /// <summary>
  /// The 'Facade' class
  /// </summary>
  class Facade
  {
    private SubSystemOne _one;
    private SubSystemTwo _two;
    private SubSystemThree _three;
    private SubSystemFour _four;
 
    public Facade()
    {
      _one = new SubSystemOne();
      _two = new SubSystemTwo();
      _three = new SubSystemThree();
      _four = new SubSystemFour();
    }
 
    public void MethodA()
    {
      Console.WriteLine("\nMethodA() ---- ");
      _one.MethodOne();
      _two.MethodTwo();
      _four.MethodFour();
    }
 
    public void MethodB()
    {
      Console.WriteLine("\nMethodB() ---- ");
      _two.MethodTwo();
      _three.MethodThree();
    }
  }
}
```

### Участници:
Класовете и обектите, които участват в следващия шаблон са:

**Фасадa** (Приложение за изчисляване на ипотечно разплащане)
* знае кои класове от подсистемата отговярат на request.
* делегира request-ите към подходящите обекти.

**Класове в подсистемата** (Банка, Кредит, Заем)
* имплементират функционалност на подсистемата.
* извършва работата, възложена от обекта фасада.
* не знае за фасадата и не пази никаква референция към нея.

Реална имплементация в C#:

```c#
using System;
 
namespace DoFactory.GangOfFour.Facade.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Facade Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Facade
      Mortgage mortgage = new Mortgage();
 
      // Evaluate mortgage eligibility for customer
      Customer customer = new Customer("Jane Doe");
      bool eligible = mortgage.IsEligible(customer, 125000);
 
      Console.WriteLine("\n" + customer.Name +
          " has been " + (eligible ? "Approved" : "Rejected"));
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassA' class
  /// </summary>
  class Bank
  {
    public bool HasSufficientSavings(Customer c, int amount)
    {
      Console.WriteLine("Check bank for " + c.Name);
      return true;
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassB' class
  /// </summary>
  class Credit
  {
    public bool HasGoodCredit(Customer c)
    {
      Console.WriteLine("Check credit for " + c.Name);
      return true;
    }
  }
 
  /// <summary>
  /// The 'Subsystem ClassC' class
  /// </summary>
  class Loan
  {
    public bool HasNoBadLoans(Customer c)
    {
      Console.WriteLine("Check loans for " + c.Name);
      return true;
    }
  }
 
  /// <summary>
  /// Customer class
  /// </summary>
  class Customer
  {
    private string _name;
 
    // Constructor
    public Customer(string name)
    {
      this._name = name;
    }
 
    // Gets the name
    public string Name
    {
      get { return _name; }
    }
  }
 
  /// <summary>
  /// The 'Facade' class
  /// </summary>
  class Mortgage
  {
    private Bank _bank = new Bank();
    private Loan _loan = new Loan();
    private Credit _credit = new Credit();
 
    public bool IsEligible(Customer cust, int amount)
    {
      Console.WriteLine("{0} applies for {1:C} loan\n",
        cust.Name, amount);
 
      bool eligible = true;
 
      // Check creditworthyness of applicant
      if (!_bank.HasSufficientSavings(cust, amount))
      {
        eligible = false;
      }
      else if (!_loan.HasNoBadLoans(cust))
      {
        eligible = false;
      }
      else if (!_credit.HasGoodCredit(cust))
      {
        eligible = false;
      }
 
      return eligible;
    }
  }
}
```
#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/facade.gif)





## **Adapter**

### Мотивация:
Позволява на една система да използва класове, чиито интерфейси не съвпадат напълно с нейните изисквания. Конвертира интерфейса на един клас в друг интерфейс, който клиентът очаква. Адаптерът позволява на класове с иначе несъвместими интерфейси, да работят заедно.  Полезен е за toolkits и libraries. Много примери за адаптерен шаблон включват input/output, защото това е един домейн, който непрекъснато се променя. Например, програми писан през 1980-те биха имала много различен потребителски интерфейс от тези писани през 2000-те. Адаптирането на тези системи към нов хардуер би било много по-рентабилно, от пренаписването им.



 
Структурен *C#* код:

```c#
using System;
 
namespace DoFactory.GangOfFour.Adapter.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Adapter Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create adapter and place a request
      Target target = new Adapter();
      target.Request();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Target' class
  /// </summary>
  class Target
  {
    public virtual void Request()
    {
      Console.WriteLine("Called Target Request()");
    }
  }
 
  /// <summary>
  /// The 'Adapter' class
  /// </summary>
  class Adapter : Target
  {
    private Adaptee _adaptee = new Adaptee();
 
    public override void Request()
    {
      // Possibly do some other work
      //  and then call SpecificRequest
      _adaptee.SpecificRequest();
    }
  }
 
  /// <summary>
  /// The 'Adaptee' class
  /// </summary>
  class Adaptee
  {
    public void SpecificRequest()
    {
      Console.WriteLine("Called SpecificRequest()");
    }
  }
}
```

### Участници:
Класовете и обектите, които участват в следващия шаблон са:

**Цел** (химична смес)
* дефинира специфичния към домейна интерфейс, който **Клиент**ът използва.

**Адаптер** (смес)
* адаптира интерфейса **Адаптиран** към интерфейса **Цел**.

**Адаптиран** (химична банка данни)
* дефинира съществуващ интефейс, който се нуждае от адаптация.

**Клиент** (приложение на адаптера)
* сътрудничи с обекти, съответстващи на интерфейса **Цел** .


Реална имплементация в C#:

```c#
using System;
 
namespace DoFactory.GangOfFour.Adapter.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Adapter Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Non-adapted chemical compound
      Compound unknown = new Compound("Unknown");
      unknown.Display();
 
      // Adapted chemical compounds
      Compound water = new RichCompound("Water");
      water.Display();
 
      Compound benzene = new RichCompound("Benzene");
      benzene.Display();
 
      Compound ethanol = new RichCompound("Ethanol");
      ethanol.Display();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Target' class
  /// </summary>
  class Compound
  {
    protected string _chemical;
    protected float _boilingPoint;
    protected float _meltingPoint;
    protected double _molecularWeight;
    protected string _molecularFormula;
 
    // Constructor
    public Compound(string chemical)
    {
      this._chemical = chemical;
    }
 
    public virtual void Display()
    {
      Console.WriteLine("\nCompound: {0} ------ ", _chemical);
    }
  }
 
  /// <summary>
  /// The 'Adapter' class
  /// </summary>
  class RichCompound : Compound
  {
    private ChemicalDatabank _bank;
 
    // Constructor
    public RichCompound(string name)
      : base(name)
    {
    }
 
    public override void Display()
    {
      // The Adaptee
      _bank = new ChemicalDatabank();
 
      _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
      _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
      _molecularWeight = _bank.GetMolecularWeight(_chemical);
      _molecularFormula = _bank.GetMolecularStructure(_chemical);
 
      base.Display();
      Console.WriteLine(" Formula: {0}", _molecularFormula);
      Console.WriteLine(" Weight : {0}", _molecularWeight);
      Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
      Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
    }
  }
 
  /// <summary>
  /// The 'Adaptee' class
  /// </summary>
  class ChemicalDatabank
  {
    // The databank 'legacy API'
    public float GetCriticalPoint(string compound, string point)
    {
      // Melting Point
      if (point == "M")
      {
        switch (compound.ToLower())
        {
          case "water": return 0.0f;
          case "benzene": return 5.5f;
          case "ethanol": return -114.1f;
          default: return 0f;
        }
      }
      // Boiling Point
      else
      {
        switch (compound.ToLower())
        {
          case "water": return 100.0f;
          case "benzene": return 80.1f;
          case "ethanol": return 78.3f;
          default: return 0f;
        }
      }
    }
 
    public string GetMolecularStructure(string compound)
    {
      switch (compound.ToLower())
      {
        case "water": return "H20";
        case "benzene": return "C6H6";
        case "ethanol": return "C2H5OH";
        default: return "";
      }
    }
 
    public double GetMolecularWeight(string compound)
    {
      switch (compound.ToLower())
      {
        case "water": return 18.015;
        case "benzene": return 78.1134;
        case "ethanol": return 46.0688;
        default: return 0d;
      }
    }
  }
}
```

#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/adapter.gif)



## **Proxy**


### Мотивация:
Предоставя заместител на друг обект, за да контролира достъпа до този обект. Може да бъде интерфейс на множество неща, като например мрежова връзка, голям обект в паметта, файл или друг ресурс, който е скъп или невъзможен за дупликация. Проксито е опаковащ обект, който бива извикан от клиента, за да се достъпи истинския служещ обект зад кулисите.

### Приложение:
Разрешава осигуряването на интерфейс за други обекти, чрез създаването на опаковащ клас като прокси. Този клас, който представлява прокси, може да добави допълнителна функционалност към обекта, без да променя неговия код. 
Примери:
* Добавяне на опция за ограничен достъп до съществуващ обект. В този случай, проксито ще определи, дали клиентът може да достъпи обекта.
* Опростяване на API на сложни обекти.
* Осигуряване на интефейс за дистанционен достъп до ресурси, като например уеб услуга или REST ресурси.

 
Структурен *C#* код:

```c#
using System;
 
namespace DoFactory.GangOfFour.Proxy.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Proxy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create proxy and request a service
      Proxy proxy = new Proxy();
      proxy.Request();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject' abstract class
  /// </summary>
  abstract class Subject
  {
    public abstract void Request();
  }
 
  /// <summary>
  /// The 'RealSubject' class
  /// </summary>
  class RealSubject : Subject
  {
    public override void Request()
    {
      Console.WriteLine("Called RealSubject.Request()");
    }
  }
 
  /// <summary>
  /// The 'Proxy' class
  /// </summary>
  class Proxy : Subject
  {
    private RealSubject _realSubject;
 
    public override void Request()
    {
      // Use 'lazy initialization'
      if (_realSubject == null)
      {
        _realSubject = new RealSubject();
      }
 
      _realSubject.Request();
    }
  }
}
```

### Участници:
Класовете и обектите, които участват в следващия шаблон са:

**Прокси** (математическо прокси)
* запазва референция, която позволява на проксито да достъпи реалния субект. Проксито може да се отнася до **Субект**, ако **Реален Субект** и **Субект** са едни и същи интерфейси.
* предоставя интерфейс, идентичен с този на **Субект**, така че прокси може да бъде заменено с реалния субект.
* контролира достъпа до реалния субект и може да бъде отговорен за неговото създаване или изтриване. 
* други отговорности зависят от вида на проксито:
	* *отдалечените проксита* са отговорни за закодирането на request и неговите аргументи и за изпращаненето на закодирания request до реалния субект в друго адресно пространство.
	* *виртуалните проксита* може да кешират допълнителна информация относно реалния субект, за да отложат достъпването му. Например, **Картинково Прокси** от **Мотивация** кешира обсега на реалната картинка.
	* *предпазни проксита* проверяват дали извкващият обект има разрешения за достъп, нужни за извършването на request.

**Субект** (IMath)
* представлява общият интерфейс за **Реален Субект** и **Прокси**, така че едно **Прокси** може да бъде използвано навсякъде, където се очаква **Реален Субект**.

**Реален Субект** (химична банка данни)
* дефинира релания обект, когото проксито репрезентира.

Реална имплементация в C#:

```c#
using System;
 
namespace DoFactory.GangOfFour.Proxy.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Proxy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create math proxy
      MathProxy proxy = new MathProxy();
 
      // Do the math
      Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
      Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
      Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
      Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject interface
  /// </summary>
  public interface IMath
  {
    double Add(double x, double y);
    double Sub(double x, double y);
    double Mul(double x, double y);
    double Div(double x, double y);
  }
 
  /// <summary>
  /// The 'RealSubject' class
  /// </summary>
  class Math : IMath
  {
    public double Add(double x, double y) { return x + y; }
    public double Sub(double x, double y) { return x - y; }
    public double Mul(double x, double y) { return x * y; }
    public double Div(double x, double y) { return x / y; }
  }
 
  /// <summary>
  /// The 'Proxy Object' class
  /// </summary>
  class MathProxy : IMath
  {
    private Math _math = new Math();
 
    public double Add(double x, double y)
    {
      return _math.Add(x, y);
    }
    public double Sub(double x, double y)
    {
      return _math.Sub(x, y);
    }
    public double Mul(double x, double y)
    {
      return _math.Mul(x, y);
    }
    public double Div(double x, double y)
    {
      return _math.Div(x, y);
    }
  }
}
```

#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/proxy.gif)



