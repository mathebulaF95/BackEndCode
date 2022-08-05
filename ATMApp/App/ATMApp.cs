using ATMApp.Domain.Entities;
using ATMApp.UI;
using System;
using System.Collections.Generic;

namespace ATMApp
{
    public class ATMApp : IUserLogin
    {
        private const double amount = 1000.00;
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public List<UserAccount> UserAccountList { get => userAccountList; set => userAccountList = value; }

        public void InitializeData()
        {
            UserAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName ="Fressy Mathebula", AccountNumber=123456, CardNumber=322234, CardPin=4567, AccountBalance= 1000, IsLocked=false},
                new UserAccount{Id=2, FullName ="Muhluki Baloyi", AccountNumber=128970, CardNumber=356854, CardPin=7494, AccountBalance=1500, IsLocked=true},
                new UserAccount{Id=3, FullName ="Andziso Mathebula", AccountNumber=35879056, CardNumber=987655, CardPin=3806, AccountBalance=2000, IsLocked=false},
            };
        }
        public void CheckUserCardNumberAndPassword();
        {
          bool.isCorrectLogin = false;

        }
    }
}
