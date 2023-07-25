// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SuspensionLoadBalancer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class SuspensionLoadBalancer : KerbalMonoBehaviour
  {
    private List<Module_WheelSuspension> suspensionModules;
    public const float MAX_MASS_CHANGE = 1f;
    public bool IsReady;
    public VesselBehavior Vessel;
    public float multiplier;
    public float minMass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSuspensionModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SuspensionLoadBalancer() => throw null;
  }
}
