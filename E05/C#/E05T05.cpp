/////////////////////////////////////////
// Problem 5.	Fibonacci Numbers
/////////////////////////////////////////

#include <iostream>
#include <vector>
using namespace std;

void Fib(int n) {
	
	for (int index = 0, fib1 = 1, fib2 = 1, temp; index <= n; index++) {
		if (index > 1) {
			temp = fib1;
			fib1 = fib1 + fib2;
			fib2 = temp;
			cout << index << " => " << fib1;
		}
		else {
			cout << index << " => " << 1;
		}
		cout << endl;
	}
}

int main() {
	int n;
	cout << "n = ";
	cin >> n;

	Fib(n);
	system("pause");
	return 0;
}