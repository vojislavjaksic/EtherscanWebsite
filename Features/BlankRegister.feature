Feature: BlankRegister
	As a user
	If I leave required fields blank 
	I should get an error message

Scenario: User leaves all mandatory fields blank and should get error messages
When user clicks on register button with all mandatory fields left blank
Then the he should get an error message 'Please accept our Terms and Conditions.'
