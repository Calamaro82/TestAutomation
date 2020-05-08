# Westpac Practical Assignment

## Introduction

This project was created as a response to the practical assignment received on May 6, 2020. 

I used the Page Object Model as the design pattern of the framework and Data Driven tests where it was possible.

It consists of two test suites to test different scenarios for the KiwiSaver Retirement Calculator in Westpac's website.

## Technologies

* Selenium WebDriver 3.141.0
* NUnit 3.12.0
* NUnit ConsoleRunner 3.11.1
* Selenium Firefox WebDriver 0.26.0

## Usage

### Prerequisites

* Nuget
* Microsoft .NET Framework 4.7.2
* Firefox

### Setup

To download the packages required by the project execute the following command in the terminal from the test framework folder:

	nuget restore WestpacTestAutomation.sln

After all the packages have been downloaded, execute the following command to build the framework:

	msbuild WestpacTestAutomation.sln

### Configuration

The user can configure the URL in which the tests are going to be executed through the **app.config** file. This file looks like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
		</appSettings>
	</configuration>

To modify the url of any environment change the attribute **value** for the desired environment. For example, to update the prod environment's URL we would modify its entry in the **app.config** file to make it look like this:

	<add key="prod" value="https://updatedUrl.com/" />

To add a new environment:

* Add a new entry inside the **appSetting** section of the file.
* The new entry must follow the same pattern than the default entries.
* The key attribute must be unique and in lower case.

For example, to add a new environment called UAT the **app.config** file would look like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
			<add key="uat" value="https://uat.westpac.co.nz/" />
		</appSettings>
	</configuration>

### Execution

To run the tests the user has to run the following command in the terminal from the test framework folder:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj

Optionally, the user can choose the environment in which the test suites are going to be executed by adding the argument **--params=env=<KEY>** in the command line, like this:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj --params=env=<KEY>

The valid values for the parameter environment correspond to the **keys** defined in the **app.config** file. If no environment is choosen, **prod** is used by default.

### Reports

The test results are saved in an xml file called **TestResult.xml** to ease their reading I included a tool that converts the xml file into an html report. To run it type:

	extent -i <InputTestResultsFile> -o <outputFolderPath>

This will read the results from **InputTestResultsFile** and write the html report in the **outputFolderPath**.