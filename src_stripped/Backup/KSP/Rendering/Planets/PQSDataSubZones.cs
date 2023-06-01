// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSDataSubZones
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
