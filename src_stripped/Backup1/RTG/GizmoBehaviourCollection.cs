// Decompiled with JetBrains decompiler
// Type: RTG.GizmoBehaviourCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public class GizmoBehaviourCollection : IEnumerable
  {
    private List<IGizmoBehaviour> _behaviours;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Add(IGizmoBehaviour behaviour) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(IGizmoBehaviour behaviour) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type GetFirstBehaviourOfType<Type>() where Type : class, IGizmoBehaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IGizmoBehaviour GetFirstBehaviourOfType(System.Type behaviourType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Type> GetBehavioursOfType<Type>() where Type : class, IGizmoBehaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<IGizmoBehaviour> GetBehavioursOfType(System.Type behaviourType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(IGizmoBehaviour behaviour) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<IGizmoBehaviour> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoBehaviourCollection() => throw null;
  }
}
