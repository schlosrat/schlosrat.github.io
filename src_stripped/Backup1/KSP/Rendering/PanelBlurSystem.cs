// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PanelBlurSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    private CommandBuffer _blurCommandBuffer;
    private Camera _currentLinkedCamera;
    private float _lastBlurOffset;
    private int _lastBlurRepeat;
    private Shader _lastBlurShader;
    private Material _verticalBlurMat;
    private Material _horizontalBlurMat;
    private static readonly int SCREEN_COPY_ID;
    private static readonly int BLURRED_1_ID;
    private static readonly int BLURRED_2_ID;
    private static readonly int OFFSET_ID;
    private static readonly int BLUR_TEX_ID;

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
    private void RemoveCommandBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PanelBlurSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PanelBlurSystem() => throw null;
  }
}
