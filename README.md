# Automation Test
In order for us to better assess your understanding and use of page objects, frameworks, test cases and coding we ask that you write tests for the following problems. If unable to create a framework write the tests in scripts. Upload to your github/bitbucket or return to us in a zip file. Include instructions on how to setup and run the tests.
1. Write all tests you think necessary for the following form: https://the-internet.herokuapp.com/login
2. Write tests for all three javascript alerts: https://the-internet.herokuapp.com/javascript_alerts
3. Validate dynamic controls - enable/disable input field and checkbox: https://the-internet.herokuapp.com/dynamic_controls
4. Write a test to check the current latitude and longitude: https://the-internet.herokuapp.com/geolocation

## To run, perform the following:
1. Install Visual Studio 2017.
2. Install SpecFlow for Visual Studio 2017 Extension.
3. Clone Repository to local machine.
4. Open Solution in Visual Studio 2017.
5. Enable the Test Explorer window.
   Menu: Test > Windows > Test Explorer
6. Build the Solution.
   NuGet packages should be automatically restored.
7. Might need to build again to see the tests within the Test Explorer.
8. Optionally, right-click the SpecFlowTestProject parent entry in the Test Explorer tree and select "Expand All".
8. Click Run All
9. Optionally, comment out or remove the "@Ignore" tag on the 2 "Bug" tests within the Dynamic section, then save the feature file and run each of those tests manually.
10. View the Test Run Report file from the Tests Output pane.