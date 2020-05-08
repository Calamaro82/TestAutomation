# Westpac Practical Assignment

## Introduction

This project was created as a response to the practical assignment received on May 6, 2020. 

I used the Page Object Model as the design pattern of the test automation framework and Data Driven methodology where possible. Both methodologies where chosen because they reduce code duplication and increase its maintainability.

## Technologies

* Selenium WebDriver 3.141.0
* NUnit 3.12.0
* NUnit ConsoleRunner 3.11.1
* Selenium Firefox WebDriver 0.26.0

## Usage

### Prerequisites

* Nuget
* Microsoft .NET Framework 4.7.2
* Firefox 76.0
* Build tools for Visual Studio 2019 or Visual Studio 2019

### Setup

To download the packages required by the project execute the following command in the terminal from the test framework folder:

	nuget restore WestpacTestAutomation.sln

After all the packages have been downloaded, execute the following command to build the framework:

	msbuild WestpacTestAutomation.sln

### Configuration

Configure the URL in which the tests are going to be executed through the **app.config** file. The file looks like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
		</appSettings>
	</configuration>

To modify the URL of any environment, change the attribute **value** for the desired environment. For example, to update the prod environment's URL modify its entry in the **app.config** file to make it look like this:

	<add key="prod" value="https://updatedUrl.com/" />

To add a new environment:

* Add a new entry inside the **appSetting** section of the file.
* The new entry must follow the same pattern as the default entries.
* The **key** attribute must be unique and in lower case.

For example, to add a new environment called UAT the **app.config** file would look like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
			<add key="uat" value="https://uat.westpac.co.nz/" />
		</appSettings>
	</configuration>

### Execution

To run the tests execute the following command in the terminal from the test framework folder:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj

Additionally, the user can choose the environment in which the test suites are going to be executed by adding the argument **--params=env=<KEY>** in the command line, like this:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj --params=env=<KEY>

The valid values for the parameter environment correspond to the **keys** defined in the **app.config** file. If no environment is choosen, **prod** is used by default.

### Reports

By default, the test results are saved in an xml file called **TestResult.xml**. To make reading the test results easier the project includes a tool that converts the xml file into an html report. To generate the report type:

	extent -i <InputTestResultsFile> -o <outputFolderPath>

This will read the results from **InputTestResultsFile** and write the html report in the **outputFolderPath**.