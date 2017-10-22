//////////////////////////////////////////
// Task 8.	* SMS Typing
//////////////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

int main() {

	int n = -1;
	while (n < 0 || n > 30) {
		cin >> n;
	}
	int * leters = new int[n - 1];
	
	for (int i = 0; i < n; i++) {
		cin >> leters[i];
	}

	string msg;
	for (int i = 0; i < n; i++) {
		if (leters[i] == 0) {
			char ch = (char)32;
			msg.push_back(ch);
		}
		else {
			int code = leters[i];
			int arr[3];
			int index = 0;

			while (code / 10 > 0) {
				arr[index++] = code % 10;
				code /= 10;
			}
			code -= 1;
			char ch = (char)((3 * code) + index + 97);
			msg.push_back(ch);
		}
	}
	delete[] leters;
	cout << msg.c_str() << endl;
	
	system("pause");
	return 0;
}