// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadowLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Shadow Layer")]
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShadowLayer")]
  public class SgtShadowLayer : MonoBehaviour
  {
    public float Radius;
    public List<MeshRenderer> Renderers;
    [NonSerialized]
    private Material material;

    [ContextMenu("Apply Material")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyMaterial() => throw null;

    [ContextMenu("Remove Material")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRenderer(MeshRenderer renderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRenderer(MeshRenderer renderer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CameraPreRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShadowLayer() => throw null;
  }
}
