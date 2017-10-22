//////////////////////////////////////////
// Lab 2.	Choose a Drink 2.0
/////////////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

int main() {

	string professions[] = { "Athlete", "Bisnessman", "Bisnesswoman", "SoftUni Student" };
	string drings[] = {"Woter", "Coffe", "Coffe", "Beer", "Tea" };
	double prices[] = { 0.70, 1.00, 1.00, 1.70, 1.20 };

	string profession;
	int quantity;
	
	cout << "Enter profession: ";
	getline(cin, profession);

	cout << "Enter quantity: ";
	cin >> quantity;

	bool isSet = false;
	for (int index = 0; index < 4; index++) {
		if (!profession.compare(professions[index])) {
			cout << "The " << profession << " has to pay " << quantity * prices[index] << "." << endl;
			isSet = true;
			break;
		}
	}
	if (!isSet) {
		cout << "The " << profession << " has to pay " << quantity * prices[4] << "." << endl;
	}
	system("pause");
	return 0;
}