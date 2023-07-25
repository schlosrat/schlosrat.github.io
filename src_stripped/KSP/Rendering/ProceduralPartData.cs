// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ProceduralPartData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [Serializable]
  public class ProceduralPartData
  {
    public bool showEditor;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public bool flipOffset;
    public Transform offset;
    public bool enableRotX;
    public ProceduralPartData.TransformDir upDirX;
    public ProceduralPartData.TransformDir compareDirX;
    public bool flipRotX;
    public Transform anchorX01;
    public Transform anchorX02;
    public bool enableRotY;
    public ProceduralPartData.TransformDir upDirY;
    public ProceduralPartData.TransformDir compareDirY;
    public bool flipRotY;
    public Transform anchorY01;
    public Transform anchorY02;
    public bool enableRotZ;
    public ProceduralPartData.TransformDir upDirZ;
    public ProceduralPartData.TransformDir compareDirZ;
    public bool flipRotZ;
    public Transform anchorZ01;
    public Transform anchorZ02;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartData() => throw null;

    public enum TransformDir
    {
      right,
      up,
      forward,
    }
  }
}
