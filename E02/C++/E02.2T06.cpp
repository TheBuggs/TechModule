/////////////////////////////////////////////
// Lab 6.	Interval of Numbers
/////////////////////////////////////////////

#include <iostream>
using namespace std;

void Swap(int &a, int &b) {
	int temp = a;
	a = b;
	b = temp;
}

int main() {

	int number1;
	int number2;

	cout << "number: ";
	cin >> number1;
	cout << "number: ";
	cin >> number2;

	if (number1 < number2) {
		Swap(number1, number2);
	}

	int temp = number2;
	while (temp != number1) {
		cout << temp++ << endl;
	}
	cout << number1 << endl;
	system("pause");
	return 0;
}