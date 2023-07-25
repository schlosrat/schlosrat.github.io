// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.AmplifyImpostorAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    [SerializeField]
    [Range(1f, 33f)]
    public int VerticalFrames;
    [Range(0.0f, 64f)]
    [SerializeField]
    public int PixelPadding;
    [Range(4f, 16f)]
    [SerializeField]
    public int MaxVertices;
    [SerializeField]
    [Range(0.0f, 0.2f)]
    public float Tolerance;
    [SerializeField]
    [Range(0.0f, 1f)]
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
