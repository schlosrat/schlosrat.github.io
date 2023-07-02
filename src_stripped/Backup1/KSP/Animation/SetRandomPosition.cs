// Decompiled with JetBrains decompiler
// Type: KSP.Animation.SetRandomPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class SetRandomPosition : KerbalMonoBehaviour
  {
    private static System.Random _randomizer;
    [SerializeField]
    private bool _useOffsetRange;
    [SerializeField]
    private Vector3 _minOffset;
    [SerializeField]
    private Vector3 _maxOffset;
    [SerializeField]
    private Transform[] _positionOptions;
    private Vector3 _originalLocalPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetRandomVector3InRange(Vector3 min, Vector3 max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetRandomFloatInRange(float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SetRandomPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SetRandomPosition() => throw null;
  }
}
