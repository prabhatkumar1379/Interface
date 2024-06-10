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
Ans:Interfaces are use to build application that are flexible basically it helps us to achieve loose coupling there by components can be replaced with alternative
implimenttations interface are the reasons why we are able to write flexible applications using design patterns and solid principles interface helps to 
add new changes easily it means you can design the applications in a way that it welcomes changes without breaking it helps us in creating an application that you 
can extend easily without modifying its original code base you can enhance its functionality with new plugins or modules the stability of your application 
lot to do with good design interface helps you to create a design that supports testability i believe that it greatly helps us in reading the code as well 
to understand what the class does you do not need to go to the detail looking at the interface you can mostly figure out at high level what the code does as
you will come to know interface is an abstraction and helps to focus on higher-level functionality it basically defines the what and  the class deriving from it defines 
the how.
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
