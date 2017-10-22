////////////////////////////////////////
// Problem 12	Rectangle Properties
////////////////////////////////////////

#include <iostream>
#include <cmath>
using namespace std;

int main() {
	double a;
	double b;

	cout << "Enter width, a =  ";
	cin >> a;
	cout << "Enter height, b = ";
	cin >> b;

	cout << "P = " << 2 * (a + b) << endl;
	cout << "S = " << a * b << endl;
	cout << "d = " << sqrt(a * a + b * b) << endl;

	system("pause");
	return 0;
}