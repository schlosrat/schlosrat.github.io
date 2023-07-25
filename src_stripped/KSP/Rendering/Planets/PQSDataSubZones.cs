// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSDataSubZones
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [CreateAssetMenu(fileName = "planet", menuName = "PQS/PQSDataSubZones")]
  public class PQSDataSubZones : ScriptableObject
  {
    public int TextureSize;
    public Material SourceMaterial;
    public Texture2DArray SubZonesNormalTextureArray;
    public Vector4 Subzone1Indices;
    public Vector4 Subzone2Indices;
    public Vector4 Subzone3Indices;
    public Vector4 Subzone4Indices;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSDataSubZones() => throw null;
  }
}
