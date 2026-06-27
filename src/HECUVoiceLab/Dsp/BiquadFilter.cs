namespace HECUVoiceLab.Dsp;
public enum BiquadType { HighPass, LowPass, Peaking }
public sealed class BiquadFilter
{ double b0,b1,b2,a1,a2,z1,z2; public float Process(float x){ var y=b0*x+z1; z1=b1*x-a1*y+z2; z2=b2*x-a2*y; return (float)y; } public void Reset()=>z1=z2=0;
 public void Set(BiquadType type, double sampleRate, double freq, double q, double gainDb=0){ freq=Math.Clamp(freq,10,sampleRate*0.45); q=Math.Max(.05,q); var w=2*Math.PI*freq/sampleRate; var c=Math.Cos(w); var s=Math.Sin(w); var alpha=s/(2*q); double A=Math.Pow(10,gainDb/40), B0,B1,B2,A0,A1,A2;
  if(type==BiquadType.HighPass){B0=(1+c)/2;B1=-(1+c);B2=(1+c)/2;A0=1+alpha;A1=-2*c;A2=1-alpha;} else if(type==BiquadType.LowPass){B0=(1-c)/2;B1=1-c;B2=(1-c)/2;A0=1+alpha;A1=-2*c;A2=1-alpha;} else {B0=1+alpha*A;B1=-2*c;B2=1-alpha*A;A0=1+alpha/A;A1=-2*c;A2=1-alpha/A;} b0=B0/A0;b1=B1/A0;b2=B2/A0;a1=A1/A0;a2=A2/A0; }
}
