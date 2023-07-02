// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
