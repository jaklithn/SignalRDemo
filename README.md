# SignalR Demo

This will demonstrate how WebSocket can be used in a couple of scenarios.

## Projects
### 1. Demo.Web
An ASP.Net MVC application with SignalR installed on client and server.
Several views to show websocket used in different scenarios.

### 2. Demo.Client
A console application that hooks in to the Demo.Web server to listen to websocket messages.

### 3. Demo.WinApp
A simple Windows Forms application to interact with the Demo.Web application.
In this scenario it is mainly used to feed the different use cases with data.
By using the same authorization as the web application with forms authentication and cookie the WinApp application is also able to register with user privileges.

## UseCases
- Chat: Standard example with a simple chat
- Progress: Simple example on how to feedback server side progress to the client
- Trigger: Demonstrates how other server code is able to hook into the hub instance to trigger a push
- Broadcast: Send notifications to clients that will show up as neat popup windows.
- Lunch: Live menu pushed to screens. Direct the browser manually to /Lunch and push updated menus from WinApp client.
- Publish/Subscribe: Let user Peter in one browser subscribe for data on some machines. Let admin user Anders publish from other browser.
- Dashboard: Demonstrate live metering. Feed sample data from WindowsForms client.
- Map: Display live rendering of vehicle positions. Feed sample data from WinApp client. Note: You must first generate and add your own Google Api key to the web page!

## Startup
There are three users: Anders, Kalle and Peter. Anders is Admin. They all have password: 123
The Map usecase will need a key that can be obtained from Google. Look in the code to find directions.

## Sharp
Most of the demo is based on SignalR but there is also one example with an alternative simplified approach.
It uses Nuget lib websocket-sharp for server side and plain Javascript WebSocket on client side.
Direct your browser manually to "/Sharp" to run that example.
On server side you will find the corresponding code in classes SocketServerHost and DemoSocket. SocketServerHost is initiated in Startup.
The limitation with websocket-sharp is:
a. You don't get the automatic mapping of connection to corresponding user
b. You don't get the helpful classes from SignalR Clients object that helps you to target: All, Others, Users, Groups, ..
c. You don't have the helpful dynamic mapping of method names between client and server
On the other hand you get a simple but effective setup that will work in many scenarios and also have the benefit of working on more platforms.
