# HelloCastleWindsor
A collection of examples to showcase CastleWindsor dependency injection.

### BasicDI
This project introduces a simplistic example of applying ID in a console project.

### MVP_WithDI
This project illustrates how to leverage DI in a Winforms project that incorporates the MVP pattern.

### OOP_WithDI
This project illustrates how to leverage DI in an object oriented application wherein constructors with parameters can be provided during configuration. 

* The value of the parameters should be known at run time. For example, we can configure the criminal's name as "THE JOKER" during registration if we know the value.
* Two approaches are also demonstrated here to register components using convention while allowing special configurations for individual components (exceptions).

### OOP_WithDI_DynamicParameters
This project illustrates the method to provide component constructor parameter values using information available only at run time using DyanmicParameters. 

* This project demonstrates using DynamicParameter to provide constructor parameter value when the component is created, as compared to when it is registered.
* This requires all information and logic are known during registration. 
* For example, the criminal's name is dynamically time stampped upon creation in the project.

### OOP_WithDI_TypedFactory
This project demonstrates the approaching using a typed factory object registered with the container. The factory can create needed components at runtime. 

* This is the most flexible approach to provide needed components during runtime without having to call container.Resolve multiple times in the code.
  * An abstract factory is registered with the container. 
  * This factory can be injected into a component in its constructor.
* In the project, the criminal's weapon (Handgun) is created by the presenter and passed to the weaponHandler (HandgunHandler) of a criminal component, while the policeman' weapon (FireThrower) is passed to his weaponHandler (FireThrowerHandler). 
  * Notice the weapon is incorporated via composition, as part of the criminal or policeman component.
  * The weapons can be highly configurable during runtime before being assinged to the owner. 
