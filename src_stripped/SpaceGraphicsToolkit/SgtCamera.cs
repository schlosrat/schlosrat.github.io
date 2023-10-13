// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Camera")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtCamera")]
  [RequireComponent(typeof (Camera))]
  [DisallowMultipleComponent]
  [ExecuteInEditMode]
  public class SgtCamera : SgtLinkedBehaviour<SgtCamera>
  {
    public bool UseOrigin;
    public float RollAngle;
    public Quaternion RollQuaternion;
    public Matrix4x4 RollMatrix;
    [NonSerialized]
    public Vector3 DeltaPosition;
    [NonSerialized]
    public Vector3 Velocity;
    [NonSerialized]
    public Quaternion OldRotation;
    [NonSerialized]
    public Vector3 OldPosition;
    [NonSerialized]
    public Camera cachedCamera;
    [NonSerialized]
    public bool cachedCameraSet;
    [NonSerialized]
    private SgtPosition expectedPosition;
    [NonSerialized]
    private bool expectedPositionSet;

    public static event Action<Camera> OnCameraPreCull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static event Action<Camera> OnCameraPreRender
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static event Action<Camera> OnCameraPostRender
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static event Action<SgtCamera> OnSgtCameraPreCull
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static event Action<SgtCamera> OnSgtCameraPreRender
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static event Action<SgtCamera> OnSgtCameraPostRender
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Camera CachedCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryFind(Camera unityCamera, ref SgtCamera foundCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPreCull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnPostRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FloatingCameraSnap(SgtFloatingCamera floatingCamera, Vector3 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtCamera() => throw null;
  }
}
