// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AerialPerspective
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  public class AerialPerspective : MonoBehaviour
  {
    private Camera m_camera;
    private Material material;
    private RenderTexture transmittanceVolume;
    private RenderTexture scatteringVolume;
    public Vector3Int volumeTexSize;
    private Vector3[] _FrustumCorners;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [ImageEffectOpaque]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AerialPerspective() => throw null;
  }
}
