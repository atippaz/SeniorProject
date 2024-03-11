namespace ExportApi
{
    public static class DummyDataBase
    {
        static Dictionary<string, string>[] menu1 = new Dictionary<string, string>[]
        {
           new Dictionary<string, string>
    {
        {"firstName", "John"},
        {"lastName", "Doe"},
        {"age", "25"},
        {"gender", "male"},
        {"nickName", "JD"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Alice"},
        {"lastName", "Smith"},
        {"age", "30"},
        {"gender", "female"},
        {"nickName", "AS"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Michael"},
        {"lastName", "Johnson"},
        {"age", "18"},
        {"gender", "male"},
        {"nickName", "MJ"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Emily"},
        {"lastName", "Brown"},
        {"age", "18"},
        {"gender", "female"},
        {"nickName", "EB"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Daniel"},
        {"lastName", "Martinez"},
        {"age", "22"},
        {"gender", "male"},
        {"nickName", "DM"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Sophia"},
        {"lastName", "Garcia"},
        {"age", "22"},
        {"gender", "female"},
        {"nickName", "SG"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Matthew"},
        {"lastName", "Lopez"},
        {"age", "18"},
        {"gender", "male"},
        {"nickName", "ML"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Olivia"},
        {"lastName", "Hernandez"},
        {"age", "18"},
        {"gender", "female"},
        {"nickName", "OH"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Ethan"},
        {"lastName", "Wright"},
        {"age", "25"},
        {"gender", "male"},
        {"nickName", "EW"},
    },
    new Dictionary<string, string>
    {
        {"firstName", "Emma"},
        {"lastName", "Young"},
        {"age", "25"},
        {"gender", "female"},
        {"nickName", "EY"},
    }

        };
        static Dictionary<string, string>[] menu2 = new Dictionary<string, string>[]
        {
           new Dictionary<string, string>
    {
        {"name", "ABC Company"},
        {"industry", "Technology"},
        {"foundedYear", "2005"},
        {"founder", "John Smith"},
        {"location", "San Francisco, CA"},
    },
    new Dictionary<string, string>
    {
        {"name", "XYZ Corporation"},
        {"industry", "Finance"},
        {"foundedYear", "1990"},
        {"founder", "Alice Johnson"},
        {"location", "New York, NY"},
    },
    new Dictionary<string, string>
    {
        {"name", "EFG Ltd."},
        {"industry", "Manufacturing"},
        {"foundedYear", "1985"},
        {"founder", "Michael Williams"},
        {"location", "Chicago, IL"},
    },
    new Dictionary<string, string>
    {
        {"name", "PQR Group"},
        {"industry", "Healthcare"},
        {"foundedYear", "2010"},
        {"founder", "Emily Brown"},
        {"location", "Boston, MA"},
    },
    new Dictionary<string, string>
    {
        {"name", "LMN Enterprises"},
        {"industry", "Consulting"},
        {"foundedYear", "2000"},
        {"founder", "Daniel Martinez"},
        {"location", "Los Angeles, CA"},
    },
    new Dictionary<string, string>
    {
        {"name", "RST Inc."},
        {"industry", "Retail"},
        {"foundedYear", "1978"},
        {"founder", "Sophia Garcia"},
        {"location", "Miami, FL"},
    },
    new Dictionary<string, string>
    {
        {"name", "UVW Innovations"},
        {"industry", "Research and Development"},
        {"foundedYear", "2015"},
        {"founder", "Matthew Lopez"},
        {"location", "Seattle, WA"},
    },
    new Dictionary<string, string>
    {
        {"name", "IJK Holdings"},
        {"industry", "Real Estate"},
        {"foundedYear", "1995"},
        {"founder", "Olivia Hernandez"},
        {"location", "Dallas, TX"},
    },
    new Dictionary<string, string>
    {
        {"name", "NOP Limited"},
        {"industry", "Education"},
        {"foundedYear", "1982"},
        {"founder", "Ethan Wright"},
        {"location", "Atlanta, GA"},
    },
    new Dictionary<string, string>
    {
        {"name", "QRS Group"},
        {"industry", "Hospitality"},
        {"foundedYear", "2008"},
        {"founder", "Emma Young"},
        {"location", "Denver, CO"},
    }
        };
        public static string[] MenuName = { "menu1", "menu2" };
        public static Dictionary<string, string[]> DataColumn = new Dictionary<string, string[]>
        {
            { "menu1" ,menu1[0].Keys.ToArray() },
            { "menu2" ,menu2[0].Keys.ToArray() },
        };
        public static Dictionary<string, string[]> FilterColumn = new Dictionary<string, string[]>()
        {
            { "menu1" ,menu1[0].Keys.ToArray() },
            { "menu2" ,menu2[0].Keys.ToArray() },
        };
        public static Dictionary<string, Dictionary<string, string>[]> DataDummy = new Dictionary<string, Dictionary<string, string>[]>()
        {
            {"menu1", menu1},
            {"menu2", menu2}
        };
    }
}
