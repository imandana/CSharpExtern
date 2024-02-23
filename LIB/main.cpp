
extern "C"
{
	int hasil;

	int SuperConductor(int a, int b)
	{
		return a * b;
	}

	void AddToHasil(int a)
	{
		hasil = a;
	}
}