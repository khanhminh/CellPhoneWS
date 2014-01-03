using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CellPhoneShop
{
    public class TokenBLL
    {
        private CellPhoneShopDbEntities db = new CellPhoneShopDbEntities();

        public string GetToken()
        {
            return db.Tokens.Find("TK").access_token;
        }

        public void SaveToken(string access_token)
        {
            Token tk = db.Tokens.Find("TK");
            if (tk != null)
            {
                tk.access_token = access_token;
                db.Entry(tk).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}