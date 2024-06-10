# Interface
c#Interface

<h3>Q.1>Interface does ot have the implimentation it only has the method signature then why do we need this?</h3>
<h4>public interface ISpeaker</h4>
<p>{</p>
 <p>void Speak(); </p>
<p> }</p>

<p dir="auto">
ANs: Interfaces are used to build flexible applications by promoting loose coupling, which allows components to be easily replaced with alternative implementations. They enable us to write adaptable applications using design patterns and SOLID principles. Interfaces make it easy to add new features and changes without breaking the existing code, allowing applications to be extended with new plugins or modules. Good interface design enhances the stability and testability of applications. It also improves code readability, as interfaces provide a high-level understanding of what a class does without needing to delve into the details. Essentially, interfaces define "what" a class should do, while the class itself defines "how" it does it.
</p>
# Project without using Interface

- [.NET Microservices Boilerplate](#net-microservices-boilerplate)
- [DemoWithOutInterFace](#table-of-contents)
  - [CreaditCardPayment.cs](#goals)
  - [DebitCardPayment.cs](#goals)
  - [GooglePay.cs](#goals)
  - [PaymentManager.cs](#goals)
  - [PhonePay.cs](#fluentpos)
  - [Program.cs](#fluentpos)
  - [How to Run ?](#how-to-run-)
    - [Tye](#tye)
    - [Docker \& Docker-Compose](#docker--docker-compose)
  - [Technologies \& Libraries](#technologies--libraries)
  - [Documentation](#documentation)
  - [Changelogs](#changelogs)
  - [Community](#community)
  - [License](#license)
  - [Support ⭐](#support-)
  - [Code Contributors](#code-contributors)
  - [Financial Contributors](#financial-contributors)
