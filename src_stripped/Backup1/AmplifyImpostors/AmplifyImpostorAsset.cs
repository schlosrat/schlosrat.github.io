// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.AmplifyImpostorAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyImpostors
{
  [CreateAssetMenu(fileName = "New Impostor", order = 85)]
  public class AmplifyImpostorAsset : ScriptableObject
  {
    [SerializeField]
    public Material Material;
    [SerializeField]
    public Mesh Mesh;
    [HideInInspector]
    [SerializeField]
    public int Version;
    [SerializeField]
    public ImpostorType ImpostorType;
    [HideInInspector]
    [SerializeField]
    public bool LockedSizes;
    [SerializeField]
    [HideInInspector]
    public int SelectedSize;
    [SerializeField]
    public Vector2 TexSize;
    [HideInInspector]
    [SerializeField]
    public bool DecoupleAxisFrames;
    [SerializeField]
    [Range(1f, 32f)]
    public int HorizontalFrames;
    [Range(1f, 33f)]
    [SerializeField]
    public int VerticalFrames;
    [SerializeField]
    [Range(0.0f, 64f)]
    public int PixelPadding;
    [SerializeField]
    [Range(4f, 16f)]
    public int MaxVertices;
    [Range(0.0f, 0.2f)]
    [SerializeField]
    public float Tolerance;
    [Range(0.0f, 1f)]
    [SerializeField]
    public float NormalScale;
    [SerializeField]
    public Vector2[] ShapePoints;
    [SerializeField]
    public AmplifyImpostorBakePreset Preset;
    [SerializeField]
    public List<TextureOutput> OverrideOutput;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AmplifyImpostorAsset() => throw null;
  }
}
