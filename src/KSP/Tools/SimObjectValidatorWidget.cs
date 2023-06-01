// Decompiled with JetBrains decompiler
// Type: KSP.Tools.SimObjectValidatorWidget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  public abstract class SimObjectValidatorWidget : MonoBehaviour
  {
    [SerializeField]
    private Renderer physicsSpaceIndicator;
    [SerializeField]
    private Renderer scaledSpaceIndicator;
    public Color physicsSpaceColor;
    public Color scaledSpaceColor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateIndicators<TComponent>(
      TComponent component,
      IScaledSpaceProvider scaledSpace,
      IPhysicsSpaceProvider physicsSpace)
      where TComponent : ObjectComponent
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SimObjectValidatorWidget() => throw null;
  }
}
