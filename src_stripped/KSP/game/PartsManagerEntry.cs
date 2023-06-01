// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class PartsManagerEntry : KerbalMonoBehaviour
  {
    [SerializeField]
    protected ContextBindRoot _contextBindRoot;
    internal int ModuleSortIndex;
    internal int ModuleDataSortIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(IDataContextReadonly contextOfPropertyOrAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReturnToPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int GetSortIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerEntry() => throw null;
  }
}
