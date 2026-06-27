using HECUVoiceLab.Presets; namespace HECUVoiceLab.Dsp;
// Optional tiny edge clicks/noise mimic comm key artifacts; default noise is off to keep clean gaps.
public sealed class RadioClickNoise { readonly Random rng=new(7); int click; Preset p=new(); public void Configure(Preset preset)=>p=preset; public void Trigger(){ if(p.RadioClickAmount>0) click=80; } public float Process(float x){ var y=x; if(click>0){ y += ((click--/80f)-.5f)*p.RadioClickAmount/100*.12f; } if(p.RadioNoiseAmount>0) y += ((float)rng.NextDouble()*2-1)*p.RadioNoiseAmount/100*.015f; return y; } }
