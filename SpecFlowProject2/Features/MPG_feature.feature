Feature: MPG
	Simple MPG calculation

@mytag
Scenario: MPG - easy
	Given Miles dirven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8

Scenario: MPG - medium
	Given Miles dirven is 10
	And Gallons used is 80
	When calc_mpg is called
	Then the fuel efficiency should be 0.125

Scenario: MPG - hard
	Given Miles dirven is 79
	And Gallons used is 8
	When calc_mpg is called
	Then the fuel efficiency should be 9.875

Scenario: MPG - hard negative
	Given Miles dirven is 79
	And Gallons used is -8
	When calc_mpg is called
	Then the fuel efficiency should be -9.875

Scenario: MPG - hard negative negative
	Given Miles dirven is -79
	And Gallons used is -8
	When calc_mpg is called
	Then the fuel efficiency should be 9.875

