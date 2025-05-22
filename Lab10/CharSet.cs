using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перевантаження_операцій
{
    }
public class CharSet
{
    private HashSet<char> elements;

    public CharSet()
    {
        elements = new HashSet<char>();
    }

    public CharSet(IEnumerable<char> items)
    {
        elements = new HashSet<char>(items);
    }

    public static CharSet operator +(char c, CharSet set)
    {
        var newSet = new CharSet(set.elements);
        newSet.elements.Add(c);
        return newSet;
    }

    public static CharSet operator +(CharSet set1, CharSet set2)
    {
        var newSet = new CharSet(set1.elements);
        foreach (var item in set2.elements)
        {
            newSet.elements.Add(item);
        }
        return newSet;
    }

  
    public static bool operator ==(CharSet set1, CharSet set2)
    {
        if (ReferenceEquals(set1, set2))
            return true;
        if (ReferenceEquals(set1, null) || ReferenceEquals(set2, null))
            return false;

        return set1.elements.SetEquals(set2.elements);
    }
   
    public static bool operator !=(CharSet set1, CharSet set2)
    {
        return !(set1 == set2);
    }

    public override bool Equals(object obj)
    {
        return obj is CharSet set && this == set;
    }

    public override int GetHashCode()
    {
        int hash = 19;
        foreach (var c in elements.OrderBy(e => e))
        {
            hash = hash * 31 + c.GetHashCode();
        }
        return hash;
    }

    public override string ToString()
    {
        return "{" + string.Join(", ", elements) + "}";
    }
}
