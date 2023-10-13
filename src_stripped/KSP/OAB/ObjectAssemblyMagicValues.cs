// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyMagicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public static class ObjectAssemblyMagicValues
  {
    public const string TagPartPanel = "UI_VAB_PARTS_PANEL";
    public const string NoSurfaceAttachTag = "NoAttach";
    public const string TopNodeTag = "top";
    public const string PlaceholderChild = "model-placeholder";
    public const float AsyncPartLoadDelay = 0.009f;
    public const float UIColorFlashSpeedScale = 5f;
    public const int PartTooltipModalShowMoreThreshold = 5;
    public const int HistoricalRecords = 80;
    public const string NameOfConfigFile = "oab-config";
    public const float MINIMUM_NODE_RADIUS = 0.5f;
    public const string SAVE_FILE_DATE_FORMAT = "d";
    public const string SAVE_FILE_TIME_FORMAT = "t";
    public const float MinimumGridScale = 256f;
    public static string PartSelectionShaderName;
    public const float PartSelectionTransparency = 0.4f;
    public const string FUEL_TYPE_NONE = "None";
    public const float SYMMETRY_MIN_DISTANCE_THRESHOLD = 0.01f;
    public const AssemblyPartFilterType DEFAULT_PART_FILTER = AssemblyPartFilterType.Type;
    public const PartCategories DEFAULT_PART_CATEGORY = PartCategories.Pods;
    public const int UNDO_REDO_LIMIT_PER_FRAME = 4;
    public static readonly Vector3 AirplanePartRotation;
    public static readonly Vector3 RocketPartRotation;
    public static readonly Color DebugSizeLimitsColor;
    public const float PLACEMENT_TOOL_SNAP_DEGREES = 15f;
    public const float PLACEMENT_TOOL_SNAP_DEGREES_FINE = 5f;
    public const float PLACEMENT_TOOL_ROTATE_SPEED = 90f;
    public const float PLACEMENT_TOOL_ROTATE_SPEED_FINE = 5f;
    public const float TRANSLATE_TOOL_SNAP_DISTANCE = 0.2f;
    public const float TRANSLATE_TOOL_SNAP_DISTANCE_FINE = 0.05f;
    public const float TRANSLATE_TOOL_LIMIT_SMOOTHER = 0.25f;
    public const string OAB_UI_CANVAS_SORTING_LAYER_NAME = "Main";

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssemblyMagicValues() => throw null;

    public static class LocalizationStrings
    {
      public const string PartCategorySlug = "VAB/PartsPicker/";
      public const string VABHistorySlug = "VAB/History/";
      public const string VABSizeSlug = "VAB/Size/";
      public const string VABTooltipSlug = "VAB/Tooltip/";
      public const string VABMenuSlug = "Menu/VAB/";
      public const string VABWorkspaceVehicleDefaultName = "VAB/Fly Safe";
      public const string VABWorkspaceDefaultName = "VAB/WorkspaceDefaultName";
      public const string VABAutoSaveName = "VAB/AutoSaveFileName";
      public const string VABVesselDefaultDescription = "VAB/NoDescription";
      public const string VABAutoSaveDescription = "VAB/AutoSaveDescription";
      public const string VABShipNameDefault = "VAB/Topbar/ShipNamePlaceholder";
      public const string OversizedAssembly = "VAB/LaunchButton/OversizedAssembly";
      public const string NotEnoughResources = "VAB/LaunchButton/NotEnoughResources";
      public const string PartsIn = "Menu/VAB/PartsIn";
      public const string Stages = "Menu/VAB/Stages";
      public const string DateTimeSpacer = "Menu/VAB/DateTimeSpacer";
      public const string Cancel = "Menu/VAB/Cancel";
      public const string DontSave = "Menu/VAB/DontSave";
      public const string Save = "Menu/VAB/Save";
      public const string EditVessel = "Menu/VAB/EditVessel";
      public const string OverwriteSave = "Menu/VAB/OverwriteSave";
      public const string Load = "Menu/VAB/Load";
      public const string OversizedLoad = "Menu/VAB/OversizedLoad";
      public const string NotEnoughResourcesOnLoad = "Menu/VAB/NotEnoughResourcesOnLoad";
      public const string Warning = "Menu/VAB/Warning";
      public const string LocationOccupied = "Menu/VAB/LocationOccupied";
      public const string Launch = "Menu/VAB/Launch";
      public const string LaunchCollision = "Menu/VAB/LaunchCollision";
      public const string LaunchOversizedAssembly = "Menu/VAB/LaunchOversizedAssembly";
      public const string LaunchNotEnoughResources = "Menu/VAB/LaunchNotEnoughResources";
      public const string WarningTagSize = "Menu/VAB/SizeWarning";
      public const string WarningTagResources = "Menu/VAB/ResourceWarning";
      public const string WarningTagOversizedAndResources = "Menu/VAB/SizeResourceWarning";
      public const string WarningInvalidProceduralFairing = "Menu/VAB/InvalidFairingWarning";
      public const string WarningNoCommandModule = "Menu/VAB/NoCommandModuleWarning";
      public const string WarningOccupiedLaunchpad = "Menu/VAB/OccupiedLaunchpadWarning";
      public const string ClearLaunchpad = "Menu/VAB/ClearLaunchpad";
      public const string OK = "Menu/VAB/OK";
      public const string EmptyCategory = "VAB/PartsPicker/EmptyCategory";
      public const string EmptyFavorites = "VAB/Favorites/EmptyFavoritesCategoryPlaceholder";
      public const string EmptySearchResults = "VAB/PartsPicker/EmptySearchResults";
      public const string Delete = "Menu/VAB/Delete";
      public const string DeleteWorkspace = "Menu/VAB/DeleteWorkspace";
      public const string DeleteButton = "Menu/SaveLoad/Delete";
      public const string DontDelete = "Menu/VAB/DontDelete";
      public const string FavoritePartPCClickSprite = "<sprite name=Mouse_Middle>";
      public const string FavoritePartXboxClickSprie = "<sprite name=Xbox_RS>";
      public const string FavoritePartPSClickSprie = "<sprite name=PS_R3>";
      public const string MESSAGE_NOTHING_TO_LAUNCH = "Menu/VAB/Messages/NothingToLaunch";
      public const string MESSAGE_NOTHING_TO_LAUNCH_OBJS_REMAIN = "VAB/Messages/NothingToLaunchObjsRemain";
      public const string MESSAGE_ALREADY_LAUNCHING = "Menu/VAB/Messages/AlreadyLaunching";
      public const string MESSAGE_NO_LAUNCHABLE_LOCATION = "VAB/Messages/NoLaunchableLocation";
      public const string MESSAGE_LAUNCH_ERROR = "VAB/Messages/AssemblyLaunchError";
      public const string MESSAGE_RELOADING_PARTS = "VAB/Messages/ReloadingParts";
      public const string MESSAGE_PART_NOT_AVAILABLE = "VAB/Messages/PartNotAvailable";
      public const string MESSAGE_PART_STILL_LOADING = "Menu/VAB/Messages/StillLoadingMessage";
      public const string MESSAGE_INVALID_SYMMETRY_ATTACH = "VAB/Messages/InvalidSymmetryAttach";
      public const string MESSAGE_INVALID_ANCHOR = "VAB/Messages/InvalidAnchor";
      public const string MESSAGE_SAVE_ERROR = "VAB/Messages/WorkspaceSaveError";
      public const string MESSAGE_PASTE_ERROR = "VAB/Messages/InvalidPaste";
      public const string EVAGround = "Flight/CameraMode/EVAGround";
    }
  }
}
