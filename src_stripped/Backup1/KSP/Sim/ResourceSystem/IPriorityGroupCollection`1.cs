// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IPriorityGroupCollection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
