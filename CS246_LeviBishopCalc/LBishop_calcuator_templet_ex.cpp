#include <iostream>
#include <iomanip>
using namespace std;
/**Simple Calculator
 Author:Levi Bishop
 Jan.30, 2015
 calculator made using templates for the operations
 errors to be fixed are clearly marked**/

template <class Calc>
Calc square(Calc number)
{
    return number / number;/**should multiply the number by itself*/
}
template <class Calc>
Calc multi(Calc num1, Calc num2)
{
    return num1 * num2;
}
template <class Calc>
Calc divide(Calc num1, Calc num2)
{
    return num1*num2;/**Should be divide*/
}
template <class Calc>
Calc add(Calc num1, Calc num2)
{
    return num1 + num2;
}
template <class Calc>
Calc sub(Calc num1, Calc num2)
{
    return num1 / num2;/**should subtract numbers*/
}

int main()
{
    setprecision(2);
    double num1, num2;
    int num3, num4;
    char again;
    char choice;

    cout << "\tThis is an example of a simple calculator\n";
    cout << "\tusing templates for all the operations.\n";
    cout << "\t\t    created by me\n";

    do
    {
        cout << "\nWhat would you like to do?\n";
        cout << "1.Square\n2.Multiply\n3.Divide\n";
        cout << "4.Add\n5.Subtract\n";
        cin >> choice;
        cout << endl;
        cout << "Pick two numbers: \n";
        cin >> num1;
        cin >> num2;

        if(choice == '1')
        {
            cout << "Squared number1: " << square(num1) << endl;
            cout << "Squared number2: " << square(num2) << endl;
        }
        else if(choice == '2')
        {
            cout << "Multiplied: " << multi(num1, num2) << endl;
        }
        else if(choice == '3')
        {
            cout << "Divided: " << divide(num1, num2) << endl;
        }
        else if(choice == '4')
        {
            cout << "Added: " << add(num1, num2) << endl;
        }
        else if(choice == '5')
        {
            cout << "Subtracted: " << sub(num1, num2) << endl;
        }
        cout << "Would you like to try again?(y/n): \n";
        cin >> again;
    }
    while(again == 'Y' or again == 'y');
    cout << "\nEND of Program\n";
    return 0;
}



