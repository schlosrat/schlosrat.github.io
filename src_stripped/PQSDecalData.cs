// Decompiled with JetBrains decompiler
// Type: PQSDecalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[PreferBinarySerialization]
[Serializable]
public class PQSDecalData : ScriptableObject
{
  public List<SerializedPQSDecalInstance> SerializedPqsDecalInstanceList;
  public List<string> DeleteDecalList;
  public List<PQSDecal> BakedPqsDecalList;
  public List<string> BakedPqsDecalIDList;
  public Texture2DArray DiffuseTextureArray;
  public Texture2DArray NormalTextureArray;
  public Texture2DArray AlphaMaskTextureArray;
  public Texture2DArray PeakTextureArray;
  public Texture2DArray SlopeTextureArray;
  [HideInInspector]
  public int Count;
  [HideInInspector]
  public ushort[] HeightData;
  [HideInInspector]
  public int HeightWidth;
  [HideInInspector]
  public int HeightHeight;
  [HideInInspector]
  public ushort[] AlphaData;
  [HideInInspector]
  public int AlphaWidth;
  [HideInInspector]
  public int AlphaHeight;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SerializePqsDecalInstance(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SerializeDeleteDecal(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearSerializedPQSDecalInstaces() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DeserializePqsDecalInstance(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveSerializedDecalInstance(PQSDecalInstance pqsDecalInstance) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private SerializedPQSDecalInstance GetSerializedInstance(string decalInstanceID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSDecalData() => throw null;
}
