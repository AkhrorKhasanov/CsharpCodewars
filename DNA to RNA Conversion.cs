namespace Converter
{
    public class Converter
    {
        public string dnaToRna(string dna)
        {
            string res = "";
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'T')
                {
                    res += 'U';
                }
                else
                {
                    res += dna[i];
                }
            }
            return res;
        }
    }
}