// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PrefabLensFlare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [SerializeField]
    [Range(0.0f, 2000f)]
    private float _flareMaxIntensity;
    [SerializeField]
    [Tooltip("Max range is the furthest the camera can get before the flare is no longer visible")]
    [Header("Range")]
    private float _flareMaxRange;
    [SerializeField]
    [Tooltip("Curve in control of the distance scalar")]
    private AnimationCurve _lensFlareRangeCurve;
    private bool renderFlare;
    private IPhysicsSpaceProvider PhysicsSpace;
    private SubscriptionHandle _handleCameraChanged;

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
