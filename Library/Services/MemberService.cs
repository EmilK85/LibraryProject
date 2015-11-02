//Emil Kronström & Love Hermansson
//OOP2
//02/11 -15
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class MemberService: IService
    {
        public event EventHandler Updated;

        MemberRepository _memberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _memberRepository = repoFactory.GetMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }

        public void Add(Member item)
        {
            _memberRepository.Add(item);
            OnUpdated(this, new EventArgs());
        }

        public Member Find(int id)
        {
            return _memberRepository.Find(id);
        }

        public void RemoveLoan(Loan item, string name)
        {
            _memberRepository.RemoveLoan(item, name);
        }

        public void OnUpdated(object sender, EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }
    }
}
