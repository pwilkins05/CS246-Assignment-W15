#include <iostream>
double calDiscount(double);
using namespace std;
//This program will generate a discount for you based on the starting price you enter
//
//Bugs
/**Fixed by Levi Bishop, Jan 31, 2015*/
int main()
{
    double startingPrice, price;

    cout << "Enter the price for you item, and we will generate your discount." << endl;
    cin >> startingPrice;
    cout << "Your discount is: $" << calDiscount(startingPrice) << endl;
    cout << "Your total will be: $" << startingPrice - calDiscount(startingPrice) << endl;//changed to startingPrice to correct - LB

    return 0;
}
double calDiscount(double price)
{
    double disc = 0, discountAmount = 0;
    if(price <= 50)
    {
        disc = .10;//changed discount from 10 to .10 to correct - LB
        discountAmount = price * disc;
    }
    if(price > 50 && price <= 100)
    {
        disc = .20;
        discountAmount = price * disc;//changed from divide to multiply to correct - LB
    }
    if(price > 100 && price <= 200)
    {
        disc = .35;
        discountAmount = price * disc;
    }
    if(price > 200)
    {
        disc = .50;
        discountAmount = price * disc;
    }
    return discountAmount;
}
