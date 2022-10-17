# card-validation-master


Hello!

Description of the task: This is a Readme file for the Arvato QA engineer interview. As part of the assignment, I should create an unit test framework and an integration test framework.
Here you can find the automation for the unit tests, you can also find the integration test in the link below:
https://github.com/filipeferreira86/CardValidationIntTest

## Unit test
In this repository you will find the unit test framework built on XUnit. The approach for it was to test the methods that validate the individual fields, for each field/method you will find a class that tests that field/method. The result was 4 classes with a total of 27 tests that can be found in the CardValidation.test project inside the CardValidation solution.

## Running the tests

1) You will need to have an IDE to build this test, you can use the Visual Studio.
2) Clone this project to your local repository
3) Open the IDE and build the project
4) Running the tests
  
    4.1) If you're using Visual Studio you can use the test explorer, just clicking on the "Run all" button.
  
    4.2) If you're not using the Visual studio or want to run it on command line or even want to run it on a pipeline, you can run it with the instruction bellow in a command line:
    ```dotnet test --no-build```
