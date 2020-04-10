using System;

namespace AssemblyOne
{
	class Program
	{
		static void Main(string[] args)
		{
			SportBike bike = new SportBike();

			bike.MaxSpeedPublic = 230;
			bike.MaxSpeedInternal = 200;
			bike.MaxSpeedInternalProtected();
		}
	}
}
