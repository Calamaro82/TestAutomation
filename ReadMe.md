# Westpac Practical Assignment

## Usage

### Prerequisites

* Nuget
* Microsoft .NET Framework 4.7.2

### Installing

To download the packages required by the project execute the command:

	nuget restore WestpacTestAutomation.sln

After all the packages have been downloaded, execute the following command to build the framework:

	msbuild WestpacTestAutomation.sln

### Configuration

The user can configure the URL in which the tests are going to be executed through the App.config file. This file looks like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
		</appSettings>
	</configuration>

To modify the url of any environment change the attribute value in the environment desired. For example, to update the dev environment's URL we would modify its entry in the App.config file to make it look like this:

	<add key="prod" value="https://updatedUrl.com/" />

To add a new environment:

* Add a new entry inside the appSetting section of the file.
* The new entry must follow the same pattern than the default entries.
* The key attribute must be unique and in lower case.

For example, to add a new environment called UAT the App.config file would look like this:

	<configuration>
		<appSettings>
			<add key="prod" value="https://www.westpac.co.nz/" />
			<add key="uat" value="https://uat.westpac.co.nz/" />
		</appSettings>
	</configuration>
