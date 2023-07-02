// Decompiled with JetBrains decompiler
// Type: CameraOffCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
