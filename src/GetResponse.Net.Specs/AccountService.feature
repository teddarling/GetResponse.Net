Feature: AccountService
	In order to manage the account
	As an API developer
	I want to access the account functionality

@mytag
Scenario: Get account info
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"from_email":"support@example.com","created_on":"2013-07-31 15:17:59","from_name":"Example User","login":"support@example.com"}}'
	And an account service
	When I call GetInfo
	Then the account service result should be the account service return value
	
Scenario: Get account from fields
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"nvsd":{"email":"admin2@example.com","created_on":"2013-08-18 19:59:42","name":"Example User2"},"nSRA":{"email":"support@example.com","created_on":"2013-07-31 15:17:59","name":"Example User"}}}'
	And an account service
	When I call GetFromFields
	Then the account service result should be the account service return value
	
Scenario: Get account from field
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"nvsd":{"email":"admin2@example.com","created_on":"2013-08-18 19:59:42","name":"Example User2"}}}'
	And an account service
	When I call GetFromField with a value of 'nvsd'
	Then the account service result should be the account service return value
	
Scenario: Add account from field
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"FROM_FIELD_ID":"abc123","added":1}}'
	And an account service
	And a from name of 'Add Name'
	And a from email of 'addname@example.com'
	When I call AddFromField
	Then the account service result should be the account service return value
	
Scenario: Add account from field with invalid email
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Invalid email syntax","code":-1},"id":"1"}'
	And an account service
	And a from name of 'Add Name'
	And a from email of 'addnamecom'
	When I call AddFromField
	Then the account service result should be the account service return value
	
Scenario: Get account domains
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"abcd":{"created_on":"2009-01-01 00:00:00","domain":"emailaddress.com"},"efgh":{"created_on":"2009-01-02 00:00:00","domain":"otheremailaddress.com"}}}'
	And an account service
	When I call GetDomains
	Then the account service result should be the account service return value
	
Scenario: Get account domain
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"abcd":{"created_on":"2009-01-01 00:00:00","domain":"emailaddress.com"},"efgh":{"created_on":"2009-01-02 00:00:00","domain":"otheremailaddress.com"}}}'
	And an account service
	And a domain id of 'abcd'
	When I call GetDomain with the domain id
	Then the account service result should be the account service return value
	
Scenario: Get account customs
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"abcd":{"name":"age","content_type":"number","input_type":"text","is_hidden":"no"},"efgh":{"name":"comment","content_type":"string","input_type":"textarea","is_hidden":"yes"},"ijkl":{"name":"likes_food","content_type":"string","input_type":"multi_select","is_hidden":"no","contents":["meat","fruits"]}}}'
	And an account service
	When I call GetCustoms
	Then the account service result should be the account service return value
	
Scenario: Add account custom
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"added":1,"CUSTOM_ID":"p8n4"}}'
	And an account service
	And the following customs data		
		| Name        | ContentType | InputType | IsHidden | Contents |
		| custom_name | string      | text      | false    |          |
	When I call AddCustom
	Then the account service result should be the account service return value
	
Scenario: Add account custom name already taken
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Name already taken","code":-1},"id":"1"}'
	And an account service
	And the following customs data		
		| Name        | ContentType | InputType | IsHidden | Contents |
		| custom_name | string      | text      | false    |          |
	When I call AddCustom
	Then the account service result should be the account service return value
	
Scenario: Add account custom missing contents
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Missing contents","code":-1},"id":"1"}'
	And an account service
	And the following customs data		
		| Name       | ContentType | InputType | IsHidden | Contents |
		| test_radio | string      | radio     | true     |          |
	When I call AddCustom
	Then the account service result should be the account service return value
	
Scenario: Set account custom content
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"added":2,"deleted":1}}'
	And an account service
	And custom Id of 'p8n4'
	And custom contents of 'value 1', 'value 2' and 'value 3'
	When I call SetCustomContent
	Then the account service result should be the account service return value
	
Scenario: Set account custom content not selectable input type
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Not selectable input type","code":-1},"id":"1"}'
	And an account service
	And custom Id of 'p8n4'
	And custom contents of 'value 1', 'value 2' and 'value 3'
	When I call SetCustomContent
	Then the account service result should be the account service return value
	
Scenario: Set account custom content missing custom
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Missing custom","code":-1},"id":"1"}'
	And an account service
	And custom Id of 'p8n5'
	And custom contents of 'value 1', 'value 2' and 'value 3'
	When I call SetCustomContent
	Then the account service result should be the account service return value
	
Scenario: Delete account custom
	Given a account service return value '{"jsonrpc":"2.0","id":"1","result":{"deleted":1}}'
	And an account service
	And custom Id of 'p8n4'
	When I call DeleteCustom
	Then the account service result should be the account service return value
	
	
Scenario: Delete account custom missing custom
	Given a account service return value '{"jsonrpc":"2.0","error":{"message":"Missing custom","code":-1},"id":"1"}'
	And an account service
	And custom Id of 'p8n5'
	When I call DeleteCustom
	Then the account service result should be the account service return value