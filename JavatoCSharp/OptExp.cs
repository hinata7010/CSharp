using System;
using System.Collections.Generic;
using System.Text;

namespace JavatoCSharp
{
    class OptExp
    {
		private String exp;
		private int expSize;
		private char testCh, openPair;

		public bool testPair(String exp)
		{
			this.exp = exp;
			LinkedStack S = new LinkedStack();
			expSize = this.exp.Length;
			for (int i = 0; i < expSize; i++)
			{
				testCh = this.exp[i];
				switch (testCh)
				{
					case '(':
					case '{':
					case '[':
						S.push(testCh);
						break;
					case ')':
					case '}':
					case ']':
						if (S.isEmpty())
							return false;
						else
						{
							openPair = S.pop();
							if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
									|| (openPair == '[' && testCh != ']'))
								return false;
							else
								break;
						}
				}
			}
			if (S.isEmpty())
				return true;
			else
				return false;
		}
	}
}
