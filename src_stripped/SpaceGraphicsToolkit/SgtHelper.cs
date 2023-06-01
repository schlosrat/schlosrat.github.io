// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public static class SgtHelper
  {
    public const string ShaderNamePrefix = "Hidden/Sgt";
    public const string HelpUrlPrefix = "https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/";
    public const string ComponentMenuPrefix = "Space Graphics Toolkit/SGT ";
    public const string GameObjectMenuPrefix = "GameObject/Space Graphics Toolkit/";
    public static readonly int QuadsPerMesh;
    public static List<Material> tempMaterials;
    public static SgtHelper.DistanceDelegate OnCalculateDistance;
    private static Stack<Random.State> seedStates;
    private static GradientAlphaKey[] tempAlphaKeys;
    private static GradientColorKey[] tempColorKeys;
    private static List<Material> materials;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetIndex<T>(ref List<T> list, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearCapacity<T>(List<T> list, int minCapacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Enabled(Behaviour b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetOrAddComponent<T>(GameObject gameObject, bool recordUndo = true) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T AddComponent<T>(GameObject gameObject, bool recordUndo = true) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Destroy<T>(T o) where T : Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Zero(float v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Reciprocal(float v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Acos(float v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Reciprocal3(Vector3 xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Divide(float a, float b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Divide(double a, double b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector4 NewVector4(Vector3 xyz, float w) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Sharpness(float a, float p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CubicInterpolate(float a, float b, float c, float d, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float HermiteInterpolate(float a, float b, float c, float d, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color HermiteInterpolate(Color a, Color b, Color c, Color d, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 HermiteInterpolate3(
      Vector3 a,
      Vector3 b,
      Vector3 c,
      Vector3 d,
      float t)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float DampenFactor(float dampening, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float DampenFactor(float dampening, float deltaTime, float linear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Mod(int a, int b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds NewBoundsFromMinMax(Vector3 min, Vector3 max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Bounds NewBoundsCenter(Bounds b, Vector3 c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetRandomSeed(int newSeed, long x, long y, long z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BeginRandomSeed(int newSeed, long x, long y, long z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BeginRandomSeed(int newSeed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EndRandomSeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Material CreateTempMaterial(string materialName, string shaderName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMeshRadius(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh CreateTempMesh(string meshName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Texture2D CreateTempTexture2D(
      string name,
      int width,
      int height,
      TextureFormat format = TextureFormat.ARGB32,
      bool mips = false,
      bool linear = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Gradient CreateGradient(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CreateGameObject(
      string name,
      int layer,
      Transform parent = null,
      bool recordUndo = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CreateGameObject(
      string name,
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale,
      bool recordUndo = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 CartesianToPolar(Vector3 xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 CartesianToPolarUV(Vector3 xyz) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector4 CalculateSpriteUV(Sprite s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CalculateHorizonThickness(
      float innerRadius,
      float middleRadius,
      float distance,
      out float innerThickness,
      out float outerThickness)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnableKeyword(string keyword, Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DisableKeyword(string keyword, Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Resize<T>(List<T> list, int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddMaterial(Renderer r, Material m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReplaceMaterial(Renderer r, Material m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveMaterial(Renderer r, Material m) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float UniformScale(Vector3 scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matrix4x4 ShearingZ(Vector2 xy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color Brighten(Color color, float brightness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Color Premultiply(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetTempMaterial(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetTempMaterial(Material material1, Material material2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnableKeyword(string keyword) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DisableKeyword(string keyword) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMatrix(string key, Matrix4x4 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtHelper() => throw null;

    public delegate void DistanceDelegate(Vector3 worldPosition, ref float distance);
  }
}
