////////////////////////////////////
// Problem 3.	Miles to Kilometers
////////////////////////////////////

#include <iostream>
#include <iomanip>
using namespace std;

const double MILE = 1.60934;

double Kilo2Mile(double km) {
	return km * MILE;
}

int main() {
	cout << "Kilometers: ";
	double km;
	cin >> km;

	cout << "Miles: "<< fixed << setprecision(5)<< Kilo2Mile(km) << endl;
	system("pause");
	return 0;
}