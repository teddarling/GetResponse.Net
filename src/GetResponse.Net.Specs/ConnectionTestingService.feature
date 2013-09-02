Feature: ConnectionTestingService
	In order to test the GetResponse API connection
	As an API developer
	I want know if the API connection is working

@mytag
Scenario: Valid ping request sent.
	Given an connection testing service API key of 'valid API key'
	And a connection testing return of  '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	And a connection testing service
	When I call ping
	Then the ping result should be '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	
Scenario: Server Error Response.
	Given an connection testing service API key of 'valid API key'
	And a connection testing service status code 500
	And a connection testing service
	When I call ping
	Then the connection testing service should throw an error
	
Scenario: Invalid API key.
	Given an connection testing service API key of 'invalid API key'
	And a connection testing return of  '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'
	And a connection testing service
	When I call ping
	Then the ping result should be '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'