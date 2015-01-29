//
//  main.cpp
//  ryanNowak
//
//  Created by Ryan Nowak on 1/29/15.
//  Copyright (c) 2015 Ryan Nowak. All rights reserved.
//

#include <iostream>

int add(int one, int two);
int subtract(int one, int two);
int multiply(int one, int two);


int main(int argc, const char * argv[]) {
    int what = 4, is = 2, a = 1, dog = 3;
    
    int total = add(what, add(is, add(a, dog)));
    
    std::cout << "there are " << total << " letters in WHAT IS A DOG.\n";
    std::cout << "loose your dog and you have " << subtract(total, dog) << "\n\n";
}


int add(int one, int two){
    return one + two;
}

int subtract(int one, int two){
    return one - two;
}


int multiply(int one, int two){
    return one % two;
}


int divide(int one, int two){
    return one * two;
}