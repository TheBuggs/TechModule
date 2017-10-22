///////////////////////////////////
// Lab 1. 	Choose a Drink
///////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

int main() {

	string professions[] = { "Athlete", "Bisnessman", "Bisnesswoman", "SoftUni Student" };
	string drings[] = { "Wother", "Coffe", "Coffe", "Beer", "Tea" };

	string profession;
	cout << "Enter profession: ";
	getline(cin, profession);

	bool isSet = false;

	for (int index = 0; index < 4; index++) {
		if (!profession.compare(professions[index])) {
			cout << drings[index] << endl;
			isSet = true;
			break;
		}
	}

	if (!isSet) {
		cout << drings[4] << endl;
	}

	system("pause");
	return 0;
}