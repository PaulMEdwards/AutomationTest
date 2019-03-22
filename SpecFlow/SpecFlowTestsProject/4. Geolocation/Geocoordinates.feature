Feature: Geolocation
	In order to determine visitor device location
	So we can deliver location specific services
	I will test a browser Geolocation example implementation

@Geolocation @Blocked
Scenario: Geolocate explicitly blocked by user
	Given I visit the Geolocation page
	When I click the Where am I? button
	And "Deny" geolocate request permission dialog
	Then Geolocate "is not" performed
	When I click the Where am I? button
	Then Geolocate permission request is not presented
	And Geolocate "is not" performed
	
@Geolocation @Blocked
Scenario: Geolocate automatically blocked by browser
	Given I visit the Geolocation page
	When I click the Where am I? button
	And "Close" geolocate request permission dialog
	Then Geolocate "is not" performed
	When I click the Where am I? button
	And "Close" geolocate request permission dialog
	Then Geolocate "is not" performed
	When I click the Where am I? button
	And "Close" geolocate request permission dialog
	Then Geolocate "is not" performed
	When I click the Where am I? button
	Then Geolocate permission request is not presented
	
@Geolocation @Allowed
Scenario: Geolocate authorized by user
	Given I visit the Geolocation page
	When I click the Where am I? button
	And "Grant" geolocate request permission dialog
	Then Geolocate "is" performed
	And User's Lat/Long coordinates are displayed
	And Google Maps link shows location by returned coordinates