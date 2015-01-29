#include <iostream>
#include <stdlib.h>
#include <windows.h>
using namespace std;
void SetColor(int value);
int main()
{
    while(true)
    {
    SetColor(15);
    cout << "\"Quick. Quack. Paddywack." << endl;
    cout << "Squeeze my belly, squeeze my back." << endl;
    cout << "Wacky Wicky Woowee woo," << endl;
    cout << "You love me and I love you.\"" << endl << endl << endl;
    SetColor(7);
    cout << "What would you like to do?" << endl;
    cout << "1. Squeeze my belly" << endl;
    cout << "2. Squeeze my back" << endl;
    cout << "3. Talk to me" << endl;
    cout << "4. Do the Hockey Pockey" << endl;
    int choise = 0;
    cin >> choise;
    if(choise == 1)
    {
        cout << "You compress the patient 99 times, pulling out a sterile mouth funnel you pour down Sodium Chloride into the patients mouth. The patient is 2 feet and 3 inches so you continue to do 33 chest pumps at 3 second intervals until it responds. It doesn't respond. The question is" << endl << "Why did you do it wrong?" << endl;
        string throawaystringnoonewilleverread;
        cin >> throawaystringnoonewilleverread;
        int fourtyfive = 45;
        int zero = 0;
        cout << fourtyfive/zero; //Why does it keep freezing here?
    }
    else if (choise == 2)
    {
        cout << "You spread oil over your hands so they are nice and greasy. The first tip to being a top sioux masseuse is to nead the muscles, dig in and pull the trapezius for renewal, nead your knuckles throughout the maze of muscles and bone until you find the idiots soft spot. Bang the funny bone, feel the vibration and then cover the idiots face in lard to help their complection. You send it on their way, it doesn't respond." << endl;
        return 1337;
    }
    else if (choise ==3)
    {SetColor(15);
        cout << "The time I really felt as if I belonged in this society was when I went to visit a Christmas tree farm back in the 70's. We had these long flimsy saws that bent back and forth whenever we tried to rub them on the tree trunk. After several times of this we needed a break so I stuck down in the snow and held a cappocino. I started admiring the Christmas tree and that's when I realized no matter how deep you looked there were just endless amounts of branches branching off of the other branches. I just kept looking closer and close and saw that the pines needles were nothing more than little tress with smaller trees coming off of those trees and smaller trees coming off of those smaller trees on the smaller trees. I just kept leaning in and looked deeper and deeper until I wasn't sure if I could ever come back out. It was quite an experience." << endl;
        SetColor(7);
        cout << "TYPE YOUR RESPONSE TO SEE ONE OF 450 POSSIBLE ENDINGS." << endl;
        string throawaystringnoonewilleverread;
        cin >> throawaystringnoonewilleverread;
        cout << "THE END." << endl;
        return 50;
    }
    else if (choise == 4)
    {
        cout << "TAKE TURNS WITH HIM" << endl;
        SetColor(15);
        cout << "You put your right hand in." << endl;
        string line1 = "";
        getline(cin, line1);
        cout << "You put your right hand in." << endl;
        string line2 = "";
        getline(cin, line2);
        cout << "You do the hockey pockey" << endl;
        string line3 = "";
        getline(cin, line3);
        cout << "That's what it's all about Judas." << endl;
        string line4 = "";
        getline(cin, line4);
//This part seems buggy? I want to let them customize every other line in the song. :? :? :?
        SetColor(7);
        cout << "REPLAY TIME:" << endl;
        SetColor(15);
        cout << "You put your right hand in." << endl;
        cout << line1;
        cout << "You put your right hand in." << endl;
        cout << line2;
        cout << "You do the hockey pockey" << endl;
        cout << line3;
        cout << "That's what it's all about Judas." << endl;
        cout << line4;
        return 2;

    }
    else
    {
        cout << "invalid"<< endl;
    }

    }

    return 0;
}


void SetColor(int value){
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),  value);
}
