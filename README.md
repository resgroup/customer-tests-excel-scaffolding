# Customer Tests Excel Scaffolding solution

This repository show a basic usage of [Customer Tests Excel](https://github.com/resgroup/customer-tests-excel), and is designed to make it easier to get started.

## Using Customer Tests Excel in a new solution

If you are starting a new solution, you can simply take this solution and add to it.

## Using Customer Tests Excel in an existing solution

If you are modifying an existing solution, the simplest way to get going is as follows:

- Import `CustomerTests.csproj` in to your solution
- Import `SystemUnderTest\Calculator.cs` in to your project.  
- Copy `CreateTests.bat` in to your root folder (one directory up from wherever `CustomerTests.csproj` is)
- Add the namespsace for your project to the `/usings` parameter in `CreateTests.bat` (this is a space delimited list)
- Run `CreateTests.bat`

## Running the tests

- Open the solution and click "Test - Run - All Tests" from the main menu

## Adding your own tests

- Add tests to `CustomerTests\ExcelTests\Sum.xlsx`, or create a new Excel File in `CustomerTests\ExcelTests\`
- Add any required namespsaces to the `/usings` parameter in `CreateTests.bat` (this is a space delimited list)
- Run `CreateTests.bat`
- Open the solution and click "Test - Run - All Tests" from the main menu
