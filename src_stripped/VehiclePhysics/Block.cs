// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Block
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Block
  {
    private Block.Connection[] m_inputs;
    private Block.Connection[] m_outputs;
    private int m_connectedInputs;
    private int m_connectedOutputs;
    public static float RpmToW;
    public static float WToRpm;

    public Block.Connection[] inputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Block.Connection[] outputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool hasInputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool hasOutputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int connectedInputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int connectedOutputs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void PreStep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void GetState(ref Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetSubstepState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Block() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetInputs(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetOutputs(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Connect(Block inputUnit, int inputSlot, Block outputUnit, int outputSlot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Connect(Block inputUnit, Block outputUnit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Connect(Block inputUnit, Block outputUnit, int outputSlot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Connect(params Block[] blocks) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DisconnectInput(int inputSlot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DisconnectOutput(int outputSlot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CountConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Block() => throw null;

    public class Connection
    {
      public float L;
      public float I;
      public float Tr;
      public float outTd;
      public Block input;
      public int inputSlot;
      public Block output;
      public int outputSlot;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Connection() => throw null;
    }

    public struct State
    {
      public float L;
      public Vector2 P;
      public float Lr;
    }

    public struct Derivative
    {
      public float T;
      public Vector2 F;
      public float Tr;
    }
  }
}
