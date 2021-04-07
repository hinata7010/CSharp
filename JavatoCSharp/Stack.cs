using System;
using System.Collections.Generic;
using System.Text;

namespace JavatoCSharp
{
    interface Stack
    {
        bool isEmpty();
        void push(char item);
        char pop();
        void delete();
        char peek();
    }
}
