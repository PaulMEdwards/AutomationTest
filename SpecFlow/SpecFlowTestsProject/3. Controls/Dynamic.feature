Feature: Dynamic
	In order to test Dynamic Controls changed asynchronously
	As an Automated Test
	I will exercise two examples

@DynamicControls
Scenario: Remove and Add checkbox control
	Given I visit the Dynamic Controls example page
	When I click the checkbox Remove button
	Then Observe loading animation shown then hidden
	And Confirm checkbox removal
	When I click the checkbox Add button
	Then Observe loading animation shown then hidden
	And Confirm checkbox added


@DynamicControls
Scenario: Disable and Enable text input control
	Given I visit the Dynamic Controls example page
	When I click the text input Enable button
	Then Observe loading animation shown then hidden
	And Confirm text input enabled
	When I click the text input Disable button
	Then Observe loading animation shown then hidden
	And Confirm text input disabled
