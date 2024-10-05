using Code_First_Relation.Context;
using Code_First_Relation.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Code_First_Relation.Controllers
{
    public class UserController : Controller
    {

        private readonly CodeFirstRelationDbContext _context;

        public UserController(CodeFirstRelationDbContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {

            var newuser = new UserEntity()
            {
                Email="kullanıcı@gamil.com",
                UserName="Kullanıcı"

            };

            _context.Users.Add(newuser);

            return Ok();
        }
    }
}
