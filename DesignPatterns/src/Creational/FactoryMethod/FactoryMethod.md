# Factory Method
**Segment:** Creational

## Usage
- The objective is very similar to a SimpleFactory: hide the object creation details from the client.
- It differs from a SimpleFactory because it's more flexible. It can handle more levels of abstraction. Instead of only hiding the creation of the GhibliFilm, we can hide the creation details of different streaming services to watch a GhibliFilm. Each streaming service can have its unique GhibliFilms.

**OBS:** No it's not two Simple Factories attached, as said before Factory Method is way more flexible because the ConcreateCreators know how to instanciate the correct class.

## Building Parts
- **Product:** Defines the type of the objects produced by the Factory
- **Concrete Product:** It's the product that the Factory will create, implements **Product** (Interface/Abstract Class)
- **Creator:** Interface/Abstract Class of the Factory, declares the **Factory Method** (which will create the **Concrete Product** of a certain **Product** type)
- **Concreate Creator:** Implements the **Creator** (Interface/Abstract Class) and overwrites the **FactoryMethod** to create a especific **Concrete Product** type.