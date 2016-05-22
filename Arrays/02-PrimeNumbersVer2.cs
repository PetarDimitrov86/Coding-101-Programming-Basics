var n = int.Parse(Console.ReadLine());
bool[] primes = new bool[n + 1];
for (int i = 0; i <= n; i++) primes[i] = true;
primes[0] = primes[1] = false;
for (int p = 2; p <= n; p++)
  if (primes[p]) FillPrimes(primes, p);
static void FillPrimes(bool[] primes, int step)
{
  for (int i = 2 * step; i < primes.Length; i += step)
    primes[i] = false;
}
