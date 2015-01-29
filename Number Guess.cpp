#include <iostream>
#include <cmath>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    srand (time(NULL));

    int randomNum = rand() % 20;
    int guess;
    cout << "I will find a random number between 1 and 20" << endl;
    cout << "Try to guess the number and I will tell you if you need to go higher and lower." << endl;

    while (guess != randomNum)
    {
        cin >> guess;

        if (guess <= randomNum)
        {
            cout << "You are too low";
        }
        else if (guess >= randomNum)
        {
            cout << "You are too high";
        }
        else
        {
            cout << "You guessed the number";
        }

        cout << "\n";
    }



}
