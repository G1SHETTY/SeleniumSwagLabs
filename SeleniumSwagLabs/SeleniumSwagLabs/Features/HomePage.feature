Feature: HomePageMenuButton

Background:  Launch browser and app
Given Chrome is open and SwagLabs app is opened
When user enters username "standard_user" and password "secret_sauce" and click on Login

Scenario:  Verifying the functionality of Menu Button
     When User clicks on Menu button
	Then it should display all the options in Menu
	

	Scenario:  Verifying the functionality of All Items link
	When User clicks on Menu button
	And User clicks on All Items link
	Then it should display All Items
	

	Scenario:  Verifying the functionality of LogOut link
	When User clicks on Menu button
	And User clicks on Logout link
	Then it should be Logout from the application
	


	Scenario:  Verifying the functionality of Reset App State link
	When User clicks on Menu button
	And User clicks on Reset App State link
	Then it should reset the app state
	

	
	Scenario: Verifying the functionality of  Twitter link
	When user clicks on Twitter link
	Then it should display the Twitter page
	

	Scenario: Verifying the functionality of  Facebook link
	When user clicks on Facebook link
	Then it should display the Facebook page
	

	Scenario: Verifying the functionality of LinkedIn link
	When user clicks on LinkedIn link
	Then it should display the LinkedIn page
    

	Scenario:  Verifying the functionality of CloseMenu Button
    When User clicks on Menu button
	And clicks on Close menu button
	Then it should close the Menu
	
