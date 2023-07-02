// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtDepthTextureMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtDepthTextureMode")]
  [DisallowMultipleComponent]
  [RequireComponent(typeof (Camera))]
  [AddComponentMenu("Space Graphics Toolkit/SGT Depth Texture Mode")]
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
