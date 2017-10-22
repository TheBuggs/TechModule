/////////////////////////////////////////////////////
// Problem 3.	English Name îf the Last Digit
/////////////////////////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

string EnglishNameLastDigit(int number) {
	string digits[] = { "zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine" };
	return digits[number % 10];
}

int main() {
	int number;
	
	cout << "number = ";
	cin >> number;
	
	cout << "Last digit is " << EnglishNameLastDigit(number) << "!" << endl;
	
	system("pause");
	return 0;
}