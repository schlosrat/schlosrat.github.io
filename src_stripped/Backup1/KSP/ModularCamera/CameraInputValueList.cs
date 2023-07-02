// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.CameraInputValueList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace KSP.ModularCamera
{
  public struct CameraInputValueList : IEnumerable
  {
    private double[] data;
    private static readonly Dictionary<System.Type, CameraInputValueList.ToStringHelper> typeValueToStringLookup;
    private static readonly Dictionary<System.Type, string> typetoStringLookup;

    public System.Type StoredType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Get(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSafe(int index) => throw null;

    public float x
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float y
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float z
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float w
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MagnitudeSqr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Magnitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(double value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(double[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(float[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector2 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector3 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector4 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Quaternion values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector2d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector3d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(Vector4d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator CameraInputValueList(QuaternionD values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(CameraInputValueList other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator -(CameraInputValueList list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator -(CameraInputValueList other, double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator -(CameraInputValueList other, IEnumerable vals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator +(CameraInputValueList other, double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator +(CameraInputValueList other, IEnumerable vals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator *(CameraInputValueList other, double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator *(CameraInputValueList other, IEnumerable vals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator /(CameraInputValueList other, double val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList operator /(CameraInputValueList other, IEnumerable vals) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputValueList Lerp(
      CameraInputValueList lhs,
      CameraInputValueList rhs,
      double t)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(bool noType = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(params double[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(params float[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(CameraInputValueList other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(IEnumerable values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector2 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector3 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector4 values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Quaternion values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector2d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector3d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(Vector4d values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraInputValueList(QuaternionD values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double[] ToDoubleArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float[] ToFloatArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ToDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ToFloat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 ToVector2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 ToVector3() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4 ToVector4() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion ToQuaternion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2d ToVector2d() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToVector3d() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4d ToVector4d() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ToQuaternionD() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraInputValueList() => throw null;

    private delegate void ToStringHelper(StringBuilder builder, CameraInputValueList list);
  }
}
