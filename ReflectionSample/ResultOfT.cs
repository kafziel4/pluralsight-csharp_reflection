namespace ReflectionSample
{
    public class Result<T>
    {
        public T Value { get; set; }
        public string Remarks { get; set; }

        public T AlterAndReturnValue<S>(S input)
        {
            Console.WriteLine($"Altering value using {input.GetType()}");
            return Value;
        }
    }
}