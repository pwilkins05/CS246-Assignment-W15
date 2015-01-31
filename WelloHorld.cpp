//Hello World, Jacob Bertsch

//Swapped an H and W above, serious troubleshooting.

//BUG: Output string incorrect

//FIXED: Output not working correctly - Justin Thomas
//FIXED: Errors building program - Justin Thomas


#include <string>
#include <iostream>

using namespace std;

int main(void)
{
	string exampleString = "";

	exampleString += 'H';
	exampleString += 'e';
	exampleString += 'l';
	exampleString += 'l';
	exampleString += 'o';
	exampleString += ' ';
	exampleString += 'W';
	exampleString += 'o';
	exampleString += 'r';
	exampleString += 'l';
	exampleString += 'd';
	exampleString += '!';

	string finalString = "";

	for (int i=1;i<=exampleString.length();i++)
    {
        finalString += exampleString[i];
    }

	cout << finalString << endl;

    return 0;
}
