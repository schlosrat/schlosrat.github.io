// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedPredefinedSimObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public struct SerializedPredefinedSimObject
  {
    public string Name;
    public string RelativeTo;
    public TransformFrameType ReferenceFrame;
    public Vector3d LocalPosition;
    public Quaternion LocalRotation;
    public bool FixedGuid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedPredefinedSimObject(PredefinedSimObject simObject) => throw null;
  }
}
