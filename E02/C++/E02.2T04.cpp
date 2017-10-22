/////////////////////////////////////
// Lab 4.	Hotel
/////////////////////////////////////

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {

	double roomStudio[] = { 50, 60, 68, 68, 60, 50, 68 };
	double roomDouble[] = { 65, 72, 77, 77, 72, 65, 77};
	double roomSuite[] = { 75, 82, 89, 89, 82, 75, 89 };

	string months[] = { "May", "June", "July", "August", "September","October", "December" };
	double discount[] = { 0.95, 0.90, 0.85, 0.85, 0.90, 0.95, 0.85 };
	bool bonus[] = { 0, 0, 0, 0, 1, 1, 0 };
	
	string month;
	cout << "Month [5 - 12]: ";
	getline(cin, month);

	short count;								// use very small type
	cout << "Count night [0 - 200]: ";
	cin >> count;
	cin.ignore();

	int index = 0;
	while (month.compare(months[index])) {
		index++;
	}

	double doubleTotalStudio = 0;
	double doubleTotalDouble = 0;
	double doubleTotalSuite = 0;

	if (count > 14 && index == 1 || index== 4 ) {
		doubleTotalDouble = roomDouble[index] * discount[index] * count;
	}

	if (count > 14 && index == 2 || index == 3 || index == 6) {
		doubleTotalSuite = roomSuite[index] * discount[index] * count;
	}

	if (count > 7 && index == 0) {
		doubleTotalStudio = roomStudio[index] * discount[index] * count;
	}

	if (count > 7 && index == 4 || index == 5) {
		// where use the day, bonus.
		doubleTotalStudio = roomStudio[index] * discount[index] * count;
	}

	if (doubleTotalStudio == 0) 	doubleTotalStudio = roomStudio[index] * count;
	if (doubleTotalDouble == 0)		doubleTotalDouble = roomDouble[index] * count;
	if (doubleTotalSuite  == 0)		doubleTotalSuite  = roomSuite[index]  * count;

	cout << fixed << setprecision(2) << "Studio: " << doubleTotalStudio << " lv." << endl;
	cout << fixed << setprecision(2) << "Double: " << doubleTotalDouble << " lv." << endl;
	cout << fixed << setprecision(2) << "Suite:  " << doubleTotalSuite  << " lv." <<  endl;

	system("pause");
	return 0;
}