# Abstract Factory
**Segment:** Creational

## Usage
- Abstract Factory is considered a Factory of Factories. Think of it as a bundler, things will have a context, but they may differ slightly between them. At the end they are groupable but not the same thing.
- An Abstract Factory allows us to return Factories to create all the types of things in a given bundle.
- We will be using the exemple that follows to explain Abstract Factory Pattern: Movies and Series can be inserted in a bundle called 'Watchable', because well... you watch both of them. But they are not the same. Movies are usually longer and are standalone projects, whereas Series are usually shorter in duration but are divided in episodes and seasons.

## Building Parts
- **Abstract Factory:** Interface to create **Abstract Products**. **Concrete Factories** use this Interface.
- **Concrete Factory:** Implements **Abstract Factory** to create **Products** returned as **Abstract Products**.
- **Abstract Product:** Interface that represents the **Product** that will be returned by a **Concrete Factory**
- **Product:** Created by a **Concrete Factory**

## Pros and Cons
- **Pros:**
    - Isolates the Concrete Classes from clients
    - Simplifies interchanging Products Families
    - Promotes products consistency

- **Cons:**
    - Makes creating new slightly different products hard
    - A large number of products families will result in an excess of concrete factory classes