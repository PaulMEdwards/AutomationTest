Feature: Geolocation
	In order to determine visitor device location
	So we can deliver location specific services
	I will test a browser Geolocation example implementation
	
@Geolocation @Allowed
Scenario: Geolocate authorized by user
	Given I visit the Geolocation page
	When I click the Where am I? button
	Then User's Lat/Long coordinates are displayed and viewable on Google Maps