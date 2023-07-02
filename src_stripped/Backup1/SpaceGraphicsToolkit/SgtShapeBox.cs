// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShapeBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shape Box")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShapeBox")]
  public class SgtShapeBox : SgtShape
  {
    public Vector3 Extents;
    public SgtEase.Type Ease;
    public float Sharpness;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float GetDensity(Vector3 worldPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeBox Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtShapeBox Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShapeBox() => throw null;
  }
}
