///////////////////////////////////////////////
// Task 12.		Master Numbers
///////////////////////////////////////////////

#include <iostream>
using namespace std;

bool IsPalindrom(int);
bool SumOfDigits(int);
bool ContainsEvenDigit(int);

int main() {
    
	int n;
	cin >> n;

	for (int i = 0; i < n; i++) {
		if (IsPalindrom(i) && SumOfDigits(i) && ContainsEvenDigit(i)) {
			cout << i << endl;
		}
	}

	system("pause");
	return 0;
}

bool IsPalindrom(int n) {
	int copyn = n;
	int index = 0;
	
	while (copyn / 10) {
		copyn /= 10;
		index++;
	}
	index++;

	int * arr = new int[index];

	for (int i = 0; i < index; i++) {
		arr[i] = n % 10;
		n /= 10;
	}

	int middle = index / 2;
	for (int i = 0, j = index - 1; i < middle; i++, j--) {
		if (!(arr[i] == arr[j])) {
			delete[] arr;
			return false;
		}
	}
	delete[] arr;
	return true;
}

bool SumOfDigits(int n) {
	int sum = 0;
	while (n / 10) {
		sum += n % 10;
		n /= 10;
	}
	sum += n;
	if (sum % 7 == 0) {
		return true;
	}
	return false;

}

bool ContainsEvenDigit(int n) {
	while (n / 10) {
		if (n % 2 == 0) {
			return true;
		}
		n /= 10;
	}
	return false;
}