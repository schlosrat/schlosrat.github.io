// Decompiled with JetBrains decompiler
// Type: Assets._UI5.Rendering.Scripts.ImgFX_ColorMultiply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets._UI5.Rendering.Scripts
{
  public class ImgFX_ColorMultiply : MonoBehaviour
  {
    public Color imgColor;
    private Material mat;
    private int dstTexID;
    [SerializeField]
    private Shader shader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImgFX_ColorMultiply() => throw null;
  }
}
