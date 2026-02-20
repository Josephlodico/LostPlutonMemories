using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostPlutonMemories.TLPClasses
{
    public class Memory
    {
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }

        public Memory(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
