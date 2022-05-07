namespace BlazorApp2.Data
{
    public class SqlConnectionConfiguration
    {

        public SqlConnectionConfiguration(string value) => Value = value;
        public string Value { get; set; }

    }
}
