// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class PositionData
  {
    public Vector3 Position;
    public Quaternion Rotation;
    public Vector3 LocalScale;
    public IObjectAssemblyPart Parent;
    public bool IsSymmetryMirrored;
    public Vector3 ReferenceUp;
    public Vector3 ReferenceForward;
    public string ParentNodeTag;
    public string ChildNodeTag;
    public Vector3 LocalPosition;
    public Quaternion LocalRotation;
    public MirrorTechnique MirrorTechnique;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionData(IObjectAssemblyPart parent) => throw null;
  }
}
