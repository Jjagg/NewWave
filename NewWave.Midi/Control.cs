namespace NewWave.Midi
{
	public enum Control
	{
		ModulationWheel = 1,
		DataEntryMSB = 6,
		Volume = 7,
		Pan = 10,
		Expression = 11,
		DataEntryLSB = 38,
		SustainPedal = 64,
		ReverbLevel = 91,
		TremoloLevel = 92,
		ChorusLevel = 93,
		CelesteLevel = 94,
		PhaserLevel = 95,
		NonRegisteredParameterLSB = 98,
		NonRegisteredParameterMSB = 99,
		RegisteredParameterNumberLSB = 100,
		RegisteredParameterNumberMSB = 101,
		AllControllersOff = 121,
		AllNotesOff = 123,
	}
}
