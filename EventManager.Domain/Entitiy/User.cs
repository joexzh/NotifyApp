using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    public class User : IAggregateRoot
    {
        public User(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }


        public string Name { get; private set; }



    }
}
