namespace NewWave.Core
{
	public enum Velocity
	{
		Off = 0,
		Ppp = 16,
		Pp = 32,
		P = 48,
		Mp = 64,
		Mf = 80,
		F = 96,
		Ff = 112,
		Fff = 127
	}

    public static class VelocityEx
    {
        public static int ToInt(this Velocity velocity)
        {
            return (int) velocity;
        }
    }
}
