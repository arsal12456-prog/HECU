using NAudio.Wave; namespace HECUVoiceLab.Audio;
public record AudioDeviceInfo(int Index,string Name,int Channels);
public static class DeviceManager { public static List<AudioDeviceInfo> Inputs()=>Enumerable.Range(0,WaveIn.DeviceCount).Select(i=>{var c=WaveIn.GetCapabilities(i);return new AudioDeviceInfo(i,c.ProductName,c.Channels);}).ToList(); public static List<AudioDeviceInfo> Outputs()=>Enumerable.Range(0,WaveOut.DeviceCount).Select(i=>{var c=WaveOut.GetCapabilities(i);return new AudioDeviceInfo(i,c.ProductName,c.Channels);}).ToList(); }
