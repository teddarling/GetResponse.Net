Feature: Ping
	In order to test the API connection
	As an API developer
	I want to test the API using it's test source

@ping
Scenario: Good Result
	Given the following API response '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	When I send a ping request
	Then the result should be 'pong'