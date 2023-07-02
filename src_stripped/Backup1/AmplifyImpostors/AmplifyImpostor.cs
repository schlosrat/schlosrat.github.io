// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.AmplifyImpostor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyImpostors
{
  public class AmplifyImpostor : MonoBehaviour
  {
    private const string ShaderGUID = "e82933f4c0eb9ba42aab0739f48efe21";
    private const string DilateGUID = "57c23892d43bc9f458360024c5985405";
    private const string PackerGUID = "31bd3cd74692f384a916d9d7ea87710d";
    private const string ShaderOctaGUID = "572f9be5706148142b8da6e9de53acdb";
    private const string StandardPreset = "e4786beb7716da54dbb02a632681cc37";
    private const string LWPreset = "089f3a2f6b5f48348a48c755f8d9a7a2";
    private const string LWShaderOctaGUID = "94e2ddcdfb3257a43872042f97e2fb01";
    private const string LWShaderGUID = "990451a2073f6994ebf9fd6f90a842b3";
    private const string HDPreset = "47b6b3dcefe0eaf4997acf89caf8c75e";
    private const string HDShaderOctaGUID = "56236dc63ad9b7949b63a27f0ad180b3";
    private const string HDShaderGUID = "175c951fec709c44fa2f26b8ab78b8dd";
    [SerializeField]
    private AmplifyImpostorAsset m_data;
    [SerializeField]
    private Transform m_rootTransform;
    [SerializeField]
    private LODGroup m_lodGroup;
    [SerializeField]
    private Renderer[] m_renderers;
    public LODReplacement m_lodReplacement;
    [SerializeField]
    public RenderPipelineInUse m_renderPipelineInUse;
    public int m_insertIndex;
    [SerializeField]
    public GameObject m_lastImpostor;
    [SerializeField]
    public string m_folderPath;
    [NonSerialized]
    public string m_impostorName;
    [SerializeField]
    public CutMode m_cutMode;
    [NonSerialized]
    private const float StartXRotation = -90f;
    [NonSerialized]
    private const float StartYRotation = 90f;
    [NonSerialized]
    private const int MinAlphaResolution = 256;
    [NonSerialized]
    private RenderTexture[] m_rtGBuffers;
    [NonSerialized]
    private RenderTexture[] m_alphaGBuffers;
    [NonSerialized]
    private RenderTexture m_trueDepth;
    [NonSerialized]
    public Texture2D m_alphaTex;
    [NonSerialized]
    private float m_trueFitsize;
    [NonSerialized]
    private float m_depthFitsize;
    [NonSerialized]
    private Bounds m_originalBound;
    [NonSerialized]
    private const int BlockSize = 65536;

    public AmplifyImpostorAsset Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform RootTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public LODGroup LodGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Renderer[] Renderers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateTextures(List<TextureOutput> outputList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateAlphaTextures(List<TextureOutput> outputList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAlphaBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenderImpostor(
      ImpostorType impostorType,
      int targetAmount,
      bool impostorMaps = true,
      bool combinedAlphas = false,
      bool useMinResolution = false,
      Shader customShader = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 OctahedronToVector(Vector2 oct) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 OctahedronToVector(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 HemiOctahedronToVector(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateAutomaticMesh(AmplifyImpostorAsset data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh GenerateMesh(
      Vector2[] points,
      Vector3 offset,
      float width = 1f,
      float height = 1f,
      bool invertY = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmplifyImpostor() => throw null;
  }
}
