//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2205248#content
namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary; // Dictionary<type_of_key, type_of_value> 
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }
    }   
}