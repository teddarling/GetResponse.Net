Feature: Ping
	In order to test the API connection
	As an API developer
	I want to ping the API

@mytag
Scenario: Add two numbers
	Given I have a valid API key 'valid key'
	When I send a 'ping' request
	Then the result should be 'pong'
