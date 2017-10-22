//////////////////////////////////////
// Task 2.  I eat a lot of memory
/////////////////////////////////////

#include <iostream>
#include <string>
#include <vector>
#include <cassert>
#include <sstream>
using namespace std;


int main() {

	vector<string> word;
	vector<int> digit;
	string text;
	int n;

	getline(cin, text);
	cin >> n;

	int length = text.length();

	word.push_back("");
	int count = 0;
	for (int index = 0; index < length; index++) {
		if(text[index] == ' ') {
			word.push_back("");
			count++;
			continue;
		}
		word[count] += text[index];
	}
    
	int * arr = new int[count];
	assert(arr);

	for (int i = 0; i < count + 1; i++) {
		istringstream buffer(word[i]);
		buffer >> arr[i];
	}

	int * sum = new int[count - 1];

	for (int row = 0; row < n; row++) {
		
		for (int index = 0; index <= count; index++) {		

			if (row == 0) {
				sum[index] = 0;
			}

			if (row % 2 != 0) {
				sum[index] += arr[count - index];
				continue;
			}
			sum[index] += arr[index];
		}
	}

	for (int j = 0; j <= count; j++) {
		cout << sum[j] << " ";
	}

	system("pause");
	return 0;
}