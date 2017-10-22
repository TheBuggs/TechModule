///////////////////////////////
// Problem 8.	Center Point
///////////////////////////////


#include <iostream>
using namespace std;

int main() {
	int x1, y1, x2, y2;
	cout << "x1 = ";
	cin >> x1;
	cout << "y1 = ";
	cin >> y1;
	cout << "x2 = ";
	cin >> x2;
	cout << "y2 = ";
	cin >> y2;

	int d1, d2;

	d1 = x1 * x1 + y1 * y1;
	d2 = x2 * x2 + y2 * y2;

	if (d1 < d2) {
		cout << "(" << x1 << ", " << y1 << ")\n";
	}
	else {
		cout << "(" << x2 << ", " << y2 << ")\n";
	}
	system("pause");
	return 0;
}