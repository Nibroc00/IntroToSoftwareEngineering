Feature: Weather Station


@mytag
Scenario: Request1
	When the Weather Information System sends a request (report)
	Then the SatComms should send acknowledge
	And the SatComms should reply (report)

Scenario: Request2
	When the SatComms sends a reportWeather()
	Then the WeatherStation should send acknowledge
	And the WeatherStation should send (report)