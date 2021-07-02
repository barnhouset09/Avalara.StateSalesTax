# Project: Service.Factories

## Purpose

This project is the location for classes that deal with instantiating objects that don''t come from a database or otherwise greater than linear-level complexity logic.

Mainly used for what would be done in a constructor for the classes being instantiated.

I prefer to keep my data objects without constructors and use services in their place (where applicable). This allows most usages of the "new" keyword to remain in one place and have a somewhat unified pattern.

