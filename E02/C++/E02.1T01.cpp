//////////////////////////////////////////////
//Problem 1.	X
//////////////////////////////////////////////

#include <iostream>
using namespace std;

int main() {
	int size;
	cout << "Size: ";
	cin >> size;

	for (int i = 0; i < size; i++) {
		for (int j = 0; j < size; j++) {
			if (i == j || i == size - 1 - j) {
				cout << '*';
			}
			else {
				cout << ' ';
			}
		}
		cout << endl;
	}

	system("pause");

	return 0;
}