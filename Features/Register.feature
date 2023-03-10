Feature: Successfull registry
	As a user
	I should be able to fill all mandatory fields 
	I should get a message to verify my email if successfull

Scenario: User should be able to create an account
When fills the all required fields
Then the he should be able to create an account 
Then the user should be able to see 'Your account registration has been submitted and is ' message

