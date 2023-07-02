// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.MipMapTexture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class MipMapTexture : MonoBehaviour
  {
    private const float MIN_BOKEH = -7f;
    private const float MAX_BOKEH = 2f;
    public Texture2D[] textures;
    public Material bokehMaterial;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBokeh(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D GenerateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MipMapTexture() => throw null;
  }
}
