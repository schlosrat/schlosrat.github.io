// Decompiled with JetBrains decompiler
// Type: Assets._UI5.Rendering.Scripts.ImgFX_ColorMultiply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
