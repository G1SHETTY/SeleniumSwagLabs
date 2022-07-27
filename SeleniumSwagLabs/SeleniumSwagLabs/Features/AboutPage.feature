Feature: AboutPage

Background:  Launch browser and app
Given Chrome is opened and SwagLabs app is opened
When user enter username "standard_user" and password "secret_sauce" and click on login
When  user Clicks on MenuButton 
And user clicks on About Link

Scenario: verification of About Link
	Then it should display the AboutPage

	Scenario: verifying all the option should be visible properly
	Then It Should Display All The Option In Alligned Manner In AboutPage
    
	
	Scenario: verification of company link
	When user Clicks on company link
	Then it should display all the options in company link

	Scenario: verification of news link
	When user Clicks on company link
	And user Clicks on news link
	Then it should be able to access

	Scenario: verification of security link
	When user Clicks on company link
	And user clicks on security
	Then it should be display security page

	Scenario: verification of Resource link
	When user Clicks on Resource link
	Then it should be display all the options of resource 

	Scenario: verification of platform link
	When user Clicks on platform link
	Then it should be  able to access platform

	Scenario: verification of solutions link
	When user Clicks on solutions link
	Then it should be  able to access solution

	Scenario: verification of pricing link
	When user Clicks on pricing link
	Then it should be  able to access pricing

	Scenario: verification of navigation bar
	When user Clicks on back navigation arrow
	Then it should display the home page

	Scenario: verification of Refresh and Forward navigation bar
	When user Clicks on back navigation arrow
	And user clicks on refresh button and forward arrow
	Then it should display the About cross testing page


	