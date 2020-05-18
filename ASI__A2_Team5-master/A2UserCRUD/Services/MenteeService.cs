using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class MenteeService : IMenteeService
    {
        private List<Mentee> _mentees;

        public MenteeService()
        {
            _mentees = new List<Mentee>();
        }
        public Mentee AddMentee(Mentee mentee)
        {
            _mentees.Add(mentee);
            return mentee;
            throw new NotImplementedException();
        }
        public string DeleteMentee(string id)
        {
            for (var index = _mentees.Count - 1; index >= 0; index--)
            {
                if (_mentees[index].Mentee_id == id)
                {
                    _mentees.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<Mentee> GetMentees()
        {
            return _mentees;
            throw new NotImplementedException();
        }

        public Mentee UpdateMentee(string id, Mentee mentee)
        {
            for (var index = _mentees.Count - 1; index >= 0; index--)
            {
                if (_mentees[index].Mentee_id == id)
                {
                    _mentees[index] = mentee;
                }
            }
            return mentee;
            throw new NotImplementedException();
        }
    }
}
