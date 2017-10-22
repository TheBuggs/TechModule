//////////////////////////////////////////
// Problem 3.	Megapixels
//////////////////////////////////////////

#include <iostream>
#include <iomanip>
using namespace std;

const int MP = 1000000;

int main() {
	int height;
	int width;

	cin >> height;
	cin >> width;

	cout << width << "x" << height << " => ";
	cout << fixed << setprecision(1) << (double)(width * height) / (double)MP;
	cout << " MP"<< endl;
	
	system("pause");
	return 0;
}