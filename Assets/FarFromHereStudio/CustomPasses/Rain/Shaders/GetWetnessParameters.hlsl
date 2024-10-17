float _Wetness;
float _RainDrops;

void GetWetnessParameters_float(out float wetness, out float raindrops)
{
    wetness = _Wetness;
    raindrops = _RainDrops/10;
}