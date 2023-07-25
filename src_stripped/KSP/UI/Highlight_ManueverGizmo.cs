// Decompiled with JetBrains decompiler
// Type: KSP.UI.Highlight_ManueverGizmo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Map;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Highlight_ManueverGizmo : Highlight
  {
    protected MapManeuverGizmo _currentMapManueverGizmo;
    protected SubscriptionHandle _handleMeneuverGizmoInitialized;
    [Header("Particles to play")]
    [SerializeField]
    [Tooltip("Plays the particle system and it's children")]
    protected ParticleSystem _gizmoExpandedParticle;
    [SerializeField]
    protected ParticleSystem _gizmoCollapsedParticle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(Highlight_Data data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ListenToMapManeuverActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveMapManueverActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryParentToGizmo(MapManeuverGizmo mapManeuverGizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManeuverGizmoInitialized(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleParticles(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Highlight_ManueverGizmo() => throw null;
  }
}
