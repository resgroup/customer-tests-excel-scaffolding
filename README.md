# Customer Tests Excel Scaffolding 

This project exists as a quick and easy way to start using [CustomerTestsExcel](https://github.com/resgroup/customer-tests-excel) in a C# solution.

## Playing / experimenting

You can just download / clone this repo to get a feel for how things work.

- Download / clone this repo
- Install the `CustomerTestsExcel` nuget package to `CustomerTests\CustomerTests.csproj` (This can't be done in advance because you might have different packages path set up in Nuget, and then Nuget gets confused)
- Install the `NUnit3TestAdapter` nuget package to `CustomerTests\CustomerTests.csproj`

Follow the instructions in `Generating the C# tests from Excel` and `Generating the Excel Spreadsheet from the C# tests` below to get a feel for generating the C# tests from the Excel spreadsheet and vice versa.

## Adding to an existing C# solution


### Adding / setting up the scaffold projects

- Download / clone this repo
- Add `CustomerTests\CustomerTests.csproj` to your solution
- Install the `CustomerTestsExcel` nuget package to this project (This can't be done in advance because you might have different packages path set up in Nuget, and then Nuget gets confused)
- Install the `NUnit3TestAdapter` nuget package to this project
- Add `SystemUnderTest\SystemUnderTest.csproj` to your solution
- Run the `Sum_1_and_3` test in `CustomerTests.csproj` (it should just work)
- Add `CreateTests.bat` to your solution, one folder up from wherever you have put `CustomerTests`

### Generating the C# tests from Excel

This is an optional step, but probably why you're here

- Run `CreateTests.bat` to regenerate the `Sum_1_and_3` test (you may need to change the path to the exe)
- Run the `Sum_1_and_3` test again (it should still work after being regenerated)
- You can then change the Excel spreadsheet and regenerate the tests, to confirm that the changes are propogated. The `X`, `Y` and `Result` properties can all be changed without requiring any changes to `SystemUnderTest`. 
- You can also create a new sheet with a variation on the test, to check that a new C# test is generated. Make sure to change the Specification name (Cell B2) to be unique.

### Generating the Excel Spreadsheet from the C# tests

This is an optional step

- Add an `CUSTOMER_TESTS_EXCEL_WRITE_TO_EXCEL` enviroment variable with the value of `true`
- Add an `CUSTOMER_TESTS_RELATIVE_PATH_TO_EXCELTESTS` enviroment variable with the value of `..\..\ExcelTests` (This is the relative path from the output directory of `CustomerTests.csproj` to `CustomerTests\ExcelTests`, and allows you to change the output directory if you so wish)
- Run the `Sum_1_and_3` test in `CustomerTests.csproj`
- Check that `ExcelTests\Sum.xlsx` has been updated and looks sensible
- Run `CreateTests.bat` to make sure that the changes are round trippable.



