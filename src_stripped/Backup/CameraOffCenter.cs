// Decompiled with JetBrains decompiler
// Type: CameraOffCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class CameraOffCenter : MonoBehaviour
{
  public float x;
  public float y;
  private Camera _camera;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Matrix4x4 PerspectiveOffCenter(
    float x,
    float y,
    float near,
    float far,
    float fov,
    float aspect)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CameraOffCenter() => throw null;
}
