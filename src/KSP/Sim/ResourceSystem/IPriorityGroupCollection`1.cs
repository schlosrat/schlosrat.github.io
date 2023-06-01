// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IPriorityGroupCollection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IPriorityGroupCollection<TElement> : 
    IReadOnlyPriorityGroupCollection<TElement>,
    IEnumerable<KeyValuePair<double, TElement>>,
    IEnumerable
  {
    new double this[TElement element] { get; set; }

    bool Remove(TElement element);

    bool RemoveGroupsWithPriority(double priority);

    void RemoveGroupAt(int groupIndex);

    void Add(TElement element, double priority);

    void AddOrUpdate(TElement element, double priority);

    void Clear();
  }
}
