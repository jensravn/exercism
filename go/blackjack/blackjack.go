package blackjack

// ParseCard value =s the integer value of a card following blackjack ruleset.
func ParseCard(card string) int {
	var value int
	switch card {
	case "ace":
		value = 11
	case "two":
		value = 2
	case "three":
		value = 3
	case "four":
		value = 4
	case "five":
		value = 5
	case "six":
		value = 6
	case "seven":
		value = 7
	case "eight":
		value = 8
	case "nine":
		value = 9
	case "ten":
		value = 10
	case "jack":
		value = 10
	case "queen":
		value = 10
	case "king":
		value = 10
	default:
		value = 0
	}
	return value
}

// IsBlackjack value =s true if the player has a blackjack, false otherwise.
func IsBlackjack(card1, card2 string) bool {
	return ParseCard(card1)+ParseCard(card2) == 21
}

// LargeHand implements the decision tree for hand scores larger than 20 points.
func LargeHand(isBlackjack bool, dealerScore int) string {
	var decision string
	switch {
	case !isBlackjack:
		decision = "P"
	case dealerScore < 10:
		decision = "W"
	default:
		decision = "S"
	}
	return decision
}

// SmallHand implements the decision tree for hand scores with less than 21 points.
func SmallHand(handScore, dealerScore int) string {
	var decision string
	switch {
	case handScore >= 17:
		decision = "S"
	case handScore > 11 && dealerScore < 7:
		decision = "S"
	default:
		decision = "H"
	}
	return decision
}
