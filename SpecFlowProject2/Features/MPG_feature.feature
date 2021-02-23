Feature: MPG
	Simple MPG calculation

@mytag
Scenario: MPG - easy
	Given Miles dirven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8