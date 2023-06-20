namespace FooBarGroup
{
    class FooBar
    {
        private Dictionary<int, string> rules = new Dictionary<int, string>();
        public void Execute(int n)
        {
            string result = "";
            string separator = ", ";
            for (int i = 1; i <= n; i++)
            {
                result += calculate(i) + separator;
            }
            result = result.Remove(result.Length - separator.Length);
            Console.WriteLine(result);
        }
        private string calculate(int input)
        {
            string output = "";
            foreach (KeyValuePair<int, string> rule in rules)
            {
                int divider = rule.Key;
                string dividerOutput = rule.Value;
                if (input % divider == 0)
                {
                    output += dividerOutput;
                }
            }
            if (output.Equals(""))
            {
                return input + "";
            }
            return output;
        }
        /*
        AddRule will add new rule if not exist else replace the rule
        */
        public void AddRule(int input, string output)
        {
            rules[input] = output;
        }
        static void Main(string[] args)
        {
            FooBar fooBar = new FooBar();
            // add rule 3 : foo, add rule 5 : bar
            fooBar.AddRule(3, "foo");
            fooBar.AddRule(5, "bar");
            fooBar.Execute(15);
            Console.WriteLine();
            // add rule 3 : foo, add rule 5 : bar, add rule 7 : jazz
            fooBar.AddRule(3, "foo");
            fooBar.AddRule(5, "bar");
            fooBar.AddRule(7, "jazz");
            fooBar.Execute(105);
            Console.WriteLine();
            /* use these rules :
            3 : "foo";
            4 : "baz";
            5 : "bar";
            7 : "jazz";
            9 : "huzz";
            */
            fooBar.AddRule(3, "foo");
            fooBar.AddRule(4, "baz");
            fooBar.AddRule(5, "bar");
            fooBar.AddRule(7, "jazz");
            fooBar.AddRule(9, "huzz");
            fooBar.Execute(105);
            Console.WriteLine();
        }
    }
}