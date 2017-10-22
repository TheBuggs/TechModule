////////////////////////////////////////////
//Problem 14	Integer to Hex and Binary
////////////////////////////////////////////

#include <iostream>
using namespace std;

char dec2Hex(int);

int main() {

	int decimal;
	cout << "Enter decmal number: ";
	cin >> decimal;

	int digit = decimal;
	int arrBin[31];							//represent bits in one int type with 32 binari digits
	int index = 0;
	while (digit / 2 > 0) {
		arrBin[index] = digit % 2;
		digit /= 2;
		index++;
	}
	arrBin[index] = digit;
	
	cout << "\nBIN: ";
	for (int i = index; i >= 0; i--) {
		cout << arrBin[i] << "  ";
	}
	cout << endl;

	digit = decimal;
	index = 0;
	char arrHex[6];							//represent bits in one int type with two charachters

	while (digit / 16 > 0) {
		arrHex[index] = dec2Hex( digit % 16);
		digit /= 16;
		index++;
	}
	arrHex[index] = dec2Hex(digit % 16);
	cout << "HEX: ";
	for (int i = index; i >= 0; i--) {
		cout << arrHex[i] << "  ";
	}
	cout << endl;
	system("pause");
	return 0;
}

char dec2Hex(int digit) {
	if(digit >= 0 && digit < 10){
		return (char)(48 + digit);
	}
	else {
		switch (digit) {
		case 10: return 'A'; break;
		case 11: return 'B'; break;
		case 12: return 'C'; break;
		case 13: return 'D'; break;
		case 14: return 'E'; break;
		case 15: return 'F'; break;
		}
	}
}