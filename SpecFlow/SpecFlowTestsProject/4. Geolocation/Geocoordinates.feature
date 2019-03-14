Feature: Geolocation
	In order to determine visitor device location
	So we can deliver location specific services
	I will test a browser Geolocation example implementation

@Geolocation @Blocked
Scenario: Geolocate explicitly blocked by user
	#Click "Where am I?" button.
	#Explicitly block geolocate request permission.
	#Geolocate not performed. No change in page.
	#Confirm subsequent page visits are automatically blocked.
	Given A
	And B
	When C
	Then D
	
@Geolocation @Blocked
Scenario: Geolocate automatically blocked by browser
	#Click "Where am I?" button.
	#Close permission request dialog.
	#Geolocate not performed. No change in page.
	#Repeat prior 3 steps at least 3 times.
	#Confirm geolocate permission no longer requested on 3rd attempt due to browser automatically setting it to blocked based on user action on prior attempts.
	Given A
	When C
	Then D
	
@Geolocation @Allowed
Scenario: Geolocate authorized by user
	#Click "Where am I?" button.
	#Grant geolocate permission on request dialog.
	#Geolocate performed, user's Lat/Long coordinates displayed, Google maps link offered.
	#Current page replaced with Google Maps page showing user's current location.
	Given A
	When C
	Then E