// Package weather provides weather forecasts.
package weather

// CurrentCondition stores the current condition.
var CurrentCondition string

// CurrentLocation stores the current location.
var CurrentLocation string

// Forecast takes the arguments city and condition and returns a string with the current location and current condition.
func Forecast(city, condition string) string {
	CurrentLocation, CurrentCondition = city, condition
	return CurrentLocation + " - current weather condition: " + CurrentCondition
}
