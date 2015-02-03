#include <iostream>

using namespace std;

int main()
{
    int base, expo, result;
    cout << "Please enter the base number: ";
    cin >> base;
    cout << "\nWhat power would you like to raise it to? ";
    cin >> expo;
    cout << endl << endl;

    result = 1;

    for (int i = 0; i < expo; i++)
    {
        result += base;
    }

    cout << base << " raised to " << expo << " is " << result << "." << endl;

    return 0;
}
