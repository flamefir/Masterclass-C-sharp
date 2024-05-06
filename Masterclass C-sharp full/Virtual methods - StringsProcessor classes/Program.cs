namespace Virtual_methods___StringsProcessor_classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    public class StringsProcessor
    {
        public virtual List<string> Process(List<string> processText)
        {
            return processText;
        }
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> processTexts)
        {
            var result = new List<string>();
            foreach (var processText in processTexts)
            {
                result.Add(processText.Substring(0, processText.Length / 2));
            }
            return result;
        }
    }

    public class StringsUppercaseProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> processTexts)
        {
            var result = new List<string>();
            foreach (var processText in processTexts)
            {
                result.Add(processText.ToUpper());
            }
            return result;
        }
    }

}
