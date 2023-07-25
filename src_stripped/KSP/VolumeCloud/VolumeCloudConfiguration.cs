// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.VolumeCloudConfiguration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.VolumeCloud
{
  [CreateAssetMenu]
  [Serializable]
  public class VolumeCloudConfiguration : ScriptableObject
  {
    public Mesh boxCloudMesh;
    private ComputeBuffer CloudsLayersComputeBuffer;
    public string bodyName;
    [NonSerialized]
    public Vector3 cameraPosition;
    public Vector3 cameraForward;
    [NonSerialized]
    public bool configHasChanged;
    public bool exclusiveLayer;
    public Vector3 CloudsRotateAll;
    [NonSerialized]
    private float timeInite;
    [NonSerialized]
    private float gameTimeScale;
    public float planetRadius;
    [NonSerialized]
    public Vector3 planetCenter;
    [NonSerialized]
    public Matrix4x4 planetRotation;
    private int[] sparseTextureTileIndex;
    public Texture2D verticalColorMap;
    private Texture underOceanPixelTexture;
    public bool enableColorMap;
    public bool enableVerticalColor;
    public float colorMapIntensity;
    public float verticalColorIntensity;
    public Gradient ColorVertical;
    public float overallSize;
    private Texture2D curlNoise;
    [Range(0.001f, 1f)]
    private float curlTile;
    private float curlStrength;
    [Header("Vortex/Lenticular Shape")]
    public Vector2 vortexCloudHeightRange;
    public Cubemap vortexCloudColorMap;
    private Matrix4x4 layerRotateMatrix;
    private Matrix4x4 inverseLayerRotateMatrix;
    [SerializeField]
    public List<VolumeCloudConfiguration.CloudBoxSetting> lenticularList;
    [SerializeField]
    public List<VolumeCloudConfiguration.BoxCloudsGroup> boxCloudsGroupList;
    [SerializeField]
    public List<VolumeCloudConfiguration.CumulusData> cumulusList;
    [SerializeField]
    public List<int> cumulusIndex;
    [Header("Shape - Modifiers")]
    [Range(0.0f, 1f)]
    public float cloudCoverageModifier;
    [Range(1f, 10000f)]
    public float detailVariationRange;
    [Header("Shadows")]
    public bool enableShadows;
    public bool realTimeShadows;
    public bool enableLayerShadows;
    [Range(1f, 50f)]
    public int shadowDetectSteps;
    public float realTimeShadowDistance;
    [Range(0.01f, 4f)]
    public float shadowDetectStepScale;
    [Range(0.1f, 4f)]
    public float shadowDensity;
    [Range(0.1f, 4f)]
    public float shadowOpacity;
    [Range(0.1f, 4f)]
    public float shadowMapStrength;
    [Range(0.1f, 4f)]
    public float layerShadowDensity;
    [Range(0.0f, 10f)]
    public float shadowBlurSize;
    [Header("Lighting")]
    public Color ambientColor;
    public const float COEFFICIENT_SCALE = 0.01f;
    [Range(0.01f, 1f)]
    public float extinctionByCameraPosition;
    [Range(0.1f, 2f)]
    public float scatteringCoefficient;
    public bool EnableCloudGI;
    [Range(0.0f, 0.5f)]
    public float cloudGIIntensity;
    [Range(-1f, 1f)]
    public float sunsetStart;
    [Range(-1f, 1f)]
    public float sunsetEnd;
    [Header("Lighting - Multi Scattering Approximation")]
    [Range(0.01f, 50f)]
    public float lightPenetrateDistance;
    [Range(0.01f, 1f)]
    private float multiScatteringScattering;
    [Range(0.01f, 1f)]
    public float extinctionByLightPosition;
    [Range(0.01f, 1f)]
    public float opticsDistanceScale;
    public float silverSpreadG;
    public float bloomStrengthG;
    public float silverSpreadUnderCloudG;
    public float bloomStrengthUnderCloudG;
    [Header("Lighting - Silver")]
    [Range(0.0f, 0.5f)]
    public float silverSpread;
    [Range(0.0f, 0.5f)]
    public float bloomStrength;
    [Range(0.0f, 1f)]
    public float silverSpreadUnderCloud;
    [Range(0.0f, 1f)]
    public float bloomStrengthUnderCloud;
    [Range(0.001f, 5f)]
    public float ambinetScale;
    [Range(0.0f, 20f)]
    public float scatteringScale;
    [Range(0.0f, 5f)]
    public float cloudsDensityScale;
    [Header("Lighting Atmosphere")]
    public bool enableAtmosphere;
    public float atmosphereBottomHeight;
    public float atmosphereTopHeight;
    [Range(0.0f, 3f)]
    public Vector2 atmosphereIntensity;
    [Range(0.0f, 3f)]
    public Vector2 atmosphereDistanceFalloff;
    [Header("Lighting - Godray")]
    public bool enableGodray;
    [Range(0.01f, 2f)]
    public float godrayIntensity;
    [Range(100f, 50000f)]
    public float godrayVisableDistance;
    [Range(1f, 200f)]
    public float godrayStepSize;
    [Range(1f, 200f)]
    public float sampleLightStepSize;
    [Range(1f, 100f)]
    public float sampleLightStepCount;
    [Range(0.0f, 1f)]
    public Vector2 cloudDensityRangeEmitGodray;
    [Range(0.0f, 1f)]
    public float godrayAttenuation;
    [Range(1000f, 3000f)]
    public float godrayFadeHeight;
    [Range(0.0f, 10f)]
    public float godrayBlurSize;
    public bool IsBlurGodray;
    [Range(0.0f, 500f)]
    public float antiBandingAmplify;
    [Header("Scale Clouds")]
    public bool useScaleCloudsOnly;
    [Header("Performance")]
    [Range(1f, 500f)]
    public float raymarchStepSize;
    public bool increaceRaymarchStepByDistance;
    public float distanceRatio;
    public float maxRaymarchStepSize;
    public bool cullingEdgeClouds;
    public float cullingStrength;
    public bool autoMipmap;
    public bool enableNoiseStep;
    public Texture2D noiseStepMap;
    public Texture2D scaleCloudMask;
    public Texture2D scaleCloudMaskNormal;
    public float scaleCloudMaskNormalTileRate;
    public float scaleNoiseStep;
    public float scaleNoise;
    public float cascadedResolutionRange;
    [Header("Transition")]
    public float increaseMipmapLevelByHeight;
    public float mipmapScale;
    public bool enableFadeout;
    public float startFadeoutHeight;
    public float endFadeoutHeight;
    [Header("Debug-Datas")]
    [Range(1f, 100f)]
    public float debugData1;
    [Range(0.0f, 1000f)]
    public float debugData2;
    [Range(0.0f, 100000f)]
    public float debugData3;
    [Range(0.0f, 1000000f)]
    public float debugData4;
    [Range(0.0f, 1E+07f)]
    public float debugData5;
    [Range(0.0f, 100000f)]
    public float debugData6;
    [Header("Debug-Lighting")]
    public float lightExtincteFactor1;
    public float lightExtincteFactor2;
    public float lightExtincteFactor3;
    public float lightExtincteFactor4;
    public float lightExtincteFactor5;
    public float lightExtincteFactor6;
    public float lightExtincteFactor7;
    public float lightExtincteFactor8;
    public float lightStepDistance1;
    public float lightStepDistance2;
    public float lightStepDistance3;
    public float lightStepDistance4;
    public float lightStepDistance5;
    public float lightStepDistance6;
    public float lightStepDistance7;
    public float lightStepDistance8;
    public Action<VolumeCloudConfiguration> OnConfigChanged;
    public Action<VolumeCloudConfiguration> OnConfigIniteComplete;
    public Action<VolumeCloudConfiguration> OnCloudLayerChanged;
    public Action<VolumeCloudConfiguration.CumulusData, VolumeCloudConfiguration> OnBakeCubemap;

    public static GameObject cloudBoxPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCloudRenderHelperLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLenticular() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SortCloudsLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateVerticalColorMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightProbe(SphericalHarmonicsL2 probe, Material block) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyToMaterial(Material mat, SphericalHarmonicsL2 probe = default (SphericalHarmonicsL2)) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCumulusData(
      Material mat,
      VolumeCloudConfiguration.CumulusData cumulusData,
      bool enableSparseTexture = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTextures(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTextures(Material mat, VolumeCloudConfiguration.CumulusData cloudsData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLayerIndex(Material mat, int layerCount, ref int[] indexes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpperLayerIndex(Material mat, int layerCount, ref int[] indexes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCloudsLayersData(
      Material mat,
      ref VolumeCloudConfiguration.CloudsLayerStructuredBuffer[] layerData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpperLayerCumulusData(
      Material mat,
      VolumeCloudConfiguration.CumulusData ShadowCumulusData,
      Matrix4x4 UpperLayerMatrix)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxCloudsLayerData(
      Material mat,
      VolumeCloudConfiguration.BoxCloudsLayerData boxCloudsLayerData,
      Vector3 ralatedPostion)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameTimeScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEarthCenter(Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEarthRotation(Matrix4x4 rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableCloudsColor(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableShadows(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableGodray(bool isOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCloudBBPosition(Material mat, Matrix4x4 martix, Vector4 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOceanDepth(Texture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirectionalLightCount(Material mat, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirectionalLightDir(Material mat, List<Vector4> direcions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirectionalLightIntensity(Material mat, List<float> intensities) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirectionalLightColor(Material mat, List<Vector4> colors) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirectionalShadowMap(Material mat, Texture tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraForward(Material mat, Vector3 forward) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraPosition(Material mat, Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRaymarchStepSize(Material mat, int StepSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSparseTextureTileIndex(int[] checkResult) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRenderStartEnd(Material mat, float start, float end) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAtmosphereBlendFactor(Material mat, Vector3 camPosition, Vector3 planetPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCloudsLayerRotateMatrix(
      Material mat,
      Matrix4x4 rotateMatrix,
      Vector3 ralatedPostion)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledCloudsRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeCloudConfiguration() => throw null;

    public enum CloudsLayerType
    {
      Cumulus = 1,
      Stratus = 2,
      Box = 3,
    }

    [Serializable]
    public class CloudsData
    {
      public bool isEnable;
      public string layerName;
      public bool castShadow;
      public GameObject scaledCloudsRef;
      public float bakeCloudMipmap;
      public float currentBakedCloudMipmap;
      [NonSerialized]
      public GameObject[] scaledClouds;
      public VolumeCloudConfiguration.CloudsLayerType cloudsType;
      public Vector2 cloudHeightRange;
      public Vector3 cloudsLayerRotate;
      [NonSerialized]
      public float movementTimer;
      public bool enableWind;
      public Vector2 windDirection;
      public float movementSpeed;
      public float evolveSpeed;
      public float topOffset;
      public bool isFold;
      public static int scaledCloudsSize;

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal int CompareTo(VolumeCloudConfiguration.CloudsData other) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CloudsData() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static CloudsData() => throw null;
    }

    [Serializable]
    public class CumulusData : VolumeCloudConfiguration.CloudsData
    {
      public Cubemap distributionMap;
      public SparseTexture distributionMapSparseTex;
      public Cubemap cloudColorMap;
      public Cubemap bakedScaledTexture;
      public Cubemap cloudNormalMap;
      public Cubemap bakedBottomScaledTexture;
      public Texture3D baseTexture;
      public float baseTexureTile;
      public float coverageScale;
      public float evanish;
      public float detailAmount;
      public float cloudsMaskBias;
      public float upperFalloff;
      public float lowerFalloff;
      public float detailAltitudeShift;
      public bool enableDetailTexture;
      public Texture3D detailTexture;
      public float detailTextureTile;
      public float detailStrength;
      public float cloudsDensity;
      public float normalScale;
      public Color scaleCloudColor;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CumulusData() => throw null;
    }

    [Serializable]
    public struct BoxCloudData
    {
      public Matrix4x4 cloudsBoxLocalMartix;
      public Vector4 cloudsBoxPosition;
      public int cloudsBoxBaseTexIndex;
      public int cloudsBoxDetailTexIndex;
      public float vortexDensity;
      public float detailTextureTile;
      public float flowSpeed;
      public float flowInsensity;
      public int clockWise;
    }

    public class BoxCloudsLayerData : VolumeCloudConfiguration.CloudsData
    {
      public List<VolumeCloudConfiguration.BoxCloudData> BoxCloudList;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BoxCloudsLayerData() => throw null;
    }

    [Serializable]
    public class CloudBoxSetting
    {
      public bool isEnable;
      public Vector3 cloudsLayerRotate;
      public Vector3 position;
      public Vector3 rotation;
      public Vector3 scale;
      public GameObject cloudBox;
      public int cloudsBoxBaseTexIndex;
      public int cloudsBoxDetailTexIndex;
      public float vortexDensity;
      public float detailVortexTile;
      public float flowSpeed;
      public float flowIntensity;
      public bool clockwise;
      public bool isFold;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CloudBoxSetting() => throw null;
    }

    [Serializable]
    public class BoxCloudsGroup
    {
      public Vector3 position;
      public Vector3 rotation;
      public GameObject cloudBoxGroup;
      public Texture2D distributionTexture;
      [SerializeField]
      public List<VolumeCloudConfiguration.CloudBoxSetting> lenticularList;
      public bool isFoldAutoGeneratedGroup;
      [SerializeField]
      public List<VolumeCloudConfiguration.BoxCloudsGroupAutoGenerate> autoGenerateGroupList;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BoxCloudsGroup() => throw null;
    }

    [Serializable]
    public class BoxCloudsGroupAutoGenerate
    {
      public float rotateAngle;
      public float scale;
      public Vector3 position;
      public Vector3 rotation;
      public GameObject cloudBoxGroup;
      public Texture2D distributionTexture;
      [SerializeField]
      public List<VolumeCloudConfiguration.CloudBoxSetting> lenticularList;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BoxCloudsGroupAutoGenerate() => throw null;
    }

    public class BoxCloudsGroupFromTexture
    {
      public float u;
      public float v;
      public float w;
      public float rotation;
      public float scale;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BoxCloudsGroupFromTexture() => throw null;
    }

    public struct CloudsLayerStructuredBuffer
    {
      public int distributionMapIndex;
      public int cloudsColorMapIndex;
      public int cloudsShadowMapIndex;
      public float cloudStartHeight;
      public float cloudEndHeight;
      public float currentBakedCloudMipmap;
      public Matrix4x4 rotation;
      public Matrix4x4 evolve;
      public int baseTexIndex;
      public float baseTile;
      public float cloudDensity;
      public float coverageScale;
      public float evanish;
      public float cloudsMaskBias;
      public float upperFalloff;
      public float lowerFalloff;
      public float detailAmount;
      public float detailAltitudeShift;
      public int enableDetailTexture;
      public int detailTexIndex;
      public float detailTile;
      public float detailStrength;
      public float normalScale;
      public int enableWind;
      public Vector4 windDirection;
      public float cloudTopOffset;
      public Color scaleCloudColor;
      public Quaternion topOffsetRotation;
    }

    private class PropertyHash
    {
      public static int distributionMap;
      public static int UpperLayerDistributionMap;
      public static int castLayerShadow;
      public static int cloudsColorMap;
      public static int cloudsShadowMap;
      public static int cloudStartHeight;
      public static int cloudEndHeight;
      public static int UpperLayerCloudStartHeight;
      public static int baseTex;
      public static int baseTile;
      public static int coverageScale;
      public static int UpperLayerCoverageScale;
      public static int evanish;
      public static int detailAmount;
      public static int cloudsMaskBias;
      public static int upperFalloff;
      public static int lowerFalloff;
      public static int detailAltitudeShift;
      public static int enableDetailTexture;
      public static int detailTex;
      public static int detailTile;
      public static int detailStrength;
      public static int cloudDensity;
      public static int normalScale;
      public static int cloudsVerticalDistributionScale;
      public static int inverseLayerRotateMatrix;
      public static int cloudRotation;
      public static int UpperLayerCloudRotation;
      public static int systemTime;
      public static int planetRadius;
      public static int planetCenter;
      public static int planetRotation;
      public static int underOceanPixelTexture;
      public static int curlNoise;
      public static int curlTile;
      public static int curlStrength;
      public static int topOffset;
      public static int cloudSize;
      public static int cloudCoverageModifier;
      public static int enableColorMap;
      public static int enableVerticalColor;
      public static int colorMapIntensity;
      public static int verticalColorIntensity;
      public static int scatteringCoefficient;
      public static int enableShadows;
      public static int realTimeShadows;
      public static int shadowDetectSteps;
      public static int shadowDetectStepScale;
      public static int shadowDensity;
      public static int realTimeShadowDistance;
      public static int shadowOpacity;
      public static int shadowMapStrength;
      public static int enableLayerShadows;
      public static int layerShadowDensity;
      public static int extinctionCoefficient;
      public static int lightPenetrateDistance;
      public static int multiScatteringA;
      public static int multiScatteringB;
      public static int multiScatteringC;
      public static int silverSpread;
      public static int bloomStrength;
      public static int silverSpreadUnderCloud;
      public static int bloomStrengthUnderCloud;
      public static int silverSpreadG;
      public static int bloomStrengthG;
      public static int silverSpreadUnderCloudG;
      public static int bloomStrengthUnderCloudG;
      public static int ambinetScale;
      public static int scatteringScale;
      public static int cloudsDensityScale;
      public static int sunsetStart;
      public static int sunsetEnd;
      public static int enableGodray;
      public static int godrayIntensity;
      public static int godrayVisableDistance;
      public static int godrayStepSize;
      public static int sampleLightStepSize;
      public static int sampleLightStepCount;
      public static int cloudDensityRangeEmitGodray;
      public static int godrayAttenuation;
      public static int godrayFadeHeight;
      public static int enableAtmosphere;
      public static int atmosphereIntensity;
      public static int atmosphereDistanceFalloff;
      public static int ambientColor;
      public static int enableCloudGI;
      public static int cloudGIIntensity;
      public static int antiBandingAmplify;
      public static int detailVariationRange;
      public static int useScaleCloudsOnly;
      public static int raymarchStepSize;
      public static int increaceRaymarchStepByDistance;
      public static int distanceRatio;
      public static int maxRaymarchStepSize;
      public static int cullingEdgeClouds;
      public static int cullingStrength;
      public static int autoMipmap;
      public static int enableNoiseStep;
      public static int scaleNoise;
      public static int scaleNoiseStep;
      public static int noiseStepMap;
      public static int scaleCloudMask;
      public static int scaleCloudMaskNormal;
      public static int scaleCloudMaskNormalTileRate;
      public static int increaseMipmapLevelByHeight;
      public static int mipmapScale;
      public static int directionalLightCount;
      public static int directionalLightDir;
      public static int directionalLightIntensity;
      public static int directionalLightColor;
      public static int directionalShadowMap;
      public static int debugData1;
      public static int debugData2;
      public static int debugData3;
      public static int debugData4;
      public static int debugData5;
      public static int debugData6;
      public static int lightExtincteFactor;
      public static int lightExtincteFactor1;
      public static int lightExtincteFactor2;
      public static int lightExtincteFactor3;
      public static int lightExtincteFactor4;
      public static int lightExtincteFactor5;
      public static int lightExtincteFactor6;
      public static int lightExtincteFactor7;
      public static int lightExtincteFactor8;
      public static int lightStepDistance;
      public static int lightStepDistance1;
      public static int lightStepDistance2;
      public static int lightStepDistance3;
      public static int lightStepDistance4;
      public static int lightStepDistance5;
      public static int lightStepDistance6;
      public static int lightStepDistance7;
      public static int lightStepDistance8;
      public static int cloudBBPosition;
      public static int cloudBBLocalMartix;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PropertyHash() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static PropertyHash() => throw null;
    }
  }
}
