using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class SchoolService : ISchoolService
    {
        private List<School> _schools;

        public SchoolService()
        {
            _schools = new List<School>();
        }

        public School AddSchool(School school)
        {
            _schools.Add(school);
            return school;
            throw new NotImplementedException();
        }

        public string DeleteSchool(string id)
        {
            for (var index = _schools.Count - 1; index >= 0; index--)
            {
                if (_schools[index].School_id == id)
                {
                    _schools.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<School> GetSchools()
        {
            return _schools;
            throw new NotImplementedException();
        }

        public School UpdateSchool(string id, School school)
        {
            for (var index = _schools.Count - 1; index >= 0; index--)
            {
                if (_schools[index].School_id == id)
                {
                    _schools[index] = school;
                }
            }
            return school;
            throw new NotImplementedException();
        }
    }
}
