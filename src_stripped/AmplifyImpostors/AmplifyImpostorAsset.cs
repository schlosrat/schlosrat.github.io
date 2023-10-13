// Decompiled with JetBrains decompiler
// Type: AmplifyImpostors.AmplifyImpostorAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [SerializeField]
    [HideInInspector]
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
    [Range(0.0f, 0.2f)]
    [SerializeField]
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
