# **Behavioral Patterns Homework**

## **Iterator**


### Мотивация:
Идеята на итератор шаблона е, да поеме отговорността за достъп до и преминаването през обектите от колекция, и да я постави в итератор обекта. Той ще запази състояние на итерация, като ще следи настоящия обект и ще има начин за идентификация на следващите обекти за итерация. Накратко, итераторът предлага начин за последователен достъп до елементите на композитен обект, без да излага на показ неговата скрита репрезентация.

### Цел:
Абстракцията, която предоставя итераторът, разрешава модифицирането на имплементацията на дадена колекция, без да прави промени извън самата колекция. Позволява създаването на GUI компонент за обща употреба, който ще може да итерира всяка колекция на апликацията.


### Участници:

Класовете и обектите, които участват в този шаблон са:

**Итератор** (Абстрактен итератор)
* дефинира интерфейс за достъп до и обикаляне на елементи.

**Конкретен Итератор** (Итератор)
* имплементира интефейса на итератора.
* следи настоящата позиция в обикалянето на композитния обект.

**Агрегат** (Абстрактна колекция)
* дефинира интерфейс за създаване на обект **Итератор**.

**Конкретен Агрегатор** (Колекция)
* използва интерфейса за създаване на **Итератор**, за да върне инстанция на правилния **Конкретен Агрегатор**.
 
Структурен C# код:

```c#
using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Iterator.Structural
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
 
            // Create Iterator and provide aggregate
            ConcreteIterator i = new ConcreteIterator(a);
 
            Console.WriteLine("Iterating over collection:");
 
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
 
            // Wait for user
            Console.ReadKey();
        }
    }
 
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
 
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();
 
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
 
        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }
 
        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
 
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
 
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;
 
        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }
 
        // Gets first iteration item
        public override object First()
        {
            return _aggregate[0];
        }
 
        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
            {
                ret = _aggregate[++_current];
            }
 
            return ret;
        }
 
        // Gets current iteration item
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }
 
        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}
```

Реална имплементация в C#:
```c#
using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Iterator.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");
 
            // Create iterator
            Iterator iterator = new Iterator(collection);
 
            // Skip every other item
            iterator.Step = 2;
 
            Console.WriteLine("Iterating over collection:");
 
            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
 
            // Wait for user
            Console.ReadKey();
        }
    }
 
    /// <summary>
    /// A collection item
    /// </summary>
    class Item
    {
        private string _name;
 
        // Constructor
        public Item(string name)
        {
            this._name = name;
        }
 
        // Gets name
        public string Name
        {
            get { return _name; }
        }
    }
 
    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
 
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();
 
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
 
        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }
 
        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
 
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
 
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;
 
        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }
 
        // Gets first item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }
 
        // Gets next item
        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }
 
        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
 
        // Gets current iterator item
        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }
 
        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
```

#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/iterator.gif)



## **Strategy**


### Мотивация:
Има чести ситуации, в които класовете се различават само по своето поведение. Добра идея при подобни случаи е, алгоритмите да бъдат изолирани в отделни класове, за да се предостави възможност за избирането на различни алгоритми по време на runtime.

### Цел:
Дефинира семейство алгоритми, енкапсулира всяко едно семейство и ги прави разменими помежду си. Позволява на алгоритъма независима вариация от клиентите, които го използват.

 
### Участници:

Класовете и обектите, които участват в този шаблон са:

**Стратегия** (Стратегия за сортиране)
* декларира общ интерфейс за всички поддържани алгоритми. Контекстът използва този интерфейс за да извика алгоритъма, дефиниран като **Конкретна стратегия**
 
**Конкретна стратегия** (QuickSort, ShellSort, MergeSort)
* имплементира алгоритъма, използвайки интерфейса **Стратегия**

**Контекст** (Сортиран списък)
* бива конфигуриран чрез обект от тип **Конкретна стратегия**.
* запазва референция към обект от тип **Стратегия**.
* може да дефинира интерфейс, който позволява на обект от тип **Стратегия** да достъпва неговите данни.
 
Структурен C# код:

