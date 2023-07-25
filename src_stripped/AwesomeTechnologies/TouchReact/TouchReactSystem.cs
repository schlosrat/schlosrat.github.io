// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.TouchReact.TouchReactSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.TouchReact
{
  [HelpURL("http://www.awesometech.no/index.php/home/vegetation-studio/components/touch-bend-system")]
  [ExecuteInEditMode]
  public class TouchReactSystem : MonoBehaviour
  {
    public static TouchReactSystem Instance;
    public int InvisibleLayer;
    public Camera TouchReactCamera;
    public Camera SelectedCamera;
    public bool AutoselectCamera;
    public float CameraYPosition;
    private Material _touchReactMaterial;
    private Material _touchreactMaterialInstanced;
    private MaterialPropertyBlock _touchreactMaterialPropertyBlock;
    public TouchReactQuality TouchReactQuality;
    public int OrthographicSize;
    public bool ShowDebugColliders;
    public bool HideTouchReactCamera;
    private Mesh _sphereColliderMesh;
    private Mesh _boxColliderMesh;
    public List<TouchColliderInfo> ColliderList;
    public List<MeshFilter> MeshFilterList;
    private readonly List<CapsuleColliderInfo> _capsuleColliderMeshList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateColliderPrimitives() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetTouchReactQualityPixelResolution(TouchReactQuality touchReactQuality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Mesh GetCapsuleColliderMesh(float radius, float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh CreateBoxMesh(float length = 1f, float width = 1f, float height = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh CreateCapsuleMesh(float radius, float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh CreateSphereMesh(float radius = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateShaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float SnapToPixel(float v, int textureSize, float orthoSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawMeshfilters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawBoxCollider(BoxCollider boxCollider, float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawCapsuleCollider(CapsuleCollider capsuleCollider, float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSphereCollider(SphereCollider sphereCollider, float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawMeshCollider(MeshCollider meshCollider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMaxValue(Vector3 vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawMeshfilter(MeshFilter meshfilter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTouchReactCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateTouchReactCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetCameraPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstanceAddCollider(TouchColliderInfo touchColliderInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstanceRemoveCollider(TouchColliderInfo touchColliderInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstanceAddMeshFilter(MeshFilter meshFilter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstanceDrawMeshInstanced(
      Mesh mesh,
      List<Matrix4x4> instanceList,
      int subMeshIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InstanceRemoveMeshFilter(MeshFilter meshFilter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FindInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddCollider(TouchColliderInfo touchColliderInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveCollider(TouchColliderInfo touchColliderInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddMeshFilter(MeshFilter mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveMeshFilter(MeshFilter mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TouchReactEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawMeshInstanced(Mesh mesh, List<Matrix4x4> instanceList, int subMeshIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TouchReactSystem() => throw null;
  }
}
