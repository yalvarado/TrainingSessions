# Test Object Types

## Dummy Object

 Dummy objects are passed around but never actually used. Usually they are just used to fill parameter lists.


 ## Fake Objects

Fake objects actually have a working implementation, but usually they take some shortcut which makes them not suitable for production (an in memory database is a good example).


## Mock Objects

objects pre-programmed with expectations which form a specification of the calls they are expected to receive.


## Stub Objects

Stubs provide canned answers to calls made during the test, usually not responding at all to anything outside what's programmed in for the test.


## Spy Objects

Spies are stubs that also record some information based on how they were called. One form of this might be an email service that records how many messages it was sent.

