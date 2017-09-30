using TechTalk.SpecFlow;

namespace SpringerTests.Framework
{
    public class StateManager
    {
        public static void Save(string key, string value)
        {
            ScenarioContext.Current[key] = value;
        }

        public static T Get<T>(string key) where T : class
        {
            return ScenarioContext.Current[key] as T;
        }
    }
}
