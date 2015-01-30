//Potato, by Justin Thomas
//Fixed pointer errors on line 17 and 32, changed to increment on line 28 - James Rogers

#include <string>
#include <iostream>
using namespace std;

const int POTATO = 15;

class Potato
{
private:
	string potato;
public:
	Potato(string potato)
	{
		this->potato = potato;
	}
	string getPotato(void)
	{
		return potato;
	}
};

int main(void)
{
	Potato* potato = new Potato("potato");
	for (int i = 0; i < POTATO; i++)
	{
		for (int j = i; j < POTATO; j++)
		{
			cout << potato->getPotato() << " ";
		}
		cout << endl;
	}
	//system("pause");
}

