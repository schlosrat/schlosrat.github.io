// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadowSphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShadowSphere")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Shadow Sphere")]
  public class SgtShadowSphere : SgtShadow
  {
    public int Width;
    public TextureFormat Format;
    public float SharpnessR;
    public float SharpnessG;
    public float SharpnessB;
    [Range(0.0f, 1f)]
    public float Opacity;
    public float RadiusMin;
    public float RadiusMax;
    [NonSerialized]
    private Texture2D generatedTexture;
    [HideInInspector]
    [SerializeField]
    private bool startCalled;

    public Texture2D GeneratedTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Texture GetTexture() => throw null;

    [ContextMenu("Update Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WriteTexture(float u, int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void CalculateShadow(SgtLight light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetRadius(float a, float b, float theta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckUpdateCalls() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShadowSphere() => throw null;
  }
}
