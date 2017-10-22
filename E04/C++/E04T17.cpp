#include <iostream>
using namespace std;

int main() {
	int start;
	int end;

	cout << "Start: ";
	cin >> start;
	cout << "End: ";
	cin >> end;

	for (int i = start; i <= end; i++) {
		cout << (char)i << "  ";
	}
	cout << endl;
	system("pause");
	return 0;
}