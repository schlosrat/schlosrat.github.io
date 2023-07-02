// Decompiled with JetBrains decompiler
// Type: RTG.RTSceneGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class RTSceneGrid : MonoSingleton<RTSceneGrid>, IXZGrid
  {
    [SerializeField]
    private SceneGridHotkeys _hotkeys;
    [SerializeField]
    private XZGridSettings _settings;
    [SerializeField]
    private XZGridLookAndFeel _lookAndFeel;
    private List<Camera> _renderIgnoreCameras;

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Plane WorldPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Matrix4x4 WorldMatrix
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float YOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SceneGridHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public XZGridSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public XZGridLookAndFeel LookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderIgnoreCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public XZGridCell CellFromWorldPoint(Vector3 worldPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render_SystemCall(Camera renderCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateCellFadeZoom(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SceneRaycastHit GetSceneHitForGridSnap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapToObjectHitPoint(
      GameObjectRayHit objectHit,
      RTSceneGrid.SnapToPointMode snapMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTSceneGrid() => throw null;

    private enum SnapToPointMode
    {
      Exact,
      ClosestExtremity,
    }
  }
}
