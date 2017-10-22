///////////////////////////////////
// Problem 2.	Vapor Store
///////////////////////////////////

#include <iostream>
#include <string>
#include <vector>
using namespace std;

const string STOP_COMMAND = "Game Time";

int main(){
	
	vector<string> title = { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition"};
	vector<double> price = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };

	double money;
	cin >> money;
	string text = "";
	vector<string> basket;
	int counter = 0;
	
	while (text.compare(STOP_COMMAND) != 0) {
		if (text.compare("") == 0)
			getline(cin, text);
		cout << "Game Title: ";
		getline(cin, text);
		if (text.compare(STOP_COMMAND) != 0)
			basket.push_back(text);
		
	}
	
	vector<string>::iterator startBasket = basket.begin();
	vector<string>::iterator iterBasket = basket.begin();
	vector<string>::iterator endBasket = basket.end();
	
	vector<string>::iterator startTitle = title.begin();
	vector<string>::iterator iterTitle = title.begin();
	vector<string>::iterator endTitle = title.end();
	
	vector<double>::iterator startPrice = price.begin();
	vector<double>::iterator iterPrice = price.begin();
	vector<double>::iterator endPrice = price.end();

	vector<string> games;
	double total = 0;

	while (iterTitle != endTitle) {
		iterBasket = startBasket;
		while (iterBasket != endBasket) {
			string a = (*iterTitle);
			string b = (*iterBasket);
			double p = (*iterPrice);
			if (a.compare(b) == 0) {
				games.push_back(a);
				total += p;
			}
		    ++iterBasket;
		}
		++iterTitle;
		++iterPrice;
	}


	vector<string>::iterator iterGames = games.begin();
	vector<string>::iterator endGames = games.end();
	
	while (iterGames != endGames) {
		cout << "Name: " << *iterGames << endl;
		++iterGames;
	}
	
	if (total > money) {
		cout << "Out of money!";
	}
	else {
		cout << "Total spend:  $" << total << "  Remainning: $" << money - total << endl;
	}
	
	system("pause");
	return 0;
}