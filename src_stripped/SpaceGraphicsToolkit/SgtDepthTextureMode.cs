// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtDepthTextureMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtDepthTextureMode")]
  [RequireComponent(typeof (Camera))]
  [DisallowMultipleComponent]
  [AddComponentMenu("Space Graphics Toolkit/SGT Depth Texture Mode")]
  [ExecuteInEditMode]
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
