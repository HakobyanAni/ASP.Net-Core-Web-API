# ASP.Net-Core Web API

<h3><b> What is Web API? </b></h3>
Before we understand what is Web API, let's see what is an <b>API (Application Programing Interface)</b>. In computer programming, an application programming interface (API) is a set of subroutine definitions, protocols, and tools for building software and applications. To put it in simple terms, API is some kind of interface which has a set of functions that allow programmers to access specific features or data of an application, operating system or other services. Web API as the name suggests, is an API over the web which can be accessed using HTTP protocol. It is a concept and not a technology. We can build Web API using different technologies such as Java, .NET etc. 
The <b>ASP.NET Core Web API</b> is an extensible framework for building HTTP based services that can be accessed in different applications on different platforms such as web, windows, mobile etc.
<ul>The following diagram shows that the <b>system should have four layers:</b>
<li> <b>REST API</b> - The actual interface through which clients can work with our API will be implemented through ASP.NET Core. Route configurations are determined by attributes.</li>
</li><li><b>Business logic (BL)</b> - to encapsulate business logic, we use query processors, only this layer processes business logic. The exception is the simplest validation such as mandatory fields, which will be executed by means of filters in the API.</li>
<li><b>Data Access Layer (DAL)</b> - To access the data, we use the Unit of Work pattern and, in the implementation, we use the ORM EF Core with code first and migration patterns.</li><li><b>Database</b> - Here we store data and nothing more, no logic.</li></ul>
<img src="https://user-images.githubusercontent.com/45730967/54310075-f6652b80-45ea-11e9-90f5-b58af0515f2a.png" width="1720px" height="900px"/>
