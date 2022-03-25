using UnityEditor;

public static class BuildWebGL
{
    [MenuItem("Build/Build")]
    public static void Build()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;

        buildPlayerOptions.scenes = new[] {
            "Assets/Scenes/Level 1.unity",
        };

        buildPlayerOptions.locationPathName = "Builds/WebGL/";

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}
