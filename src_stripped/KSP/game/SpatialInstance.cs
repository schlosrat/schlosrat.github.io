﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.SpatialInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