```c#
using System;
 
namespace DoFactory.GangOfFour.Strategy.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Strategy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      Context context;
 
      // Three contexts following different strategies
      context = new Context(new ConcreteStrategyA());
      context.ContextInterface();
 
      context = new Context(new ConcreteStrategyB());
      context.ContextInterface();
 
      context = new Context(new ConcreteStrategyC());
      context.ContextInterface();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Strategy' abstract class
  /// </summary>
  abstract class Strategy
  {
    public abstract void AlgorithmInterface();
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ConcreteStrategyA : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyA.AlgorithmInterface()");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ConcreteStrategyB : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyB.AlgorithmInterface()");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ConcreteStrategyC : Strategy
  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyC.AlgorithmInterface()");
    }
  }
 
  /// <summary>
  /// The 'Context' class
  /// </summary>
  class Context
  {
    private Strategy _strategy;
 
    // Constructor
    public Context(Strategy strategy)
    {
      this._strategy = strategy;
    }
 
    public void ContextInterface()
    {
      _strategy.AlgorithmInterface();
    }
  }
}
```

Реална имплементация в C#:
```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Strategy.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Strategy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Two contexts following different strategies
      SortedList studentRecords = new SortedList();
 
      studentRecords.Add("Samual");
      studentRecords.Add("Jimmy");
      studentRecords.Add("Sandra");
      studentRecords.Add("Vivek");
      studentRecords.Add("Anna");
 
      studentRecords.SetSortStrategy(new QuickSort());
      studentRecords.Sort();
 
      studentRecords.SetSortStrategy(new ShellSort());
      studentRecords.Sort();
 
      studentRecords.SetSortStrategy(new MergeSort());
      studentRecords.Sort();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Strategy' abstract class
  /// </summary>
  abstract class SortStrategy
  {
    public abstract void Sort(List<string> list);
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class QuickSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      list.Sort(); // Default is Quicksort
      Console.WriteLine("QuickSorted list ");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ShellSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.ShellSort(); not-implemented
      Console.WriteLine("ShellSorted list ");
    }
  }
 
  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class MergeSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.MergeSort(); not-implemented
      Console.WriteLine("MergeSorted list ");
    }
  }
 
  /// <summary>
  /// The 'Context' class
  /// </summary>
  class SortedList
  {
    private List<string> _list = new List<string>();
    private SortStrategy _sortstrategy;
 
    public void SetSortStrategy(SortStrategy sortstrategy)
    {
      this._sortstrategy = sortstrategy;
    }
 
    public void Add(string name)
    {
      _list.Add(name);
    }
 
    public void Sort()
    {
      _sortstrategy.Sort(_list);
 
      // Iterate over list and display results
      foreach (string name in _list)
      {
        Console.WriteLine(" " + name);
      }
      Console.WriteLine();
    }
  }
}
```

#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/strategy.gif)



## **Obeserver**


### Мотивация:
Това е шаблон, при когото обект, наричан "субект", поддържа списък със своите зависими обекти, наричани "наблюдатели", и ги информира автоматично относно всяка промяна на състояние, често чрез извикване на някой от техните методи.  

### Цел:
Дефинира зависимост от тип "един-на-много" между обекти, така че, когато обектът промени своето състояние, всички тези зависимости биват "уведомени" и автоматично актуализирани. 


### Често използван при:
Имплементация на разпределени системи за управление на събития(events). Основна част от архитектурния шаблон MVC (model-view-controller). Имплементира се при програмни библиотеки и системи, включително почти всички GUI комплекти от инструменти.
 
### Участници:

Класовете и обектите, които участват в този шаблон са:

**Субект** (Stock)
* познава своите наблюдатели. Всякакъв брой обекти от тип **Наблюдател**, могат да наблюдават субект.
* предоставя интрерфейс за прикачане и разкачане на обекти от тип **Наблюдател**.

**Конкретен Субект** (IBM)
* съхранява необходимото състояние в обект от тип **Конкретен Наблюдател**.
* изпраща уведомление до своите наблюдатели, когато променя състояние.

**Наблюдател** (IInvestor)
* дефинира интерфейс за актуализация на обекти, които трябва да бъдат уведомени за промени при субект.

**Конкретен Наблюдател** (Investor)
* поддържа референция към обект от тип **Конкретен Субект**.
* съхранява състояние, което трябва да остане консистентно със състоянието на субекта.
* прилага интефейс за актуализация на обект от тип **Наблюдател**, за да поддържа неговото състояние консистентно със състоянието на субекта.


 
Структурен C# код:

