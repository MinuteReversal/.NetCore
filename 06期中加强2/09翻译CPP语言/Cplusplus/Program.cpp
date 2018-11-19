#include <iostream>
using namespace std;

void odd(int a, int MC[][100], int begin, int end)
{
    int row, line;
    row = begin;
    line = (begin + end) / 2;
    MC[row][line] = 1;
    for (int i = 2; i <= a * a; i++)
    {
        if ((i - 1) % a == 0)
        {
            if (row == a)
                row = 1;
            else
                row++;
            MC[row][line] = i;
            continue;
        }

        if (row == 1)
            row = a;
        else
            row--;

        if (line == a)
            line = 1;
        else
            line++;
        MC[row][line] = i;
    }
}

void spouse(int a, int MC[100][100])
{
    int N = a * a;
    int fill[100];
    int row, line, temp, k = 1;
    for (row = 1; row <= a; row++)
        for (line = 1; line <= a; line++)
        {
            MC[row][line] = k;
            k++;
        }
    for (row = 1; row <= a / 2; row++)
        for (line = a / 4 + 1; line <= a / 4 * 3; line++)
        {

            temp = MC[row][line];
            MC[row][line] = MC[a - row + 1][line];
            MC[a - row + 1][line] = temp;
        }
    for (line = 1; line <= a / 2; line++)
        for (row = a / 4 + 1; row <= a / 4 * 3; row++)
        {
            temp = MC[row][line];
            MC[row][line] = MC[row][a - line + 1];
            MC[row][a - line + 1] = temp;
        }
}

void SingleSpouse(int a, int MC[100][100])
{
    int k = a / 2;
    int row, line, temp;
    //将魔方阵分为A、B、C、D，四个奇魔方阵
    odd(k, MC, 1, k);
    for (row = 1; row <= k; row++)
        for (line = 1; line <= k; line++)
        {
            MC[row + k][line + k] = MC[row][line] + k * k;
            MC[row][line + k] = MC[row][line] + 2 * k * k;
            MC[row + k][line] = MC[row][line] + 3 * k * k;
        }
    //Swap A and C
    for (row = 1; row <= k; row++)
    {
        if (row == k / 2 + 1) //中间行，交换从中间向右的m列
        {
            for (line = k / 2 + 1; line <= k - 1; line++)
            {
                temp = MC[row][line];
                MC[row][line] = MC[row + k][line];
                MC[row + k][line] = temp;
            }
        }
        else //其他行，交换从左向右的m列
        {
            for (line = 1; line <= k / 2; line++)
            {
                temp = MC[row][line];
                MC[row][line] = MC[row + k][line];
                MC[row + k][line] = temp;
            }
        }
    }

    // Swap B and D
    for (row = 1; row <= k; row++) //交换中间列向左m-1列
        for (int i = 1; i <= k / 2 - 1; i++)
        {
            temp = MC[row][k + k / 2 - i];
            MC[row][k + k / 2 - i] = MC[row + k][k + k / 2 - i];
            MC[row + k][k + k / 2 - i] = temp;
        }
}

int main()
{
    int MC[100][100];
    int a;
    while (true)
    {
        char b;
        cout << "input a number: " << endl;
        cin.sync();
        cin >> a;
        if (a % 2 == 1)
        {
            cout << "该魔方为一奇魔方" << endl;
            odd(a, MC, 1, a);
        }
        else if (a % 4 == 0)
        {
            cout << "该魔方为一偶魔方" << endl;
            spouse(a, MC);
        }
        else
        {
            cout << "该魔方为一奇偶魔方" << endl;
            SingleSpouse(a, MC);
        }

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= a; j++)
                cout << MC[i][j] << "\t";
            cout << endl;
        }

        cout << "continue to test?input 'y' or ''n' " << endl;
        cin.sync();
        cin >> b;
        while (b != 'y' && b != 'Y' && b != 'n' && b != 'N')
        {
            cout << "input illegal character, please re-enter, 'y' or 'n':" << endl;
            cin.sync();
            cin >> b;
        }

        if (b == 'y' || b == 'Y')
            continue;
        else if (b == 'n' || b == 'N')
            break;
    }

    return 0;
}