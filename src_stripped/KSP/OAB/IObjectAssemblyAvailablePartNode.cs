// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyAvailablePartNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
