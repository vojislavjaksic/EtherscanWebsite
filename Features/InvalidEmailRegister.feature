Feature: InvalidEmailRegister
	As a user
	I want to be able to type in an invalid email
	so I can get an error message

Scenario: User should be able to type in an invalid email and see an error message
When fills the email field with 'mail44!@#$'
Then the he should get an 'Please enter a valid email address.' message
