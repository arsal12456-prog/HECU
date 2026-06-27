namespace HECUVoiceLab.Presets;
public static class PresetManager
{
 public static Preset HecuReference => new();
 public static IReadOnlyList<Preset> BuiltIns => new[]{
  HecuReference,
  new Preset{Name="Cleaner HECU",LowPassHz=6500,BitDepth=10,CrunchMix=35,AntiAliasSmoothness=45,CompressorRatio=3.5f,GritDrive=18,ChopAmount=10,EndCutTightness=10,RadioClickAmount=2,LimiterCeilingDb=-6},
  new Preset{Name="Dirtier HECU",LowPassHz=4300,BitDepth=7,CrunchMix=88,AntiAliasSmoothness=8,CompressorRatio=7,MakeupGainDb=5,GritDrive=58,ChopAmount=38,TransientBite=40,EndCutTightness=45,RadioClickAmount=10,LimiterCeilingDb=-9},
  new Preset{Name="Radio Only",LowPassHz=5600,BitDepth=16,CrunchMix=0,CompressorRatio=4,GritDrive=5,ChopAmount=0,RadioClickAmount=0,RadioNoiseAmount=0},
  new Preset{Name="Bypass / Clean Monitor",Bypass=true,DryWet=0,BitDepth=16,CrunchMix=0,GritDrive=0,ChopAmount=0,RadioClickAmount=0,RadioNoiseAmount=0}
 };
}
