using MemberData.Interfaces;
using MemberData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberData.Repositories
{
    public class MemberRepository : IMember
    {
        List<Member> memberList = new List<Member>()
        {
            new Member{MemberId=1, FirstName="Kirtesh", LastName="Shah", Address="Vadodara" },
            new Member{MemberId=2, FirstName="Nitya", LastName="Shah", Address="Vadodara" },
            new Member{MemberId=3, FirstName="Dilip", LastName="Shah", Address="Vadodara" },
            new Member{MemberId=4, FirstName="Atul", LastName="Shah", Address="Vadodara" },
            new Member{MemberId=5, FirstName="Swati", LastName="Shah", Address="Vadodara" },
            new Member{MemberId=6, FirstName="Rashmi", LastName="Shah", Address="Vadodara" },       
        };

        public List<Member> GetAllMember()
        {
            return memberList;
        }

        public Member GetMember(int id)
        {
            return memberList.FirstOrDefault(x => x.MemberId == id);

        }
        public Member GetMember1(int id)
        {
            return memberList.FirstOrDefault(x => x.MemberId == id);
        }
    }
}
