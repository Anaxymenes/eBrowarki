using Data.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTest
{
    public class AccountMoq
    {
        static public List<Account> AccountList { get {
                var accountList = new List<Account>() {
                    new Account { Username="admin", RoleId = 1,  // Hasło : @dmIn
                                  Email="admin@admin.admin", Active = true, Avatar = "admin.png",
                                  Password = "huJvnFB7W+s+R1VKD5+mVk3Kxl4VLQ9FoKbdwWVj3dM=",
                                  PasswordSalt= "Oa4hhLqKNfKrM5lmBlNp5o2RBMAcb/oZY2JrSliHGPg=" },
                    new Account { Username="moderator", RoleId = 2,  // Hasło : @dmIn
                                  Email="moderator@admin.admin", Active = true, Avatar = "moderator.png",
                                  Password = "huJvnFB7W+s+R1VKD5+mVk3Kxl4VLQ9FoKbdwWVj3dM=",
                                  PasswordSalt= "Oa4hhLqKNfKrM5lmBlNp5o2RBMAcb/oZY2JrSliHGPg=" },
                    new Account { Username="user", RoleId = 3, // Hasło : T3st3r
                                  Email="user@admin.admin", Active = true, Avatar = "user.png",
                                  Password = "T3meNC23KoJwxxJFOsOx2fwj3vnh73dYk9tG9k3UIWg=",
                                  PasswordSalt= "/VAB3o32Ct62xq8cxaLC9gHj+FfvZmGmTlneXAVJOq0=" },
                };
                return accountList;
            } }
    }
}
