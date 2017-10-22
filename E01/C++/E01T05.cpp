/////////////////////////////////////////////
//Problem 5.	* Character Stats
/////////////////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

int main() {
	
	string name;
	int currentHealth;
	int maxHealth;
	int currentEnergy;
	int maxEnergy;
	cout << "Name: ";
	cin >> name;
	cout << "Current health: ";
	cin >> currentHealth;
	cout << "Maximum health: ";
	cin >> maxHealth;
	cout << "Current energy: ";
	cin >> currentEnergy;
	cout << "Maximum energy: ";
	cin >> maxEnergy;

	cout << "Name: " << name << endl;
	cout << "Health: | ";
	for (int index = 0; index < maxHealth; index++) {
		if (index < currentHealth) {
			cout << "| ";
		}
		else {
			cout << ". ";
		}
	}
	cout << "|\n";

	cout << "Energy: | ";
	for (int index = 0; index < maxHealth; index++) {
		if (index < currentEnergy) {
			cout << "| ";
		}
		else {
			cout << ". ";
		}
	}
	cout << "|\n";

	system("pause");
	return 0;
}