### Mail Container Test 

The code for this exercise has been developed to manage the transfer of mail items from one container to another for processing.

#### Process for transferring mail

- Lookup the container the mail is being transferred from.
- Check the containers are in a valid state for the transfer to take place.
- Reduce the container capacity on the source container and increase the destination container capacity by the same amount.

#### Restrictions

- A container can only hold one type of mail.


#### Assumptions

- For the sake of simplicity, we can assume the containers have an unlimited capacity.

### The exercise brief

The exercise is to take the code in the solution and refactor it into a more suitable approach with the following things in mind:

- Testability
- Readability
- SOLID principles
- Architectural design of the code

You should not change the method signature of the MakeMailTransfer method.

You should add suitable tests into the MailContainerTest.Test project.

There are no additional constraints, use the packages and approach you feel appropriate, aim to spend no more than 2 hours. Please update the readme with specific comments on any areas that are unfinished and what you would cover given more time.

### Some Exercise comments from Ben

A lot of code was moved out of the service class to other classes and interfaces introduced to de-couple things as much as possible.
Added a few unit tests under the test project to give a flavour of how I write my tests. With more time I would have written tests
for all the classes under the Concretes folder that I introduced.

Unit tests hava not be written for the MailTransferService class. With a bit more time I would have written some unit tests by mocking
the interfaces injected into the constructor of MailTransferService and crafting the tests from there. 

In the same service class mentioned above, the wrapper interface for working with config files(in .NetCore environment) was injected
into the constructor as well.

NB: There will be a few files that I could notstop git from tracking in my environemt so those should be ignored.