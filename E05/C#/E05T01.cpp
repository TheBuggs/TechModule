//////////////////////////////////////////
//Problem 1.	Hello, Name!
//////////////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

void sayHello(string name) {
	cout << "Hello, " << name << "!" << endl;
}

int main() {

	string name;
	cout << "Enter name: ";
	cin >> name;
	sayHello(name);

	system("pause");
	return 0;
}