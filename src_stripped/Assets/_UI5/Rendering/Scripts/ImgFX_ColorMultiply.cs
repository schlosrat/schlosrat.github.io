// Decompiled with JetBrains decompiler
// Type: Assets._UI5.Rendering.Scripts.ImgFX_ColorMultiply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
