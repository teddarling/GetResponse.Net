Feature: Request
	In order to get a result from the GetResponse API
	As an API developer
	I want to send a request

@mytag
Scenario: Request sent to invalid URL
	Given a request URL 'http://invalidUrl.com'
	And the an api response of '<p>invalid Result</p>'
	And a request api key 'valid api key'
	And the following request data
		| Id | Jsonrpc | Method | params |
		| 1  | 2.0     | ping   |        |
	When I send my request
	Then the response should be the api response

Scenario: Invalid Params
	Given the an api response of '{"jsonrpc":"2.0","error":{"message":"Invalid params","code":-32602},"id":"1"}'
	And a request api key 'valid api key'
	And the following request data
		| Id | Jsonrpc | Method | params |
		| 1  | 2.0     |        |        |
	When I send my request
	Then the response should be the api response

Scenario: Valid Request
	Given the an api response of '{"jsonrpc":"2.0","id":"1","result":{"ping":"pong"}}'
	And a request api key 'valid api key'
	And the following request data
		| Id | Jsonrpc | Method | params |
		| 1  | 2.0     | ping   |        |
	When I send my request
	Then the response should be the api response
	
Scenario: Failure Status Code
	Given an API return code, 500
	And the an api response of ''
	And a request api key 'valid api key'
	And the following request data
		| Id | Jsonrpc | Method | params |
		| 1  | 2.0     | ping   |        |
	When I send my request
	Then the response should throw an 'System.AggregateException'
	
Scenario: No HttpClient provided
	Given a request api key 'valid api key'
	And the following request data
		| Id | Jsonrpc | Method | params |
		| 1  | 2.0     | ping   |        |
	When I send my request with no HttpClient
	Then the response should throw an 'System.AggregateException'
	Then the response should throw an inner exception 'System.NullReferenceException'
