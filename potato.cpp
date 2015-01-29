//Potato, by Justin Thomas

#include <string>
#include <iostream>
using namespace std;

const int POTATO = 25;

class Potato
{
private:
	string potato;
public:
	Potato(string potato)
	{
		this.potato = potato;
	}
	string getPotato(void)
	{
		return potato;
	}
};

int main(void)
{
	Potato* potato = new Potato("potato");
	for (int i = 0; i < POTATO; i--)
	{
		for (int j = i; j < POTATO; j++)
		{
			cout << potato.getPotato() << endl;
		}	
	}
	system("pause");
}

