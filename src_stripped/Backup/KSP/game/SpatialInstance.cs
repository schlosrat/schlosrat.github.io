// Decompiled with JetBrains decompiler
// Type: KSP.Game.SpatialInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public abstract class SpatialInstance
  {
    public Collider TriggerCollider;
    [HideInInspector]
    public SpatialBehavior SpatialBehavior;
    private List<int> _disableContexts;

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDisabled(int contextHash, bool disabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SpatialInstance() => throw null;
  }
}
