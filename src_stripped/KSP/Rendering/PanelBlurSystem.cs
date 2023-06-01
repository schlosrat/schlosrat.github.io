// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PanelBlurSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class PanelBlurSystem : MonoBehaviour
  {
    [SerializeField]
    private GraphicsManager GraphicsManager;
    [Range(0.0f, 10f)]
    public float blurOffset;
    [Range(0.0f, 5f)]
    public int blurRepeat;
    public Shader blurShader;
    private CommandBuffer blurCommandBuffer;
    private Camera currentLinkedCamera;
    private float lastBlurOffset;
    private int lastBlurRepeat;
    private Shader lastBlurShader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LinkCommandBufferToActiveCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CommandBuffer CreateCommandBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PanelBlurSystem() => throw null;
  }
}
