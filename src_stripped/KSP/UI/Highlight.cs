// Decompiled with JetBrains decompiler
// Type: KSP.UI.Highlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Highlight : KerbalMonoBehaviour
  {
    [SerializeField]
    protected Highlight_Data highlight_Data;
    [SerializeField]
    protected GameObject viewHighlight;
    protected SimulationObjectView viewObject;
    protected PartBehavior partViewComponent;
    protected SubscriptionHandle _handlePartDestroyed;
    protected VesselComponent activeVessel;

    protected bool InOAB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Show(Highlight_Data data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPartDestroyed(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void ParentHighlightToPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateNavBallPosition(Position newPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HighlightOrbitNodeMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Highlight() => throw null;
  }
}
