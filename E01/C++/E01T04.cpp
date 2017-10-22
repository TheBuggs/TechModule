//////////////////////////////////
//Problem 4.	Beverage Labels
//////////////////////////////////

#include <iostream>
#include <string>
using namespace std;

void main() {

	string name;

	int cal, liters;
	float mass;

	cout << "Name: ";
	cin >> name;
	cin.get();

	cout << "calory: ";
	cin >> cal;

	cout << "liters: ";
	cin >> liters;

	cout << "mass: ";
	cin >> mass;

	printf("%dml %s:\n%dkcal, %.2fg sugars\n", liters, name.c_str(), cal, mass);
	
	system("pause");
}