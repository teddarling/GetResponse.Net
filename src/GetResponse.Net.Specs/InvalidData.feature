Feature: InvalidData
	In order to check for invalid request data
	As an API developer
	I want to receive an error

@mytag
Scenario: Invalid Parameters
	Given an invalid params API response, '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'
	When I request the ping API method
	Then the error message should be "Invalid params"
	And the error code should be -32602
	
Scenario: Api parse error
	Given a parse error API response, '{"jsonrpc":"2.0","error":{"message":"Parse error","code":-32700},"id":null}'
	When I request the ping API method
	Then the error message should be "Parse error"
	And the error code should be -32700
	
Scenario: Api sends unsuccessful status response
	Given an unsuccessful status code, 500
	When I request the ping API method
	Then the status code should be 500