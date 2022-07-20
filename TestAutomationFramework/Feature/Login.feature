Feature: Login
	User login to home test

@Login
Scenario: Login user as Administrator
	Given I navigate to application
	And I click login link
	When I provide "admin" and "password"
	And I click login button
	Then I should see user logged in the application