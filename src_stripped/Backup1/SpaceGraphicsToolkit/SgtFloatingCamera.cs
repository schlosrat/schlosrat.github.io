// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Camera")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingCamera")]
  [RequireComponent(typeof (Camera))]
  [ExecuteInEditMode]
  public class SgtFloatingCamera : SgtLinkedBehaviour<SgtFloatingCamera>
  {
    public long Scale;
    public float SnapDistance;
    public static Action<SgtFloatingCamera, Vector3> OnSnap;
    public bool UseOrigin;
    public SgtPosition SnappedPoint;
    public bool SnappedPointSet;
    [NonSerialized]
    private Camera cachedCamera;
    [NonSerialized]
    private bool cachedCameraSet;
    [SerializeField]
    private Vector3 expectedPosition;
    [SerializeField]
    private bool expectedPositionSet;

    public Camera CachedCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetCamera(int layer, ref SgtFloatingCamera matchingCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRendering(int targetLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtPosition GetPosition(Vector3 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 CalculatePosition(ref SgtPosition input) => throw null;

    [ContextMenu("Snap")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Snap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreCull(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrySnap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TrySnapAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CheckForPositionChangesAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForPositionChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePositionNow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtFloatingCamera() => throw null;
  }
}
