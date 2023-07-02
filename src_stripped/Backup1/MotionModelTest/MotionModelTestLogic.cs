// Decompiled with JetBrains decompiler
// Type: MotionModelTest.MotionModelTestLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using Shapes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MotionModelTest
{
  public class MotionModelTestLogic : ImmediateModeShapeDrawer
  {
    private MotionModelTestLogic.ObjectDefinition[] objectDefinitions;
    private ITransformFrame origin;
    private float originRadius;
    private Color originColor;
    private Dictionary<string, MotionModelTestLogic.ObjectData> _nameDataMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitFromDefinitions(
      IEnumerable<MotionModelTestLogic.ObjectDefinition> definitions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoOnHierarchyRecursive(
      ITransformModel parent,
      Action<MotionModelTestLogic.ObjectData> action)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DrawShapes(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawData(ITransformFrame viewer, MotionModelTestLogic.ObjectData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MotionModelTestLogic() => throw null;

    [Serializable]
    public struct ObjectDefinition
    {
      public string name;
      public float radius;
      public Color color;
      public bool isPlayer;
      public string parent;
      public TransformFrameType parentFrame;
      public Vector2d localPosition;
      public double localRotation;
      public Vector2d localVelocity;
      public double localAngularVelocity;
    }

    private class ObjectData
    {
      public TransformModel Transform
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public MotionModelTestLogic.ObjectDefinition Definition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float RadiusBody
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float RadiusCelestial
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Color ColorBody
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Color ColorCelestial
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ObjectData(MotionModelTestLogic.ObjectDefinition definition) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetLocals(MotionModelTestLogic.ObjectDefinition def) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetLocals(
        Vector2d localPosition,
        double localRotation,
        Vector2d localVelocity,
        double localAngularVelocity)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ChangeVelocity(Vector3d localVelDelta) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ChangeAngVel(Vector3d localAngVelDelta) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateFromInputs(float deltaTime, Vector2 velInputs, float angVelInputs) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateKinematics(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsInCelestial(Position position) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsInBody(Position position) => throw null;
    }

    private class CaseInsensitiveComparer : IEqualityComparer<string>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool Equals(string x, string y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int GetHashCode(string obj) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CaseInsensitiveComparer() => throw null;
    }
  }
}
