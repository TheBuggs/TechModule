/////////////////////////////////////////
// Lab 3.	Restaurant Discount
/////////////////////////////////////////

// Very imprtan information, i don't use Decimal type in the task

#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main() {

	string nameHall[] = { "Small Hall", "Terrace", "Great Hall" };
	int capacityHall[] = { 50, 100, 120 };
	float priceHall[] = { 2500, 5000, 7000 };
	string servicePackage[] = { "Normal", "Gold", "Platinum" };
	int discountPackage[] = { 5, 10, 15 };
	float pricePackage[] = { 500, 750, 1000 };

	int count;
	string package;

	cout << "Count people: ";
	cin >> count;
	cout << "Package: ";
	cin.ignore();
	getline(cin, package);

	int indexHall = 0;
	while (count > capacityHall[indexHall]) {
		indexHall++;
	}

	int indexPack = 0;
	for (; indexPack < 3; indexPack++) {						//Hardcoded
		if (!package.compare(servicePackage[indexPack])) {
			break;
		}
	}

	double price = priceHall[indexHall] + pricePackage[indexPack];
	double discount = (double)discountPackage[indexPack] * (price / 100);
	price -= discount;	
	price /= count;

	cout << "We can offer you the " << nameHall[indexHall] << " The price per person is ";
	cout << fixed << setprecision(2) << price << "$" << endl;
	
	system("pause");
	return 0;
}