Feature: Dynamic
	In order to test Dynamic Controls changed asynchronously
	As an Automated Test
	I will exercise two examples

@DynamicControls
Scenario: Remove and Add checkbox control
	Given I visit the Dynamic Controls example page
	And I toggle the checkbox
	When I click the "Remove" button
	Then Observe loading animation shown then hidden
	And Confirm checkbox removal
	When I click the "Add" button
	Then Observe loading animation shown then hidden
	And Confirm checkbox added

@DynamicControls
Scenario: Enable and Disable text input control
	Given I visit the Dynamic Controls example page
	When I click the "Enable" button
	Then Observe loading animation shown then hidden
	And Confirm text input "enabled"
	And I input "random" text
	When I click the "Disable" button
	Then Observe loading animation shown then hidden
	And Confirm text input "disabled"


#Tests for observed Bugs in UAT

@Ignore
@DynamicControls @Bug
Scenario: Bug: lingering checkbox DIV(s) on multiple Remove/add operations
	Given I visit the Dynamic Controls example page
	When I click the "Remove" button
	Then Observe loading animation shown then hidden
	And Confirm checkbox removal
	When I click the "Add" button
	Then Observe loading animation shown then hidden
	And Confirm checkbox added
	When I click the "Remove" button
	Then Confirm checkbox removal

@Ignore
@DynamicControls @Bug
Scenario: Bug: loading animations not hidden if interacting with Checkbox Remove/add before Text Input Enable/disable
	Given I visit the Dynamic Controls example page
	When I click the "Remove" button
	Then Observe loading animation shown then hidden
	When I click the "Add" button
	Then Observe loading animation shown then hidden
	When I click the "Enable" button
	Then Observe loading animation shown then hidden
	And Confirm text input "enabled"
	When I click the "Disable" button
	Then Observe loading animation shown then hidden
	And Confirm text input "disabled"