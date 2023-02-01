using MemberData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberData.Interfaces
{
     public interface IMember
    {
        public List<Member> GetAllMember();
        public Member GetMember(int id);
    }
}
