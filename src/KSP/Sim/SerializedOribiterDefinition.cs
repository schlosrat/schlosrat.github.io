// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedOribiterDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
