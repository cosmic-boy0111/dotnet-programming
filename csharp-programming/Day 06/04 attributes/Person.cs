namespace csharp_programming
{
    [Comment(Text = "Persone class")]
    internal class Person
    {
        [Comment(Text = "Persone Name")]
        public string Name { get; set; }

        [Comment(Text = "Persone Age")]
        public string Age { get; set; }

        [Comment(Text = "Persone's marital status")]
        public string Married { get; set; }

        [Comment(Text = "is persone graduate or undergraduate")]
        public string IsGraduate { get; set; }

        public override string ToString()
        {
            return $"Name = {Name},{"\n"} Age = {Age},{"\n"} Married = {Married},{"\n"} Graduate = {IsGraduate}{"\n"}";
        }
    }
}
