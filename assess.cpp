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
    std::cout << larger(15, 20) << std::endl;

    return 0;
}
