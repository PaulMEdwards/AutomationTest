Feature: Login Form
	In order to login to the application
	As a user
	I want to be able to login using assigned credentials
	And must not be able to login with invalid credentials

@login @Valid
Scenario Outline: Login with valid credentials
	Given I visit the login form
	And I input "<Username>" as username and "<Password>" as password
	When I click the Login button
	Then user should be logged in with "<ResultMessage>" and "<Status>"
	And the Secure Area page should load without error
	And the user can logout and return to the login form
Scenarios:
	| Username | Password             | ResultMessage                  | Status  |
	| tomsmith | SuperSecretPassword! | You logged into a secure area! | success |

@login @invalid
Scenario Outline: Attempt login with invalid credentials
	Given I visit the login form
	And I input "<Username>" as username and "<Password>" as password
	When I click the Login button
	Then the user should see the "<ResultMessage>" and "<Status>"
	And the Secure Area page should NOT load
Scenarios:
	| Username | Password             | ResultMessage             | Status |
	| garbage  | SuperSecretPassword! | Your username is invalid! | error  |
	| Null     | SuperSecretPassword! | Your username is invalid! | error  |
	| tomsmith | garbage              | Your password is invalid! | error  |
	| tomsmith | Null                 | Your password is invalid! | error  |