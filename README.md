# ASP.Net-Core

<h3><b> What is Web API? </b></h3>
Before we understand what is Web API, let's see what is an <b>API (Application Programing Interface)</b>. In computer programming, an application programming interface (API) is a set of subroutine definitions, protocols, and tools for building software and applications. To put it in simple terms, API is some kind of interface which has a set of functions that allow programmers to access specific features or data of an application, operating system or other services. Web API as the name suggests, is an API over the web which can be accessed using HTTP protocol. It is a concept and not a technology. We can build Web API using different technologies such as Java, .NET etc. 
<p>The <b>ASP.NET Core Web API</b> is an extensible framework for building HTTP based services that can be accessed in different applications on different platforms such as web, windows, mobile etc.</p></br>
<p>The diagram shows that the system will have four layers:<p>

<ul>Database - Here we store data and nothing more, no logic.</ul>
<ul>DAL - To access the data, we use the Unit of Work pattern and, in the implementation, we use the ORM EF Core with code first and migration patterns.</ul>
<ul>Business logic - to encapsulate business logic, we use query processors, only this layer processes business logic. The exception is the simplest validation such as mandatory fields, which will be executed by means of filters in the API.</ul>
<ul>REST API - The actual interface through which clients can work with our API will be implemented through ASP.NET Core. Route configurations are determined by attributes.</ul>
