namespace PeriodicTableElements
{
    public class Model
    {
        public int AtomicNumber {  get; set; }
        public double AtomicWeight {  get; set; }
        public Model(int atomicNumber, double atomicWeight)
        {
            AtomicNumber = atomicNumber;
            AtomicWeight = atomicWeight;

        }
    }
}