```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Observer.Structural
{
  /// <summary>
  /// MainApp startup class for Structural 
  /// Observer Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Configure Observer pattern
      ConcreteSubject s = new ConcreteSubject();
 
      s.Attach(new ConcreteObserver(s, "X"));
      s.Attach(new ConcreteObserver(s, "Y"));
      s.Attach(new ConcreteObserver(s, "Z"));
 
      // Change subject and notify observers
      s.SubjectState = "ABC";
      s.Notify();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject' abstract class
  /// </summary>
  abstract class Subject
  {
    private List<Observer> _observers = new List<Observer>();
 
    public void Attach(Observer observer)
    {
      _observers.Add(observer);
    }
 
    public void Detach(Observer observer)
    {
      _observers.Remove(observer);
    }
 
    public void Notify()
    {
      foreach (Observer o in _observers)
      {
        o.Update();
      }
    }
  }
 
  /// <summary>
  /// The 'ConcreteSubject' class
  /// </summary>
  class ConcreteSubject : Subject
  {
    private string _subjectState;
 
    // Gets or sets subject state
    public string SubjectState
    {
      get { return _subjectState; }
      set { _subjectState = value; }
    }
  }
 
  /// <summary>
  /// The 'Observer' abstract class
  /// </summary>
  abstract class Observer
  {
    public abstract void Update();
  }
 
  /// <summary>
  /// The 'ConcreteObserver' class
  /// </summary>
  class ConcreteObserver : Observer
  {
    private string _name;
    private string _observerState;
    private ConcreteSubject _subject;
 
    // Constructor
    public ConcreteObserver(
      ConcreteSubject subject, string name)
    {
      this._subject = subject;
      this._name = name;
    }
 
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      Console.WriteLine("Observer {0}'s new state is {1}",
        _name, _observerState);
    }
 
    // Gets or sets subject
    public ConcreteSubject Subject
    {
      get { return _subject; }
      set { _subject = value; }
    }
  }
}
```

Реална имплементация в C#:
```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Observer.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Observer Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create IBM stock and attach investors
      IBM ibm = new IBM("IBM", 120.00);
      ibm.Attach(new Investor("Sorros"));
      ibm.Attach(new Investor("Berkshire"));
 
      // Fluctuating prices will notify investors
      ibm.Price = 120.10;
      ibm.Price = 121.00;
      ibm.Price = 120.50;
      ibm.Price = 120.75;
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Subject' abstract class
  /// </summary>
  abstract class Stock
  {
    private string _symbol;
    private double _price;
    private List<IInvestor> _investors = new List<IInvestor>();
 
    // Constructor
    public Stock(string symbol, double price)
    {
      this._symbol = symbol;
      this._price = price;
    }
 
    public void Attach(IInvestor investor)
    {
      _investors.Add(investor);
    }
 
    public void Detach(IInvestor investor)
    {
      _investors.Remove(investor);
    }
 
    public void Notify()
    {
      foreach (IInvestor investor in _investors)
      {
        investor.Update(this);
      }
 
      Console.WriteLine("");
    }
 
    // Gets or sets the price
    public double Price
    {
      get { return _price; }
      set
      {
        if (_price != value)
        {
          _price = value;
          Notify();
        }
      }
    }
 
    // Gets the symbol
    public string Symbol
    {
      get { return _symbol; }
    }
  }
 
  /// <summary>
  /// The 'ConcreteSubject' class
  /// </summary>
  class IBM : Stock
  {
    // Constructor
    public IBM(string symbol, double price)
      : base(symbol, price)
    {
    }
  }
 
  /// <summary>
  /// The 'Observer' interface
  /// </summary>
  interface IInvestor
  {
    void Update(Stock stock);
  }
 
  /// <summary>
  /// The 'ConcreteObserver' class
  /// </summary>
  class Investor : IInvestor
  {
    private string _name;
    private Stock _stock;
 
    // Constructor
    public Investor(string name)
    {
      this._name = name;
    }
 
    public void Update(Stock stock)
    {
      Console.WriteLine("Notified {0} of {1}'s " +
        "change to {2:C}", _name, stock.Symbol, stock.Price);
    }
 
    // Gets or sets the stock
    public Stock Stock
    {
      get { return _stock; }
      set { _stock = value; }
    }
  }
}
```

#### UML диаграма:

![UML](http://www.dofactory.com/images/diagrams/net/observer.gif)



