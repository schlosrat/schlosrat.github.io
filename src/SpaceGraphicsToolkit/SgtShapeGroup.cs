// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShapeGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShapeGroup")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Shape Group")]
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
