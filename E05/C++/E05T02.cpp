/////////////////////////////////////////////
// Problem 2.	Max Method
////////////////////////////////////////////

#include <iostream>
using namespace std;

int GetMax(int a, int b) {
	if (a > b)
		return a;
	return b;
}

int main() {

	int a, b, c;

	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;
	cout << "c = ";
	cin >> c;
	cout << "max = " << GetMax(GetMax(a, b), c) << endl;

	system("pause");
	return 0;
}