using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberData.Interfaces;
using MemberData.Models;
using MemberData.Repositories;


namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
         private IMember members = new  MemberRepository();


        [HttpGet]
        [Route("GetAllMember")]
        public ActionResult<IEnumerable<Member>> GetAllMembers()
        {
            return members.GetAllMember();
        }


        [HttpGet]
        [Route("GetMemberById")]
        public ActionResult<Member> GetMemberById(int id)
        {
            return members.GetMember(id);
        }
    }
}
