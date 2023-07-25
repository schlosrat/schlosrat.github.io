// Decompiled with JetBrains decompiler
// Type: PAParticleField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof (MeshRenderer))]
public class PAParticleField : KerbalMonoBehaviour, IFixedUpdate
{
  private static readonly string[] builtinShaderNames;
  private const int MAX_PARTICLE_COUNT = 16250;
  public bool clearCacheInBuilds;
  private bool isOpenGL;
  [SerializeField]
  private int mSeed;
  [SerializeField]
  private PAParticleField.ParticleType mGeneratorType;
  [SerializeField]
  private Mesh mInputMesh;
  [SerializeField]
  private int mParticleCount;
  [SerializeField]
  private float mParticleCountMask;
  [SerializeField]
  private Vector3 mFieldSize;
  [SerializeField]
  private Vector3 mEdgeThreshold;
  [SerializeField]
  private PAParticleField.EdgeMode mEdgeMode;
  [SerializeField]
  private PAParticleField.SimulationSpace mSimulationSpace;
  [SerializeField]
  private PAParticleField.Shape mShape;
  [SerializeField]
  private bool mUseExclusionZones;
  [SerializeField]
  private Transform mExclusionAnchorOverride;
  [SerializeField]
  private Vector2 mParticleSize;
  [SerializeField]
  private float mSpeed;
  [SerializeField]
  private Vector3 mSpeedMask;
  [SerializeField]
  private Color mColor;
  [SerializeField]
  private Vector3 mForce;
  [SerializeField]
  private bool mCustomFacingDirection;
  [SerializeField]
  private Vector3 mFacingDirection;
  [SerializeField]
  private bool mCustomUpDirection;
  [SerializeField]
  private Vector3 mUpDirection;
  [SerializeField]
  private bool mStretchedBillboard;
  [SerializeField]
  private float mSpeedScaleMultiplier;
  [SerializeField]
  private bool mSpin;
  [SerializeField]
  private float mSpinSpeed;
  [SerializeField]
  private float mMinSpinSpeed;
  [SerializeField]
  private bool mCustomRotationAxis;
  [SerializeField]
  private Vector3 mRotationAxis;
  [SerializeField]
  private PAParticleField.SoftParticleType mSoftParticles;
  [SerializeField]
  private float mNearFadeDistance;
  [SerializeField]
  private float mNearFadeOffset;
  [SerializeField]
  private float mSoftness;
  [SerializeField]
  private PAParticleField.TurbulenceType mTurbulenceType;
  [SerializeField]
  private float mTurbulenceFrequency;
  [SerializeField]
  private float mTurbulenceAmplitude;
  [SerializeField]
  private Vector3 mTurbulenceScale;
  [SerializeField]
  private Vector3 mTurbulenceOffsetSpeed;
  [SerializeField]
  private Gradient mColorVariation;
  [SerializeField]
  private float mMinimumSize;
  [SerializeField]
  private float mMinimumSpeed;
  [SerializeField]
  private PAParticleField.MaterialType mMaterialType;
  [SerializeField]
  private Shader mShader;
  [SerializeField]
  private Texture2D mTexture;
  [SerializeField]
  private Vector2 mPivotOffset;
  [SerializeField]
  private PAParticleField.TextureType mTextureType;
  [SerializeField]
  private int mSpriteColumns;
  [SerializeField]
  private int mSpriteRows;
  [SerializeField]
  private float mFramerate;
  [SerializeField]
  private float mCutOff;
  [SerializeField]
  private bool mReceiveShadows;
  [SerializeField]
  private ShadowCastingMode mCastShadows;
  private Mesh particleMesh;
  private MeshFilter meshFilter;
  private MeshRenderer meshRenderer;
  [SerializeField]
  private PAParticleMeshGenerator m_MeshGenerator;
  [SerializeField]
  public Material material;
  private Material renderingMaterial;
  private float time;
  private Vector3 speedTime;
  private Vector3 forceTime;
  private float spinTime;
  private Vector3 turbulenceOffsetTime;
  private float frameTime;
  private Vector3 position;
  private Position simPosition;
  private Vector3 deltaPosition;
  private Vector3 scale;
  private bool foundExclusionZones;
  private PAExclusionZone[] zones;
  [SerializeField]
  private Material temporarySerializableMaterial;

  public int seed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.ParticleType generatorType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int particleCount
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float particleCountMask
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 fieldSize
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 edgeThreshold
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.SimulationSpace simulationSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.Shape shape
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.EdgeMode edgeMode
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool useExclusionZones
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Transform exclusionAnchorOverride
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Color color
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float alpha
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float speed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 speedMask
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector2 particleSize
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool stretchedBillboard
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float speedScaleMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool spin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float spinSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float minSpinSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool customRotationAxis
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 rotationAxis
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool customFacingDirection
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 facingDirection
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool customUpDirection
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 upDirection
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.SoftParticleType softParticles
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float nearFadeDistance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float nearFadeOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float softness
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.TurbulenceType turbulenceType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float turbulenceFrequency
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float turbulenceAmplitude
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 turbulenceScale
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 turbulenceOffsetSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Gradient colorVariation
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float minimumSize
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float minimumSpeed
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 force
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.MaterialType materialType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Shader shader
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public Texture2D texture
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public PAParticleField.TextureType textureType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int spriteColumns
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public int spriteRows
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float framerate
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float cutOff
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector2 pivotOffset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Mesh inputMesh
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool receiveShadows
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public ShadowCastingMode castShadows
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private PAParticleMeshGenerator meshGenerator
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public MeshFlags meshIsDirtyMask
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool shaderIsDirty
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private T GetOrAddComponent<T>() where T : Component => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetRenderingComponents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateAssetTypes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Material CreateInstanceMaterial() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGeneratorType(PAParticleField.ParticleType newType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetShaderValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetKeyword(string keyword, bool enable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void SetMaterialKeyword(string keyword, bool enable, Material material) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetFloatKeyword(string keyword, bool enable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetFloatKeyword(int keywordID, bool enable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateParticleField() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateShader() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateAnimationValues(float deltaTime) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Simulate(float t, bool restart = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateExclusionZoneValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetShaderAnimationValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetShaderExclusionZoneValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RegisterEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetTimers() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  void IFixedUpdate.OnFixedUpdate(float deltaTime) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnWillRenderObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int GetMaxCount() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Bounds GetBounds() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static PAParticleField Create(string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateTemporarySerializableMaterial() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PAParticleField() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static PAParticleField() => throw null;

  public enum ParticleType
  {
    Billboard,
    Mesh,
    Custom,
  }

  public enum SimulationSpace
  {
    World,
    Local,
    LocalWithDelta,
  }

  public enum Shape
  {
    Cube,
    Sphere,
    Cylinder,
  }

  public enum EdgeMode
  {
    Alpha,
    Scale,
    Both,
  }

  public enum MaterialType
  {
    Transparent,
    TransparentLit,
    Additive,
    AdditiveLit,
    CutOff,
    CutOffLit,
    Custom,
    MeshDefault,
    MeshUnlit,
  }

  public enum TextureType
  {
    Simple,
    SpriteGrid,
    AnimatedRows,
  }

  public enum SoftParticleType
  {
    None,
    NearClipOnly,
    NearClipAndCameraDepth,
  }

  public enum TurbulenceType
  {
    None,
    Simplex2D,
    Simplex,
  }
}
