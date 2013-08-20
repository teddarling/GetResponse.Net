Feature: ApiSetup
	In order use the GetResponse API
	As an API developer
	I want access API content

@mytag
Scenario: Null or empty API key
	Given I have an API key, ''
	And I have an API URL, 'http://api2.getresponse.com'
	When I instantiate the API
	Then I should receive an ArgumentNullException
	
Scenario: Null or empty API URL
	Given I have an API key, 'valid key'
	And I have an API URL, ''
	When I instantiate the API
	Then I should receive an ArgumentNullException
	
Scenario: Non empty or null API key and URL
	Given I have an API key, 'valid key'
	And I have an API URL, 'http://api2.getresponse.com'
	When I instantiate the API
	Then I should not receive an Exception