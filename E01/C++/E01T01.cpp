//////////////////////////////////////
//Problem 1.	Debit Card Number
//////////////////////////////////////
#include <iostream>
#include <string>

using namespace std;
using std::string;

const int ITERATION = 4;

int main() {
	
	cout << "Program 1 iteration 4 times one the same things\n\n";
	bool correct = true;
	int lenght = 0;
	string number;

	for (int counter = 0; counter < ITERATION; counter++) {
		cout << "Please input number greattan from 0 and less than from 10 000...\n";
		do {
			cout << "Enter:";
			cin >> number;

			int index = 0;

			while (number[index] != '\0') index++;

			lenght = index;

			if (index > 4) {
				cout << "Do you can't great than 4 digits\n";
				correct = true;
			}

			for (int index = 0; index < lenght; index++) {
				if ((int)number[index] < 49 || (int)number[index] > 57) {
					cout << "Do you can't have leters and special simbols, only digits\n";
					correct = true;
					break;
				}
			}
			correct = false;
		} while (correct);
		
		string pin = "0000";
		for (int index = 0; index < lenght + 1; index++) {
			if (number[index]) {
				pin[4 - lenght + index] = number[index];
			}
		}
		cout << pin <<"\n\n";
	}

	///////////////////////////////////
	// Create Number from String 
	///////////////////////////////////
	
	/*
	
	int number = 0;							// create number from input string
	int digit = 0;	                		// help var for current digit from string
	int pows = 0;							// help var for power

	for (int i = 0; i < len; i++) {
		digit = (int)pinNumber[i] - 48; 	//From ASCI code get digits
		pows = (int)pow(10, len - i - 1);
		number += digit * pows;
	}

	if (number < 10000) {
		
	}
	cout << number;                 		// print nuber from string

	*/

	system("pause");

	return 0;
}
