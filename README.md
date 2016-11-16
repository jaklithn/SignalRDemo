# SignalR Demo

This will demonstrate how WebSocket can be used in a couple of scenarios.

## Projects
### 1. Demo.Web 
An ASP.Net MVC application with SignalR installed on client and server.
Several views to show websocket used in different scenarios.

### 2. Demo.Client
A console application that hooks in to the Demo.Web server to listen to websocket messages.

### 3. Demo.WinApp
A simple Windows Forms application to interact with the Demo.Web application. It is mainly used to feed the different use cases with data.

## UseCases
- Chat: Classical example
- Progress: Feedbacks server side progress to client
- Trigger push from other server code
- Broadcast notifications
- Lunch live menu
- Publish/Subscribe live data
- Dashboard to display live metering
- Map to display vehicle live positions

## Sharp
Most of the demo is based on SignalR but there is also an example of an alternative approach. It uses Nuget lib websocket-sharp for server side and plain Javascript WebSocket on client side. Look in view "/Sharp" to find that example.

## Startup
There are three users: Anders, Kalle, Peter. Anders is Admin. They all have password: 123
The Map usecase will need a key that can be obtained from Google. Look in the code to find directions.
