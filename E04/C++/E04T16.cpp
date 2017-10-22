#include <iostream>
#include <iomanip>
using namespace std;

const float EPS = 0.000001f;

void Swap(float&, float&);

int main() {
	float a;
	float b;

	cout << "a = ";
	cin >> a;
	cout << "b = ";
	cin >> b;

	if (a - b < 0) {
		Swap(a, b);
	}

	float res = (float)a - (float)b;

	if (a - b > EPS) {
		cout << "FALSE\tThe diffrrence of " << res << " is  too big (> EPS)\n";
	}
	else if (a - b == EPS) {
		cout << fixed << setprecision(10) << "FALSE\tBorder case.The difference" << res << "== eps. We consider the numbers are different.";
	}
	else {
		cout << "TRUE\tThe difference " << res << " < EPS\n";
	}
	system("pause");
	return 0;
}

void Swap(float &a, float &b) {
	if (a - b < 0) {
		float temp = a;
		a = b;
		b = temp;
	}
}