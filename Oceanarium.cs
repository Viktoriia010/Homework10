using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10;

internal class Oceanarium: IEnumerable<Inhabitant>
{
    public string? Name { get; set; }
    public string? Adress { get; set; }

    private List<Inhabitant> inhabitants = new List<Inhabitant>();

    public void AddInhabitant(Inhabitant inhabitant)
    {
        inhabitants.Add(inhabitant);
    }

    public IEnumerator<Inhabitant> GetEnumerator()
    {
        return inhabitants.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Oceanarium(string? name, string? adress)
    {
        Name = name;
        Adress = adress;
    }
}
