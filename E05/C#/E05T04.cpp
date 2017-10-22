///////////////////////////////////////////
// Problem 4.	Numbers in Reversed Order
///////////////////////////////////////////

#include <iostream>
#include <vector>
#include <string>
using namespace std;


// Last digit can't zero, bonus function
int RevercedDigits(int number) {
	vector<int> container;

	int index = 0;
	while (number % 10) {
		container.push_back(number % 10);
		number /= 10;
		index++;
	}

	number = 0;
	for (int i = 0; i < index; i++) {
		number += container.back() * (int)pow(10, i);
		container.pop_back();
	}
	return number;
}

void const PrintRevercedDigits(string digits){
	int length = digits.length();
	cout << "reverced: ";
	while (length) {
		cout <<digits[length--];
	}
	cout << digits[length] << endl;
}

int main() {

	string number;
	cout << "number: ";
	cin >> number;

	PrintRevercedDigits(number);
	system("pause");
	return 0;
}