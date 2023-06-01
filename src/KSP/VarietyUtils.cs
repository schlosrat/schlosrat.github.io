// Decompiled with JetBrains decompiler
// Type: KSP.VarietyUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public static class VarietyUtils
  {
    public const string CHARACTER_SHADER_NAME = "KSP2/Standard Character";
    public const string HAIR_SHADER_NAME = "KSP2/KerbalHair2";
    public const string KSP2STANDARD_SHADER_NAME = "KSP2/Standard";
    public const string HAIR_MATERIAL_TAG = "hair";
    public const string CHARACTER_SHADER_COLOR_PARAM_NAME = "_RandomColor";
    public const string CHARACTER_SHADER_FRESNEL_PARAM_NAME = "_FresnelScale";
    public const float FRESNEL_AT_BRIGHTEST = 0.25f;
    public const float FRESNEL_AT_DARKEST = 5f;
    private static Dictionary<string, System.Type> StringToTypeLookup;
    private static FloatCurve eyeSymmetryProbabilityCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static System.Type GetTypeFromString(string typeNameToFind) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetKerbalRosterManager(out KerbalRosterManager targetKerbalRosterManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GenerateBiography(ref KerbalAttributes kerbalAttributes, string biography) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GenerateSurname(ref KerbalAttributes kerbalAttributes, string surname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyKerbalSkinColor(GameObject GO, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyHairColor(GameObject GO, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetMaterialFresnelValueByColor(
      Renderer curRenderer,
      string fresnelParamName,
      Color curColor)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetEyeHeightInAnimTree(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetEyeSymmetryInAnimTree(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyTeamColor1(GameObject GO, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyTeamColor2(GameObject GO, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryConnectHairToHelmet(GameObject GO, GameObject hairPrefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyStupidityToAnimTrees(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyBraveryToAnimTrees(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyOptimismToAnimTrees(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyConstitutionToAnimTrees(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyVoiceSelection(GameObject GO, int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ApplyVoiceType(GameObject GO, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Transform FindFirstChildTransformByStartsWithString(
      Transform parent,
      string startswith)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ReSkinTheseMeshesToTheRootRig(GameObject GO, GameObject GOWithMeshesToReSkin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PlaceAndAnimateRig(GameObject GO, GameObject rigGO) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VarietyUtils() => throw null;
  }
}
