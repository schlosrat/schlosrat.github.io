// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IReadOnlyPriorityGroupCollection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IReadOnlyPriorityGroupCollection<TElement> : 
    IEnumerable<KeyValuePair<double, TElement>>,
    IEnumerable
  {
    double FirstPriority { get; }

    double LastPriority { get; }

    int GroupCount { get; }

    IList<IReadOnlyCollection<TElement>> GroupElements { get; }

    IList<double> GroupPriorities { get; }

    IReadOnlyDictionary<double, IReadOnlyCollection<TElement>> PriorityElementGroups { get; }

    int ElementCount { get; }

    IReadOnlyDictionary<TElement, double> ElementPriorities { get; }

    double this[TElement element] { get; }

    int IndexOfPriority(double priority);

    int IndexOfElement(TElement element);

    IComparer<double> PrioritySorter { get; }

    IEqualityComparer<TElement> ElementComparer { get; }

    IEnumerable<KeyValuePair<double, TElement>> GetFirstToLast();

    IEnumerable<KeyValuePair<double, TElement>> GetLastToFirst();
  }
}
