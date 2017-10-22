/////////////////////////////////////
// Problem 11	 Convert Speed Units
/////////////////////////////////////


//This is stuped program for 1 hour speed low from time equal 59' 59''

#include <iostream>
using namespace std;

int main() {
	int meters;
	int hour;
	int minutes;
	int seconds;

	cout << "Distance: ";
	cin >> meters;
	cout << "Hour: ";
	cin >> hour;
	cout << "Minutes: ";
	cin >> minutes;
	cout << "Seconds: ";
	cin >> seconds;

	cout << "Meter pur second   => ";
	int timeSeconds = ((hour * 60) + minutes) * 60 + seconds;
	if (timeSeconds == 0) {
		cout << "Error: not Diveade to NULL";
	}
	else {
		cout << (float)meters / timeSeconds << " MPS"<< endl;
	}

	cout << "Kilometer pur hour => ";
	float kilometers = (float)meters / 1000;
	float timeHour = (float)timeSeconds / 3600;
	
	if (timeHour == 0) {
		cout << "Error: not Diveade to NULL";
	}
	else {
		cout << kilometers / timeHour << " KPH" << endl;
	}

	cout << "Miles pur hour     => ";
	float miles = kilometers * 1.603;
	
	if (timeHour == 0) {
		cout << "Error: not Diveade to NULL";
	}
	else {
		cout << miles / timeHour << " MPH" << endl;
	}
	system("pause");
	return 0;
}
