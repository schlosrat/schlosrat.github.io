// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DrawMeshRendererToRawImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace KSP.Rendering
{
  public class DrawMeshRendererToRawImage : MonoBehaviour
  {
    [Header("Resulting UI Image")]
    [Tooltip("Property to link the canvas's raw image representation of the rendered prefab group")]
    [SerializeField]
    private RawImage _rawImage;
    [SerializeField]
    [Space(5f)]
    private MeshRenderer[] _meshRenderers;
    [SerializeField]
    [Header("Texture")]
    private string _textureName;
    [SerializeField]
    private int _maxTextureSize;
    [SerializeField]
    private int _minTextureSize;
    [Tooltip("If true, only the current active referenced GameObjects will be rendered. Disable if the referenced Renderers should always be rendered.")]
    [SerializeField]
    private bool _onlyRenderActiveGameObjects;
    [SerializeField]
    private float _resolutionMultiplier;
    private bool _snapToPow2;
    private RenderTexture _renderTexture;
    private CommandBuffer _commandBuffer;
    private Vector3[] _corners;
    private static Vector3[] s_newCornersTemp;
    private Matrix4x4 _orthoMatrix;
    private Matrix4x4 _viewMatrix;
    private int _currentPixelWidth;
    private int _currentPixelHeight;
    private bool[] _renderersRenderedLastFrame;
    [Header("Outline")]
    [SerializeField]
    private bool _applyOutline;
    [SerializeField]
    private int _outlinePixelWidth;
    [SerializeField]
    private Color _outlineColor;
    private Material _outlineMaterial;
    private const string OUTLINE_SHADER_NAME = "KSP2/UI/JumpFloodOutline";
    private const float ANTI_ALIAS_BUFFER = 0.5f;
    private const int MIN_WIDTH = 0;
    private static readonly int SILHOUETTE_BUFFER_ID;
    private static readonly int NEAREST_POINT_1_ID;
    private static readonly int NEAREST_POINT_2_ID;
    private static readonly int OUTLINE_COLOR_ID;
    private static readonly int AXIS_WIDTH_ID;
    private static readonly int SOURCE_OUTLINE_TEX_ID;
    private static readonly string DRAW_RENDERERS_SAMPLER;
    private static readonly string INTERIOR_STENCIL_SAMPLER;
    private static readonly string SILHOUETTE_BUFFER_SAMPLER;
    private static readonly string AXIS_SAMPLE_SAMPLER;
    private static readonly string DRAW_OUTLINE_SAMPLER;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DoCommandBufferRebuild() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ResizeRenderTextureIfNecessary() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPow2PixelSize(
      int pixelWidth,
      int pixelHeight,
      out int pow2Width,
      out int pow2Height)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetDesiredExactPixelSize(out int width, out int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasRendererListChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetNearestPowerOfTwo(int input) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupNewRenderTexture(int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DoMatricesNeedToUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildCommandBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddDrawRenderCommand(MeshRenderer[] renderers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddDrawOutlineCommand(MeshRenderer[] renderers, Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupTempRenderTextures(RenderTexture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawInnerStencilPass(MeshRenderer[] renderers, Material mat, RenderTexture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSilhouetteBufferPass(
      MeshRenderer[] renderers,
      Material mat,
      int width,
      Color color)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawJumpFloodInitPass(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawJumpFloodAxisPass(Material mat, int width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawFinalOutline(Material mat, RenderTexture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanupTempRenderTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsMeshRendererReadyToRender(MeshRenderer r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateViewProjMatrix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrawMeshRendererToRawImage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DrawMeshRendererToRawImage() => throw null;

    private enum OutlinePass
    {
      InteriorStencil,
      SilhouetteBuffer,
      JumpFloodInit,
      JumpFloodAxisSample,
      JumpFloodOutline,
    }
  }
}
