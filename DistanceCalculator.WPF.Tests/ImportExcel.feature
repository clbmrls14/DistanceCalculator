Feature: ImportExcel

Scenario: can only import when an import file is specified
	Given a MainWindowViewModel
	When I do nothing
	Then The Import button is disabled

Scenario: can't import with a valid file selected
	Given the file C:\bogus\bogus.txt does not exist
	And a MainWindowViewModel
	When I set the import file to "c:\bogus\bogus.txt"
	Then the Import button is disabled

Scenario: valid file enables import button
	Given the file C:\bogus\bogus.txt does exist
	And a MainWindowViewModel
	When I set the import file to "c:\bogus\bogus.txt"
	Then the Import button is enabled

Scenario: import two items from excel
	Given the file c:\bogus\excelInput.xlsx does exist
	And the following excel content
	| distance | speed | time | 