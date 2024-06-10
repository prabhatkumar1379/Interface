# Interface
c#Interface

<h3>Q.1>Interface does ot have the implimentation it only has the method signature then why do we need this?</h3>
<h4>public interface ISpeaker</h4>
 <p>internal interface IPaymentMode</p>
   <span>
    <p>{</p> 
   <p> void MakePayment();</p>
   <p>}</p>
   </span>

<p dir="auto">
Interfaces are used to build flexible applications by helping us achieve loose coupling, allowing components to be replaced with alternative implementations. Interfaces are essential for writing flexible applications using design patterns and SOLID principles. They make it easier to incorporate new changes, meaning you can design applications to accommodate changes without breaking them. This approach helps create applications that can be easily extended without modifying the original codebase. You can enhance functionality with new plugins or modules, and the stability of your application greatly depends on good design.

Interfaces contribute to creating designs that support testability. They make code easier to read and understand, as you don't need to delve into details to grasp what a class does. By looking at the interface, you can generally figure out the high-level purpose of the code. An interface is an abstraction that helps focus on higher-level functionality, defining the "what," while the class deriving from it defines the "how."
</p>
# Project without using Interface

- [DemoWithOutInterFace](#table-of-contents)
  - [CreaditCardPayment.cs](#goals)
  - [DebitCardPayment.cs](#goals)
  - [GooglePay.cs](#goals)
  - [PaymentManager.cs](#goals)
  - [PhonePay.cs](#fluentpos)
  - [Program.cs](#fluentpos)
<img src="https://github.com/prabhatkumar1379/Interface/blob/main/StaticFile/SolutionImg.PNG" alt="Constructor-in-C#-Types-img1" width="900" height="563" class="blend-mode">
