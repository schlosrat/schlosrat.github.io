// Decompiled with JetBrains decompiler
// Type: ProceduralCubemap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class ProceduralCubemap : MonoBehaviour
{
  public int cubeSize;
  public float cameraNear;
  public float cameraFar;
  public string outputName;
  public bool individualFaces;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Texture2D[] CreateIndividualFaces() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Texture2D[] RenderIndividualFaces(
    Vector3 position,
    int cubeSize,
    float cameraNear,
    float cameraFar,
    UnityEngine.TextureFormat textureFormat,
    bool createMipmaps)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Cubemap CreateCubeMap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Cubemap RenderCubemap(
    Vector3 position,
    int cubeSize,
    float cameraNear,
    float cameraFar,
    UnityEngine.TextureFormat textureFormat,
    bool createMipmaps)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Camera CreateCamera(
    string name,
    Vector3 pos,
    Vector3 dir,
    float size,
    float near,
    float far)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Camera CreateCameraOrtho(
    string name,
    Vector3 pos,
    Vector3 dir,
    float size,
    float near,
    float far)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static Texture2D RenderCamera(
    Camera cam,
    int width,
    int height,
    UnityEngine.TextureFormat textureFormat)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProceduralCubemap() => throw null;
}
