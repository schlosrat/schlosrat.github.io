// Decompiled with JetBrains decompiler
// Type: KSP.Game.KerbalPhotoBooth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Networking.MP.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class KerbalPhotoBooth : KerbalMonoBehaviour, IDisposable
  {
    private const string OUTPUT_TEXTURES_DIRECTORY = "KerbalPortraitTextures";
    private const string JETPACK_ROOT_BONE_NAME = "bone_kerbal_eva_ach";
    private List<Texture2D> _generatedKerbalPhotos;
    private Coroutine _currentPhotoInProgress;
    [SerializeField]
    [Header("Game Object References")]
    private Camera _photoBoothCamera;
    [SerializeField]
    private Kerbal3DModel _kerbal3DModelGameObject;
    [SerializeField]
    private GameObject _photoLocation;
    [SerializeField]
    private GameObject _waitingLocation;
    [SerializeField]
    [Header("Quality & Performance")]
    private int _resolution;
    [SerializeField]
    private int _numberOfSimultaneousModels;
    [SerializeField]
    [Space(10f)]
    private int _poseIndexMax;
    [SerializeField]
    private string _poseIndexParamName;
    [SerializeField]
    private string _expressionValueParamName;
    [SerializeField]
    private float _minExpressionValue;
    [SerializeField]
    private float _maxExpressionValue;
    [SerializeField]
    private string _expressionVarianceParamName;
    [SerializeField]
    private string _eyeOffsetParamName;
    [SerializeField]
    private string _eyeSymmetryParamName;
    [SerializeField]
    private string _stupidityBasedEyesParamName;
    [SerializeField]
    private float _specificEyeStupdityValueForJebediah;
    [SerializeField]
    private float _specificEyeStupidityValueForBill;
    [SerializeField]
    private string[] _zeroToOneAnimatorParamaterNames;
    [Header("Attributes Used When Posing")]
    [SerializeField]
    private string _attrForEyePhase;
    [SerializeField]
    private string _attrForExpression;
    [SerializeField]
    private string _attrForEyeHeight;
    [SerializeField]
    private string _attrForEyeSymmetry;
    [SerializeField]
    [Header("Debug")]
    private bool _saveDebugTextureFiles;
    [SerializeField]
    private string _debugTextureFileDirectory;
    private string _debugLogOutput;
    private RenderTexture _renderTexture;
    private Dictionary<string, KerbalInfo> _waitingForModel;
    private List<KerbalInfo> _waitingForBooth;
    private bool _areKerbalsWaitingForBooth;
    private List<Kerbal3DModel> _allKerbalModels;
    private Dictionary<KerbalInfo, Kerbal3DModel> _modelsInUse;
    private KerbalRosterManager _roster;
    private MPRandom _randomizer;

    private bool _hasAvailableModels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TakeKerbalPortrait(KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCharacterCompletelyGenerated(string fullName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator PictureTime(KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGenerateWithAvailableModel(KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PoseKerbalForPicture(KerbalInfo kerbalInfo, Kerbal3DModel kerbal3DModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetKVSValueFromZeroToOne(string kerbalName, string AttrName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Sprite SnapPhoto() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseRenderTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WriteTexture(KerbalInfo kerbalInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalPhotoBooth() => throw null;
  }
}
