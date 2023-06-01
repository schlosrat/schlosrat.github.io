// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.CameraShift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [ExecuteInEditMode]
  [RequireComponent(typeof (Camera))]
  public class CameraShift : MonoBehaviour
  {
    public Vector2 offset;
    private Camera m_camera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetPerspectiveOffset(Camera cam, Vector2 perspectiveOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Matrix4x4 PerspectiveOffCenter(
      float left,
      float right,
      float bottom,
      float top,
      float near,
      float far)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraShift() => throw null;
  }
}
