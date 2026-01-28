using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewDB
{
    public class UserDB : BaseDB
    {
        protected override Base NewEntity()
        {
            return new User();
        }
        public Base NewFullEntity()
        {
            return new FullUserInfo();
        }
        protected override void CreateModel(Base entity)
        {
            base.CreateModel(entity);
            if(entity != null)
            {
                try
                {
                    User user = (User)entity;
                    user.Username = reader["Username"].ToString();
                    user.Password = reader["Password"].ToString();
                }
                catch
                {
                    Console.WriteLine("No id in db");
                }               
            }
        }
        protected void CreateFullModel(Base entity)
        {
            base.CreateModel (entity);
            if(entity != null)
            {
                try
                {
                    FullUserInfo fullUser = (FullUserInfo)entity;
                    fullUser.Username = reader["Username"].ToString();
                    fullUser.Password = reader["Password"].ToString();
                    fullUser.Email = reader["Email"].ToString();
                    fullUser.Address = reader["Address"].ToString();
                    fullUser.CityId = int.Parse(reader["CityId"].ToString());
                    fullUser.Gender = reader["Gender"].ToString();
                    fullUser.PhoneNumber = reader["PhoneNumber"].ToString();
                    fullUser.BirthDate = reader["BirthDate"].ToString();
                    
                }
                catch
                {
                    Console.WriteLine("Something is missing in DB");
                }
            }
        }

    }
}
