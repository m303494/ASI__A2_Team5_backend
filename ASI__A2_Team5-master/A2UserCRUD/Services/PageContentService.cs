using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public class PageContentService : IPageContentService
    {

        private List<PageContent> _PC;

        public PageContentService()
        {
            _PC = new List<PageContent>();
        }

        public PageContent AddPage(PageContent PC)
        {
            _PC.Add(PC);
            return PC;
            throw new NotImplementedException();
        }

        public string DeletePage(string id)
        {
            for (var index = _PC.Count - 1; index >= 0; index--)
            {
                if (_PC[index].Page_id == id)
                {
                    _PC.RemoveAt(index);
                }
            }

            return id;
            throw new NotImplementedException();
        }

        public List<PageContent> GetPages()
        {
            return _PC;
            throw new NotImplementedException();
        }

        public PageContent UpdatePage(string id, PageContent PC)
        {
            for (var index = _PC.Count - 1; index >= 0; index--)
            {
                if (_PC[index].Page_id == id)
                {
                    _PC[index] = PC;
                }
            }
            return PC;
            throw new NotImplementedException();
        }
    }
}
