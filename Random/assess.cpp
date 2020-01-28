/* 
    Ari Yonaty
    1.21.2020
    ECE2310
    Prof. Klein
    Assessment Test
 */
#include <iostream>

int larger(int num1, int num2)
{
    return (num1 > num2) ? num1 : num2;
}

int main(int argc, char const *argv[])
{
    int lg1 = larger(33, 2);
    int lg2 = larger(0, 16);

    std::cout << larger(lg1, lg2) << std::endl;

    // alternative solution
    std::cout << larger(30, larger(2, larger(0, 16)));

    return 0;
}
