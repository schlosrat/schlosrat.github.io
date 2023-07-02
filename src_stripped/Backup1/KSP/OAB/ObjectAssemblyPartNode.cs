// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyPartNode : MonoBehaviour, IObjectAssemblyPartNode
  {
    public IObjectAssemblyPart Owner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string NodeTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string NodeSymmetryGroupID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsAvailable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsConnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDynamic
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ConnectionIsParent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AttachNodeType NodeType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart ConnectedPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 WorldPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 PartRelativePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 AssemblyRelativePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion WorldRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion PartRelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion AssemblyRelativeRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform NodeTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectToPart(IObjectAssemblyPartNode target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectExplicitlyToPart(IObjectAssemblyPart target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectFromPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartNode() => throw null;
  }
}
