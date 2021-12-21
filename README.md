# Xamarin-with-CSharp-Design-Patterns
Explaining and showcasing all 10 design patterns with real time Xamarin Examples.

## Singleton Design Pattern 
1. Basically we can implement the singleton pattern by ensuring whether a class has only one instance. 
2. This can be done by making the constructor private so that no one can create an object of the singleton class. 
3. Then declare a private variable of class type and initialize it at class scope.
4. Use locking mechanism to avoid deadlock during multi threading action.

## Factory Design Pattern
1. It involves interface or abstract class which is used to replace class constructors, abstracting the process of object generation so that the type of the object instantiated can be determined at run-time.
2. We create the object without exposing the creation logic.
3. In this pattern, an interface is used for creating an object, but let subclass decide which class to instantiate.
4. The creation of object is done when it is required.
5. This pattern allows a class later instantiation to subclasses.
6. This pattern is usually represented by 4 components. i.e., Product, Concrete product, Creator, Concrete creator.
7. Product represents the interface or abstract class.
8. Concrete product represents the class which inherits the interface or abstract class.
9. Creator is an abstract class which declares the factory method, which returns an object of type Product.
10. Creator product is a class which implements the Creator abstract class and overrides the factory method to return an instance of a ConcreteProduct.

## Prototype Design Pattern
1. It is used to create a duplicate object or clone of the current object to enhance performance. 
2. This pattern is used when the creation of an object is costly or complex.
3. It is represented by 2 components. i.e., Prototype, Concrete prototype.
4. Prototype is an interface which is used for the types of object that can be cloned itself.
5. Prototype concrete is a class which implements the Prototype interface for cloning itself.
6. **MemberwiseClone** method is used for cloning of objects.

## Decorator Design Pattern
1. The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.
2. It is used to extend or alter the existing functionality at runtime.
3. This pattern is usually represented by 4 components. i.e., Decorator, Concrete decorator, Component, Concrete component.
4. Decorator defines the interface for all the dynamic functionalities that can be added to the Concrete component.
5. Concrete decorator contains all the functionalities that can be added to the Concrete component. Each needed functionality will be one Concrete decorator class.
6. Component determines the interface of the actual object that needs functionality to be added dynamically to the Concrete components.
7. Concrete component is actual object in which the functionalities could be added dynamically.

## Composite Pattern
1. The Composite pattern is used when data is organized in a tree structure.
2. This pattern is used to separate abstraction from its implementation so that a group of objects and a single object can be modified independently.
3. It is represented by 3 components. i.e., Composite, Component, Leaf.
4. Composite stores and defines the child component behavior and implements child related operations in the Component interface.
5. Component declares the interface for objects in the composition for accessing and managing its child components.
6. Leaf represents a class which is used within the tree structure and this cannot have child elements.

## Adapter Design Pattern
1. The Adapter pattern acts as a bridge between two incompatible interfaces.
2. This pattern involves a single class called adapter which acts as a communication channel between two independent interfaces.
3. This pattern is usually represented by 4 components. i.e., Adapter, Adaptee, Target, Client.
4. Adapter is a class which implements the Target interface and inherits the Adaptee class. It is responsible for communication between Client and Adaptee.
5. Adaptee is a class which has the functionality, required by the client. However, its interface is not compatible with the client.
6. Target is an interface which is used by the client to achieve its functionality/request.
7. Client is a class which interacts with a type that implements the Target interface. However, the communication class called adaptee, is not compatible with the client.

## Bridge Design Pattern
1. Bridge pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class.
2. Both types of classes can be modified independently.
3. This pattern is usually represented by 4 components. i.e., Bridge, Bridge implementation, Abstraction, Redefined abstraction.
4. Bridge is an interface which acts as a channel between the abstraction class and implementer classes.
5. Bridge implementations are classes which implement the Bridge interface and also provide the implementation details for the associated Abstraction class.
6. Abstaction is an abstract class and containing members that define an abstract business object and its functionality.
7. Redefined abstraction is a class which inherits from the Abstraction class.

## Memento Design Pattern
1. Memento is a design pattern used to maintain the state or values of an instance of a class to revert back to that state after updating the values.
2. It provides the ability to do the Undo type of functionality.
3. This pattern is usually represented by 3 components. i.e., Memento, Originator, Caretaker.
4. Memento stores internal state of the Originator object. Originator that produces the memento would be permitted to access the memento's internal state.
5. Originator uses the memento to restore its internal state.
6. Caretaker is a container class, that holds the memento class instance using a property defined in it.

## Strategy Design Pattern
1. Strategy design pattern defines a family of algorithms, encapsulate each one, and make them interchangeable as when required.
2. It allows us to provide an alternative to subclassing the Context class to get a variety of algorithms or behaviours, eliminates large conditional statements and provides a choice of implementations for the same behaviour.
3. This pattern is usually represented by 3 components. i.e., Strategy, Concrete strategy, Context.
4. Strategy declares an interface common to all supported algorithms. Context uses this interface to call the algorithm defined by a Concrete strategy.
5. Concrete strategy implements the algorithm or application logic using the Strategy interface.
6. Context is configured with a ConcreteStrategy object. It maintains a reference to a Strategy object and may define an interface that lets Strategy access it's data.

## Observer Design Pattern
1. The purpose of Observer pattern is to notify the interested observers about some change occurred.
2. We can add more observers in runtime as well as remove them.
3. This pattern is usually represented by 4 components. i.e., Subject, Observer.
4. Subject is used to define an interface to attach or detach one or more observers.
5.  Observer is the object listening to the subject's change.


Reusing objects or data virtualization plays an important role in creating application or individual components. The design pattern helps to regulate this object virtualizing flow resulting to enhanced performance. For an overview of the overall design pattern refer to the below link.

https://www.dotnettricks.com/learn/designpatterns/gang-of-four-gof-design-patterns-in-net
