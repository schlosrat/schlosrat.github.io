// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedOribiterDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedOribiterDefinition
  {
    public Color orbitColor;
    public Color nodeColor;
    public float lowerCamVsSmaRatio;
    public float upperCamVsSmaRatio;
    public bool autoTextureOffset;
    public float textureOffset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedOribiterDefinition() => throw null;
  }
}
