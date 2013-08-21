Feature: AccountInfo
	In order to use the info in my app(s)
	As an API developer
	I want to get account info

@mytag
Scenario: Good Account Info
	Given the following Account Info API response '{"jsonrpc":"2.0","id":"1","result":{"from_email":"support@example.com","created_on":"2013-07-31 15:17:59","from_name":"Example User","login":"support@example.com"}}'
	When I send an account info request
	Then the from name should be 'Example User'
	And the from email should be 'support@example.com'
	And the login should be 'support@example.com'
	