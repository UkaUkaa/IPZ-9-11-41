#include <iostream>
using namespace std;


class numer {
private:
	int num1;
	int num2;

public:
	numer(){
		num1 = 1;
		num2 = 3;
	}

	numer(int iMain) {
		num2 = iMain;
	}

	int operator-(numer temp) {
		num tempInt;

		tempInt = temp.num1 + 5;
		return tempInt;
	}

	numer operator+(numer temp) {
		numer fTemp;

		fTemp.num1 = num1 + temp.num2;
		return fTemp;
	}


	void get() {
		cout << num1 << " " << num2;
	}
};

int main() {
	numer one; // num1 = 5
	numer two(12); // num2 = 10
	numer three; // num1 = 5 num2 = 3

	three = one + two;
	three.get();


	return 0;
}


