// Decompiled with JetBrains decompiler
// Type: KSP.Game.SpatialInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
