Feature: Login
	Check if login functionality works

@Login
Scenario: Login user as Administrator
	Given I navigate to application
	And I click the login link
	When I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then I should see user logged in the application