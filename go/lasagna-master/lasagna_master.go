package lasagna

func PreparationTime(layers []string, minutesPerLayer int) int {
	if minutesPerLayer == 0 {
		minutesPerLayer = 2
	}
	return len(layers) * minutesPerLayer
}

func Quantities(layers []string) (int, float64) {
	var gramsOfNoodles int
	var litersOfSauce float64
	for _, v := range layers {
		if v == "noodles" {
			gramsOfNoodles += 50
		} else if v == "sauce" {
			litersOfSauce += 0.2
		}
	}
	return gramsOfNoodles, litersOfSauce
}

func AddSecretIngredient(friendsList []string, myList []string) {
	myList[len(myList)-1] = friendsList[len(friendsList)-1]
}

func ScaleRecipe(amountsFor2 []float64, portions int) []float64 {
	var amounts []float64
	for _, v := range amountsFor2 {
		amounts = append(amounts, v/2*float64(portions))
	}
	return amounts
}
