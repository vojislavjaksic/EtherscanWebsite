Feature: InvalidPasswordRegister
	As a user
	I want to be able to type in an password shorter than 8 characters
	so I can get an error message

Scenario: User should be able to type in a password shoter than 8 characters and see an error message
When user fills the email field with 'mail44!@#$' and fills password field with 'pass123' password 
Then the he should able get an 'Your password must be at least 8 characters long.' message
