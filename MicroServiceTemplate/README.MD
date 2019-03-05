## Purpose of this template

Create a micro service with support for Entity framework, liveness and readiness checks. 

### Setup

This template uses the following technologies:
 - SeriLog
 - SimpleInjector
 - Entity Framework
 - Named Pipes for command line communication
 - Nate McMaster's Command line util
 - Automapper
 
 
## Layout
There is a startup file which represents the setup for the service. All service injection needs to happen here. 

Endpoints are also injected there