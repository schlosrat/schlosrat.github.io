// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyAvailablePartNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using UnityEngine;

namespace KSP.OAB
{
  public interface IObjectAssemblyAvailablePartNode
  {
    bool IsDynamic { get; }

    float Radius { get; }

    Vector3 LocalPosition { get; }

    Quaternion LocalRotation { get; }

    string NodeTag { get; }

    string NodeSymmetryGroupID { get; }

    float VisualRadius { get; }

    AttachNodeType NodeType { get; }
  }
}
