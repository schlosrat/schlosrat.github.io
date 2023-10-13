// Decompiled with JetBrains decompiler
// Type: AxisBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

[Obsolete("requires some porting", false)]
public class AxisBinding : ICloneable
{
  public AxisBinding_Single primary;
  public AxisBinding_Single secondary;
  private float pAxis;
  private float sAxis;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(float neutral) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(float neutral, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(InputBindingModes useSwitch) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(InputBindingModes useSwitch, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(InputBindingModes useSwitch, float neutral) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(InputBindingModes useSwitch, float neutral, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(string Id, string Name, bool isInverted) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(string Id, string Name, bool isInverted, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(
    string Id,
    string Name,
    bool isInverted,
    float sens,
    float dead_zone,
    float axisScale)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisBinding(
    string Id,
    string Name,
    bool isInverted,
    float sens,
    float dead_zone,
    float axisScale,
    ControlTypes lockMask)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsNeutral() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public object Clone() => throw null;

  public float deadzone
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float scale
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }
}
