// Decompiled with JetBrains decompiler
// Type: KSP.Animation.StackObjectsBetweenTwoPoints
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Inspector;
using KSP.OAB;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class StackObjectsBetweenTwoPoints : MonoBehaviour
  {
    private const string STACK_ROOT_NAME = "stack_root";
    private const string HALFSTACK_A_NAME = "halfstack_toward_a";
    private const string HALFSTACK_B_NAME = "halfstack_toward_b";
    [SerializeField]
    [Tooltip("REQUIRED 1st Point to build stack between")]
    private Transform _pointA;
    [Tooltip("REQUIRED 2nd Point to build stack between")]
    [SerializeField]
    private Transform _pointB;
    [Tooltip("REQUIRED Pieces to instance to build the stack with")]
    [SerializeField]
    private List<GameObject> _originalStackPieces;
    [Space(15f)]
    [Tooltip("OPTIONAL Scalable gamebject with collision under it")]
    [SerializeField]
    private GameObject _scalableCollision;
    [SerializeField]
    [Tooltip("false = Flip halfstack along Z axis. true = flip halfstack along X axis.")]
    private bool _flipHalfStackAlongAlternateAxis;
    [SerializeField]
    [Tooltip("if true, will flip each piece in the half stack on the starting side without changing their order.")]
    private bool _reverseStartSideStack;
    [SerializeField]
    [Tooltip("if true, will flip each piece in the half stack on the ending side without changing their order.")]
    private bool _reverseEndSideStack;
    [SerializeField]
    private bool _doScaleEndPiece;
    [Tooltip("false = Stack pieces between start and end point.\ntrue = do a single scaled piece between start and end point.")]
    [SerializeField]
    private bool _doSinglePieceScaled;
    [SerializeField]
    [Tooltip("OPTIONAL End piece to instance and scale at either end of stack")]
    private GameObject _originalScalableEndPiece;
    [SerializeField]
    [Tooltip("OPTIONAL Decoration pieces to instance and place between each stack piece")]
    private List<GameObject> _originalStackDecorationPieces;
    private Transform _startAnchorLookTransform;
    private Transform _endAnchorLookTransform;
    private List<StackObjectsBetweenTwoPoints.StackPieceData> _sortedStackPieceData;
    private bool _rootDecorationsExist;
    private StackObjectsBetweenTwoPoints.StackPieceData _scalableCollisionData;
    private StackObjectsBetweenTwoPoints.StackPieceData _scalableEndPieceData;
    private GameObject _stackRoot;
    private GameObject _halfStackTowardA;
    private GameObject _halfStackTowardB;
    private Vector3 _originalColScale;
    private bool _selfDestructing;
    private Vector3 _lastStart;
    private Vector3 _lastEnd;
    private ObjectAssemblyBuilderEvents _builderEvents;
    private List<Action> _actions;
    private bool _initialized;
    [Space(15f)]
    [SerializeField]
    [ReadOnly]
    private double _lastDistance;

    public GameObject StackRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform StartPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform EndPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 LinkStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 LinkEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool SinglePieceScaled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform StartAnchorLookTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform EndAnchorLookTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyConnector(bool immediate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanThisScriptRun() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(List<Action> actions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilderEvents builderEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableActions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFullScalePositioning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStackedPieces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReverseEachHalfStackPiece(
      Transform halfStackRoot,
      StackObjectsBetweenTwoPoints.HalfStackData halfStackData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SortLongestFirst(
      StackObjectsBetweenTwoPoints.StackPieceData spd1,
      StackObjectsBetweenTwoPoints.StackPieceData spd2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetStack(bool immediate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private StackObjectsBetweenTwoPoints.HalfStackData CalculateHalfStack(double fullDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildHalfStack(
      GameObject halfStackRoot,
      StackObjectsBetweenTwoPoints.HalfStackData halfStackData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject MakeOtherHalfStack(GameObject halfStackToMatch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUpdateCollision(double fullLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryAddDecorations(GameObject stackPiece) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddDecorations(Transform stackPieceTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryUpdateScalableEndPiece(
      GameObject halfStack,
      StackObjectsBetweenTwoPoints.HalfStackData halfStackData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLayer(GameObject obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetZLengthOfGameObject(GameObject toMeasure) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetZLengthOfCollider(Collider toMeasure) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackObjectsBetweenTwoPoints() => throw null;

    internal class StackPieceData
    {
      public string Name;
      public int Index;
      public double Length;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StackPieceData(string _name, int _index, double _length) => throw null;
    }

    internal class HalfStackData
    {
      public List<int> PieceCounts;
      public double HalfStackLength;
      public double RemainderDistance;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HalfStackData() => throw null;
    }
  }
}
