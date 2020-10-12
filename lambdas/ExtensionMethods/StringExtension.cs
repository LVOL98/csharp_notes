namespace ExtensionMethods
{
    public static class StringExtension
    {
        public void AddPercent(this string text)
        {
            text + "%";
        }

        static void Main(string[] args)
        {
            var text = "test";
        }
    }
}