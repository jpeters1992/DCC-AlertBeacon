using ALERTBEACON.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALERTBEACON.Startup))]
namespace ALERTBEACON
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        //In this method we will create default User roles and Admin user for login   
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            //In Startup I am creating first Admin Role and creating a default Admin User    
            if (!roleManager.RoleExists("Admin"))
            {

                //First we create Admin role   
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "jpeters";
                user.Email = "jpeters@gmail.com";

                string userPWD = "milwaukee";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            //Creating Observer role    
            if (!roleManager.RoleExists("Observer"))
            {
                var role = new IdentityRole();
                role.Name = "Observer";
                roleManager.Create(role);

            }

            //Creating Car Owner role    
            if (!roleManager.RoleExists("CarOwner"))
            {
                var role = new IdentityRole();
                role.Name = "CarOwner";
                roleManager.Create(role);

            }
        }
    }
}
