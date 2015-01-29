//Potato, by Justin Thomas

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
		this.potato = potato;//Needs to use an arrow, not a dot.
	}
	string getPotato(void)
	{
		return potato;
	}
};

int main(void)
{
	Potato* potato = new Potato("potato");
	for (int i = 0; i < POTATO; i--) // i-- will continually loop this forever. It needs ++ to increment until it reaches potato.
	{
		for (int j = i; j < POTATO; j++)
		{
			cout << potato.getPotato(); // Needs to use an arrow, not a dot. potato is a pointer to an object.
		}
		cout << endl;
	}
	system("pause");
}

