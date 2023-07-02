// Decompiled with JetBrains decompiler
// Type: KSP.OAB.IObjectAssemblyPartNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using UnityEngine;

namespace KSP.OAB
{
  public interface IObjectAssemblyPartNode
  {
    IObjectAssemblyPart Owner { get; }

    Transform NodeTransform { get; }

    string NodeTag { get; }

    string NodeSymmetryGroupID { get; }

    bool IsAvailable { get; }

    bool IsConnected { get; }

    bool ConnectionIsParent { get; }

    bool IsDynamic { get; }

    AttachNodeType NodeType { get; }

    IObjectAssemblyPart ConnectedPart { get; }

    Vector3 WorldPosition { get; }

    Vector3 PartRelativePosition { get; }

    Vector3 AssemblyRelativePosition { get; }

    Quaternion WorldRotation { get; }

    Quaternion PartRelativeRotation { get; }

    Quaternion AssemblyRelativeRotation { get; }

    float Radius { get; }

    void Show(bool show);

    void ConnectToPart(IObjectAssemblyPartNode target);

    void ConnectExplicitlyToPart(IObjectAssemblyPart part);

    void DisconnectFromPart();
  }
}
