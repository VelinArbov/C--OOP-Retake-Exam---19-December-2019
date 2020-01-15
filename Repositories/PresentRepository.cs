using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Repositories.Contracts;

namespace SantaWorkshop.Repositories
{
    public class PresentRepository : IRepository<IPresent>
    {
        private readonly ICollection<IPresent> models;

        public PresentRepository()
        {
            this.models= new List<IPresent>();
        }

        public IReadOnlyCollection<IPresent> Models { get; }
        public void Add(IPresent model)
        {
            string currentName = model.Name;
            var dwarf = models.FirstOrDefault(x => x.Name == currentName);
            if (dwarf == null)
            {
                models.Add(dwarf);
            }
        }

        public bool Remove(IPresent model)
            => this.models.Remove(model);

        public IPresent FindByName(string name)
            => models.FirstOrDefault(x => x.Name == name);
    }
}
