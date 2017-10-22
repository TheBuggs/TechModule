///////////////////////////////////////////
// Problem 13   Vowel or Digit
///////////////////////////////////////////

#include <iostream>

bool isLeter(char);  
bool isDigit(char);

int main() {
	char vowels[] = { 'a', 'e', 'i', 'o', 'u' };

	bool result = false;

	char symbol = '\0';
	
	std::cout << "Please input one symbol from keyboard!\nPress key: ";
	std::cin >> symbol;

	std::cout << "Key is ";
	if (isLeter(symbol)) {
		for each (char vowel in vowels){
			if (vowel == symbol) {
				std::cout << "VOWEL";
				result = true;
			}
		}
	}

	if (isDigit) {
		std::cout << "DIGIT";
		result = true;
	}

	if (!result) {
		std::cout << "OTHER";
	}
	std::cout << "\n";
	system("pause");

	return 0;
}

bool isDigit(char symbol) {
	if ((short)symbol < 64 && (short)symbol > 120) {
		return true;
	}
	return false;
}

bool isLeter(char symbol) {
	if((short)symbol < 30 && (short)symbol > 40) {
		return true;
	}
	return false;
}