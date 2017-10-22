//////////////////////////////////////////////
// Lab 5.	Word in Plural
//////////////////////////////////////////////

#include <string>
#include <iostream>
using namespace std;

int main() {
	char n[100];
	cout << "Enter text: ";
	cin >> n;
	
	int lenght = 0;
	
	while (n[lenght++] != '\0');
	lenght--;
	char * noun = new char[lenght];    
	
	for (int i = 0; i < lenght; i++)
		noun[i] = n[i];

	char last	 = noun[lenght - 1];
	char befLast = noun[lenght - 2];
	
	char *str, *temp;
	bool stop = false;
	switch (last) {
	case 'y': 
		str = new char[lenght + 2];
		for (int i = 0; i < lenght; i++)
			str[i] = noun[i];
		temp = noun;
		delete[] temp;
		noun = str;
		lenght += 2;
		noun[lenght - 1] = 's';
		noun[lenght - 2] = 'e';
		noun[lenght - 3] = 'i';
		stop = true;
		break;
	case 'o':
	case 's':
	case 'x':
	case 'z':
		str = new char[lenght + 1];
		for (int i = 0; i < lenght; i++)
			str[i] = noun[i];
		temp = noun;
		delete[] temp;
		noun = str;
		lenght += 2;
		noun[lenght - 1] = 's';
		noun[lenght - 2] = 'e';
		stop = true;
		break;
	}


	if (last == 'h' && befLast == 'c' || befLast == 's') {
		str = new char[lenght + 1];
		for (int i = 0; i < lenght; i++)
			str[i] = noun[i];
		temp = noun;
		delete[] temp;
		noun = str;
		lenght += 2;
		noun[lenght - 1] = 's';
		noun[lenght - 2] = 'e';
		stop = true;
	}

	if (!stop) {
		str = new char[lenght + 1];
		for (int i = 0; i < lenght; i++)
			str[i] = noun[i];
		temp = noun;
		delete[] temp;
		noun = str;
		lenght += 1;
		noun[lenght - 1] = 's';
	}

	for (int i = 0; i < lenght; i++) {
		cout << noun[i];
	}
	cout << endl;
    
	temp = noun;
	delete[] temp;

	system("pause");
	return 0;
}
