/////////////////////////////////////////////
// Problem 2.	Rectangle Area
////////////////////////////////////////////

#include <iostream>
#include <iomanip>
using namespace std;

int main() {

	double a, b;

	cout << "Enter size for side A: ";
	cin >> a;

	cout << "Enter size for side B: ";
	cin >> b;

	double result = a * b;

	cout << fixed << setprecision(2) << result << endl;
	
	system("pause");
	return 0;
}