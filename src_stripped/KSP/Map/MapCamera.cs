// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Map
{
  [RequireComponent(typeof (Camera))]
  public class MapCamera : KerbalCameraBehaviour, ICameraGimbalStateProvider
  {
    [SerializeField]
    [Header("Links")]
    private GameObject pivotVisual;
    public bool ConsiderMapScale;
    public bool InvertConsideration;
    [Space]
    public MapCameraTweakables CameraTweakables;
    private MapCameraTweakables _tweakablesObj;
    private GameObject _mapCameraPivot;
    private float _pivotAlpha;
    private MapCameraInputHandler _mapCameraInputHandler;
    private PostProcessLayer _mapCameraPostLayer;
    private SubscriptionHandle _handleMapShutdown;
    private MapCore _mapCore;
    private bool _cacheObserverKeyword;
    private bool _cacheGalaxyKeyword;
    private bool _initialized;

    public MapCameraTweakables CurrentCameraTweakables
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera UnityCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Map3DSpaceProvider SpaceProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool Initialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignSpaceProvider(Map3DSpaceProvider spaceProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPivotDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPivotVisualFade() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShutdown(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPhysicsSpaceProviderReferenceChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPivotCameraTransform(out Transform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transform GetPivotCameraTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetGimbalState(out GimbalState cameraGimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessLayer GetPostProcessLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCamera() => throw null;
  }
}
