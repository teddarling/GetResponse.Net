﻿Feature: ServiceClient
	In order to get data from the GetResponse API
	As an API developer
	I want to get a response when I send a request

Scenario: Invalid URL
	Given an api URL 'http://invalid.com'
	And a request value of '{"id":"1","jsonrpc":"2.0","method":"ping","params":["valid api key"]}'
	And an API return value of '<p>invalid Result</p>'
	When I send a request
	Then the result should not be '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	And the service result should be '<p>invalid Result</p>'

Scenario: Invalid Request
	Given an api URL 'http://api2.getresponse.com'
	And a request value of '{"id":"1","jsonrpc":"2.0","method":"ping","params":["valid api key"]'
	And an API return value of '{"jsonrpc":"2.0","error":{"message":"Parse error","code":-32700},"id":null}'
	When I send a request
	Then the service result should be '{"jsonrpc":"2.0","error":{"message":"Parse error","code":-32700},"id":null}'

Scenario: Valid Request
	Given an api URL 'http://api2.getresponse.com'
	And a request value of '{"id":"1","jsonrpc":"2.0","method":"ping","params":["valid api key"]}'
	And an API return value of '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	When I send a request
	Then the service result should be '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
