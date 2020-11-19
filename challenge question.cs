using System;

using namespace ; funnyString


int main()
{
 
    int q;
    cin >> q;
    

    for (
        int q_itr = 0; 
        q_itr < q; 
        q_itr++)
    {
        string s;
        
        getline(cin, s);

        string result = funnyString(s);

        fout << result <<
    }

    return 0;
}