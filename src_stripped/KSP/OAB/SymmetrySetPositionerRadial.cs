// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SymmetrySetPositionerRadial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class SymmetrySetPositionerRadial : ISymmetrySetPositioner
  {
    private readonly int _size;
    private readonly BuilderSymmetryMode _builderSymmetryMode;

    public SymmetryType SymmetryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public BuilderSymmetryMode BuilderSymmetryMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetPositionerRadial(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PositionData> PositionFromAnchor(
      IObjectAssemblyPart temporaryParent,
      PositionData anchor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PositionData> PositionFromAnchor(
      IObjectAssemblyPart temporaryParent,
      PositionData anchorData,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PositionData> CalculateSimpleSymmetry(
      IObjectAssemblyPart temporaryParent,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode,
      float anglePerPart,
      IObjectAssemblyPart positionReference,
      Vector3 anchorLocalOffset,
      Quaternion anchorLocalRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PositionData> CalculateComplexRecursiveSymmetry(
      IObjectAssemblyPart temporaryParent,
      PositionData anchorData,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode,
      float anglePerPart,
      SymmetrySet parentSymmetrySet,
      bool isParentMirrorSet,
      IObjectAssemblyPart positionReference,
      Vector3 anchorLocalOffset,
      Quaternion anchorLocalRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<PositionData> CalculateSimpleRecursiveSymmetry(
      IObjectAssemblyPart temporaryParent,
      PositionData anchorData,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode,
      float anglePerPart,
      SymmetrySet parentSymmetrySet,
      IObjectAssemblyPart highestPartWithSameSet,
      IObjectAssemblyPart positionReference,
      Vector3 anchorLocalOffset,
      Quaternion anchorLocalRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static List<IObjectAssemblyPartNode> CollectNodesInSameSymmetryGroup(
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPart positionReference)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CalculateRadialPositionData(
      IObjectAssemblyPart parentPart,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale,
      float rotationAngleDegrees,
      bool isSymmetryMirrored,
      ref PositionData positionData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MirrorPositionData(
      IObjectAssemblyPart positionReference,
      PositionData anchorData,
      ref PositionData mirrorPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RotateToFront<T>(List<T> toModify, T toTargetAndRemove) => throw null;
  }
}
