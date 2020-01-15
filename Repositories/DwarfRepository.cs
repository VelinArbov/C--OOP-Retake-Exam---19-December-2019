using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Repositories.Contracts;

namespace SantaWorkshop.Repositories
{
    public class DwarfRepository : IRepository<IDwarf>
    {
        private ICollection<IDwarf> models;

        public DwarfRepository()
        {
            this.models= new List<IDwarf>();
        }


        public IReadOnlyCollection<IDwarf> Models { get; }
        public void Add(IDwarf model)
        {
            string currentName = model.Name;
            var dwarf =models.FirstOrDefault(x => x.Name == currentName);
            if (dwarf == null)
            {
                models.Add(dwarf);
            }

        }

        public bool Remove(IDwarf model)
            => this.models.Remove(model);

        public IDwarf FindByName(string name)
            => models.FirstOrDefault(x => x.Name == name);
    }
}
