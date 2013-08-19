Feature: Ping
	In order to test the API connection
	As an API developer
	I want to ping the API

@ping
Scenario: Get Ping Results
	Given I have a valid API key 'valid key'
	And valid Api URL 'http://api2.getresponse.com'
	And a valid HttpClient with the following response '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	When I send a ping request
	Then the result should be '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'

Scenario: Invalid URL 
	Given I have an invalid API key 'invalid key'
	And valid Api URL 'http://api2.getresponse.com'
	And a valid HttpClient with the following response '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'
	When I send a ping request
	Then the result should be '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'