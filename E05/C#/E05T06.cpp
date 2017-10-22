/////////////////////////////////////
// Problem 6.	Prime Checker
/////////////////////////////////////

#include <iostream>
using namespace std;

bool isPrime(long long n) {
	if (n < 2) {
		return false;
	}
	for (long long i = 2; i * i <= n; i++) {
		if (n % i == 0) {
			return false;
		}
	}
	return true;
}

int main() {
	long long n;
	cout << "number: ";
	cin >> n;
	cout << isPrime(n) << endl;
	system("pause");
	return 0;
}