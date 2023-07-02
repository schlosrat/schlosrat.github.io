// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedPredefinedSimObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
