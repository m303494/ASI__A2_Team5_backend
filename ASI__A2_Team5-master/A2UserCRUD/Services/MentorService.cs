using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class MentorService : IMentorService
    {
        private List<Mentor> _mentors;

        public MentorService()
        {
            _mentors = new List<Mentor>();
        }
        public Mentor AddMentor(Mentor mentor)
        {
            _mentors.Add(mentor);
            return mentor;
            throw new NotImplementedException();
        }

        public string DeleteMentor(string id)
        {
            for (var index = _mentors.Count - 1; index >= 0; index--)
            {
                if (_mentors[index].Mentor_id == id)
                {
                    _mentors.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<Mentor> GetMentors()
        {
            return _mentors;
            throw new NotImplementedException();
        }

        public Mentor UpdateMentor(string id, Mentor mentor)
        {
            for (var index = _mentors.Count - 1; index >= 0; index--)
            {
                if (_mentors[index].Mentor_id == id)
                {
                    _mentors[index] = mentor;
                }
            }
            return mentor;
            throw new NotImplementedException();
        }


    }
}
