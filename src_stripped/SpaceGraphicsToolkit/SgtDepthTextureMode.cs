// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtDepthTextureMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [DisallowMultipleComponent]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtDepthTextureMode")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Depth Texture Mode")]
  [RequireComponent(typeof (Camera))]
  public class SgtDepthTextureMode : MonoBehaviour
  {
    public DepthTextureMode DepthMode;
    [NonSerialized]
    private Camera cachedCamera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDepthMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtDepthTextureMode() => throw null;
  }
}
