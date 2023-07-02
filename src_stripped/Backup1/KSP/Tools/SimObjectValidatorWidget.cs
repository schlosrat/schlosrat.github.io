// Decompiled with JetBrains decompiler
// Type: KSP.Tools.SimObjectValidatorWidget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
