var target = Argument("target", "ChocoPack");

Task("ChocoPack")
  .Does(() =>
{
  var chocoPackDir = "./cakepack";
  CreateDirectory(chocoPackDir);
  var chocolateyPackSettings = new ChocolateyPackSettings {
    OutputDirectory = chocoPackDir,
  };

  ChocolateyPack("./helloworld/helloworld.nuspec", chocolateyPackSettings);
});

RunTarget(target);
