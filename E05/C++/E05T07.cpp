//////////////////////////////////////////////
// Problem 7.	Primes in Given Range
//////////////////////////////////////////////

#include <iostream>
#include <cmath>
#include <list>
using namespace std;

list<int> FindPrimesInRange(long start, long end) {
	list<int> li;
	for (int i = start; i < end; i++) {

		bool isPrime = true;

		if (i < 2) {
			continue;
		}	
		for (int j = 2; j * j <= i; j++) {
			if (i % j == 0) {
				isPrime = false;
				break;
			}
		}
		if (isPrime) {
			li.push_back(i);
		}
	}
	return li;
}

int main() {
	int start, end;
	cout << "start: ";
	cin >> start;
	cout << "end: ";
	cin >> end;

	list<int> li = FindPrimesInRange(start, end);
	while (!li.empty()) {
		cout << li.front() << ", ";
		li.pop_front();
	}
	system("pause");
	return 0;
}