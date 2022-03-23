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
            "Assets/Scenes/Samuel/Team",
            "Assets/Scenes/Lorie/MainMenu",
        };

        buildPlayerOptions.locationPathName = "Builds/WebGL/";

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}