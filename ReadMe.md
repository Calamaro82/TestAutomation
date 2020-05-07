# Westpac Practical Assignment

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

The user can configure the URL in which the tests are going to be executed through the **App.config** file. This file looks like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
		</appSettings>
	</configuration>

To modify the url of any environment change the attribute **value** for the desired environment. For example, to update the prod environment's URL we would modify its entry in the App.config file to make it look like this:

	<add key="prod" value="https://updatedUrl.com/" />

To add a new environment:

* Add a new entry inside the **appSetting** section of the file.
* The new entry must follow the same pattern than the default entries.
* The key attribute must be unique and in lower case.

For example, to add a new environment called UAT the App.config file would look like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
			<add key="uat" value="https://uat.westpac.co.nz/" />
		</appSettings>
	</configuration>

### Usage

To run the tests the user has to run the following command in the terminal from the test framework folder:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj

Optionally, the user can choose the environment in which the test suites are going to be executed by adding the argument **--params=env=<KEY>** in the command line, like this:

	packages\Nunit.ConsoleRunner.3.11.1\tools\nunit3-console.exe WestpacTestAutomation.csproj --params=env=<KEY>

The valid values for the parameter environment correspond to the "keys" defined in the App.config file. If no environment is choosen, "prod" is used by default.