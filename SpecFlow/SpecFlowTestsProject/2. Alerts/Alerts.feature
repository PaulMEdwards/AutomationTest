Feature: Alerts
	In order to test JavaScript alerts
	As an Automated Test
	I will exercise the following examples

@Alert @Basic
Scenario: Alert
	Given I visit the JavaScript example alerts page
	When I click the Alert example button
	Then I confirm Alert appears with "I am a JS Alert" text and "OK" input
	And I act upon alert by clicking "OK" button
	And I confirm Result message "You successfuly clicked an alert"


@Alert @Confirm @OK
Scenario: Confirm_OK
	Given I visit the JavaScript example alerts page
	When I click the Confirm example button
	Then I confirm Alert appears with "I am a JS Confirm" text and "OK,Cancel" input
	And I act upon alert by clicking "OK" button
	And I confirm Result message "You clicked: Ok"

@Alert @Confirm @Cancel
Scenario: Confirm_Cancel
	Given I visit the JavaScript example alerts page
	When I click the Confirm example button
	Then I confirm Alert appears with "I am a JS Confirm" text and "OK,Cancel" input
	And I act upon alert by clicking "Cancel" button
	And I confirm Result message "You clicked: Cancel"


@Alert @Prompt
Scenario Outline: Prompt
	Given I visit the JavaScript example alerts page
	When I click the Prompt example button
	Then I confirm Alert appears with "I am a JS prompt" text and "TextBox,OK,Cancel" input
	And I act upon alert by inputting text "<Text>"
	And I act upon alert by clicking "<Button>" button
	And I confirm Result message "<Message>"
Scenarios:
	| Text                                   | Button | Message                                             |
	| ""                                     | OK     | You entered:                                        |
	| TestMonkey                             | Cancel | You entered: null                                   |
	| Infinite Monkeys on Infinite Keyboards | OK     | You entered: Infinite Monkeys on Infinite Keyboards |
	