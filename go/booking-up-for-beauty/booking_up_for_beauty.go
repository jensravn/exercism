package booking

import (
	"fmt"
	"time"
)

// Schedule returns a time.Time from a string containing a date
func Schedule(date string) time.Time {
	t, err := time.Parse("1/2/2006 15:04:05", date)
	if err != nil {
		panic("PANIC")
	}
	return t
}

// HasPassed returns whether a date has passed
func HasPassed(date string) bool {
	t, err := time.Parse("January 2, 2006 15:04:05", date)
	if err != nil {
		panic("PANIC")
	}
	now := time.Now()
	if t.Before(now) {
		return true
	} else {
		return false
	}
}

// IsAfternoonAppointment returns whether a time is in the afternoon
func IsAfternoonAppointment(date string) bool {
	t, err := time.Parse("Monday, January 2, 2006 15:04:05", date)
	if err != nil {
		panic("PANIC")
	}
	h := t.Hour()
	if h < 12 || h > 18 {
		return false
	} else {
		return true
	}
}

// Description returns a formatted string of the appointment time
func Description(date string) string {
	t := Schedule(date)
	diplayDate := t.Format("Monday, January 2, 2006, at 15:04")
	return fmt.Sprintf("You have an appointment on %s.", diplayDate)
}

// AnniversaryDate returns a Time with this year's anniversary
func AnniversaryDate() time.Time {
	year := time.Now().Year()
	dateString := fmt.Sprintf("%d-09-15", year)
	t, _ := time.Parse("2006-01-02", dateString)
	return t
}
