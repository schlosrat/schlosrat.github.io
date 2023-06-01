// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PrefabLensFlare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  public class PrefabLensFlare : KerbalMonoBehaviour
  {
    [SerializeField]
    private ProFlare _flare;
    [Header("Intensity")]
    [Range(0.0f, 2000f)]
    [SerializeField]
    private float _flareMaxIntensity;
    [Header("Range")]
    [Tooltip("Max range is the furthest the camera can get before the flare is no longer visible")]
    [SerializeField]
    private float _flareMaxRange;
    [Tooltip("Curve in control of the distance scalar")]
    [SerializeField]
    private AnimationCurve _lensFlareRangeCurve;
    private bool renderFlare;
    private SubscriptionHandle _handleCameraChanged;

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateDistanceToCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculatePrefabFlareIntensity(double dist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrefabLensFlare() => throw null;
  }
}
