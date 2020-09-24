# Customer Tests Excel Scaffolding Project

[![Build status](https://ci.appveyor.com/api/projects/status/er646fyev64lx1uk?svg=true)](https://ci.appveyor.com/project/RESSoftwareTeam/customer-tests-excel-scaffolding)

This project exists as a quick and easy way to start using [CustomerTestsExcel](https://github.com/resgroup/customer-tests-excel) in a C# solution.

You can just download / clone this repo to get a feel for how things work (everything that is supported by the framework is represented at least once in these tests). 

You can also copy the projects in to your own solutions to get started quickly and easily.

### Excel tests

You can look at the files in [SampleTests\ExcelTests](SampleTests\ExcelTests) to get a feel for the syntax for the Excel syntax. 

### C# NUnit tests

You can look at the C# NUnit tests that are created from these excel files. These are in "SampleTests\<Excel Filename>\<Excel Sheet Name>.cs" ([SampleTests\Anova\One Way Anova.cs](SampleTests\Anova\One Way Anova.cs) for example).

There are some generated setup files. Most of these are made by looking at the Excel tests and finding matching interfaces in the SampleSystemUnderTest assembly. These are in [SampleTests\Setup\](SampleTests\Setup\) ([SampleTests\Setup\Cargo.cs for example). 

Sometimes the framework will be able to match some, but not all, properties in Excel with a C# interface. In this case it will generate as much as it can, and leave you do to the rest in a partial class. You can see an example of the generated part of this at [SampleTests\Setup\ClassWithCustomProperty.cs](SampleTests\Setup\ClassWithCustomProperty.cs) and an example of the custom side at [SampleTests\Setup\ClassWithCustomPropertyPartial.cs](SampleTests\Setup\ClassWithCustomPropertyPartial.cs)

Sometimes the framework will match properties in Excel with a C# interface, but you would rather it didn't. In this case you can override the automatically generated file with a custom file. If a file exists called "Override<Excel Class Name>.cs", then the framework will generate "<Excel Class Name>.cs.txt" (instead of a .cs file). You can copy and paste things out of this .txt file if it is convenient, and use it as a reference for how the signature of the custom class should look. You can see an example of the generated .txt file at [SampleTests\Setup\Anything.cs.txt](SampleTests\Setup\Anything.cs.txt) and an example of the custom class at [SampleTests\Setup\OverrideAnything.cs](SampleTests\Setup\OverrideAnything.cs)

The root class of each test has to actually do something, and so will usually be creating an object and calling a function. The framework generates the Setup / Given part of these classes, and leaves you to implement the `When` and `Then` parts in a partial class. You can see an example of the generated part of this at [SampleTests\Setup\AnovaCalculator.cs](SampleTests\Setup\AnovaCalculator.cs) and an example of the custom side at [SampleTests\Setup\AnovaCalculatorPartial.cs](SampleTests\Setup\AnovaCalculatorPartial.cs)

### Generating the C# tests from Excel

Edit the `/assembliesUnderTest` parameter in [SampleTests\GenerateTests.bat](SampleTests\GenerateTests.bat) to point to wherever SampleSystemUnderTest.dll is compiled to on your computer. This is a bit of an annoyance, but is a requirement of the Reflection / Assembly loading in C#.

Then run [SampleTests\GenerateTests.bat](SampleTests\GenerateTests.bat), which will regenerate all the files in [SampleTests\Setup\](SampleTests\Setup\)

### Generating the Excel tests from C#

Set an `CUSTOMER_TESTS_EXCEL_WRITE_TO_EXCEL` enviroment variable with the value of `true`

Set an `CUSTOMER_TESTS_RELATIVE_PATH_TO_EXCELTESTS` enviroment variable with the value of `..\..\..\..\SampleTests\ExcelTests` (This is either an absolute path, or a relative path from the output directory of `CustomerTests.csproj` to `CustomerTests\ExcelTests`)

Run the tests in visual studio (or using `dotnet test`). Whilst running, the tests will recreate the Excel files. This is useful if you want to use C# refactoring tools, to say rename a variable, and then update the Excel files automatically.