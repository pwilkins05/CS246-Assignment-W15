#include <iostream>
double calDiscount(double);
using namespace std;
//This program will generate a discount for you based on the starting price you enter
//
//Bugs
int main()
{
    double startingPrice, price;

    cout << "Enter the price for you item, and we will generate your discount." << endl;
    cin >> startingPrice;
    cout << "Your discount is: $" << calDiscount(startingPrice) << endl;
    cout << "Your total will be: $" << startingPrice - calDiscount(price) << endl;

    return 0;
}
double calDiscount(double price)
{
    double disc = 0, discountAmount = 0;
    if(price <= 50)
    {
        disc = 10;
        discountAmount = price * disc;
    }
    if(price > 50 && price <= 100)
    {
        disc = .20;
        discountAmount = price / disc;
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
