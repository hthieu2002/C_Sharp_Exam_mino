using Console_Application_Account_4;
using System;
using System.Collections;

namespace Console_Application_Account_4
{
    public class AccountComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Account acc1 = x as Account;
            Account acc2 = y as Account;

            return acc1.AccountID.CompareTo(acc2.AccountID);
        }
    }
}
