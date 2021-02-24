Feature: MPG
	Simple MPG calculation

@mytag
Scenario: MPG - easy
	Given Miles driven is 80
	And Gallons used is 10
	When calc_mpg is called
	Then the fuel efficiency should be 8

Scenario: MPG - medium
	Given Miles driven is 10
	And Gallons used is 80
	When calc_mpg is called
	Then the fuel efficiency should be 0.125

Scenario: MPG - hard
	Given Miles driven is 79
	And Gallons used is 8
	When calc_mpg is called
	Then the fuel efficiency should be 9.875

Scenario: MPG - hard negative
	Given Miles driven is 79
	And Gallons used is -8
	When calc_mpg is called
	Then the fuel efficiency should be -9.875

Scenario: MPG - hard negative negative
	Given Miles driven is -79
	And Gallons used is -8
	When calc_mpg is called
	Then the fuel efficiency should be 9.875


Scenario: Gas Hog
	Given Miles driven is 100
	And Gallons used is 10
	When calc_mpg is called
	Then the car is a gas hog

Scenario: Miles and Gallons Tracker
	Given we add 20.4 miles
	And we add 71 miles
	And we add 3 gallons
	And we add 4.7 gallons
	When get_miles is called
	And get_gallons is called
	Then miles is 91.4
	And gallons is 7.7
