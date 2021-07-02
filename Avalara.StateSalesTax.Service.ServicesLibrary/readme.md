# Project: Service.ServiceLibrary

## Purpose

This project contains all logical code. Each class represents a service that should mainly have one responsibility in terms of the type of work it is doing.

Each service should have an inherited contract interface. This leads to a ton of benefits that lead to better overall code quality in the long run.

## Special Notes

This project utilizes a nuget package called Automapper, which allows entities returned from entity framework to be easily converted into DTO objects.

