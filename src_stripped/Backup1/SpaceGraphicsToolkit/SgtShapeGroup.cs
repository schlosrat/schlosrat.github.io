// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShapeGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shape Group")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShapeGroup")]
  public class SgtShapeGroup : MonoBehaviour
  {
    public List<SgtShape> Shapes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeGroup Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeGroup Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetDensity(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShapeGroup() => throw null;
  }
}
