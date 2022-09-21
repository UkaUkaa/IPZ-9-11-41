#include <iostream>
using namespace std;

class First {
public:
	bool foot = true;
	bool hand = true;
	
};

class Two: public First {
public:
	bool head = true;

	bool change_foot() {
		if (foot)
		{
			return foot = false;
		}
		else {
			return foot = true;
		}
	}

	void get() {
		cout << "foot: " << foot << " hand: " << hand << " head: " << head << endl;
	}

};

class temp : public Two {

};

int main() {

	temp obj;
	obj.get();
	obj.change_foot();
	obj.get();
	obj.change_foot();
	obj.get();

	return 0;
}
