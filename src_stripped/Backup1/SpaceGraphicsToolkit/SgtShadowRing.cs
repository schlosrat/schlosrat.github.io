// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadowRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShadowRing")]
  [ExecuteInEditMode]
  [AddComponentMenu("Space Graphics Toolkit/SGT Shadow Ring")]
  public class SgtShadowRing : SgtShadow
  {
    public Texture Texture;
    public float RadiusMin;
    public float RadiusMax;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Texture GetTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CalculateShadow(SgtLight light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShadowRing() => throw null;
  }
}
