namespace zd3
{
    public class COcena
    {
        public enum TOceny
        {
            polski = 0,
            matematyka = 1,
            angielski = 2,
            wf = 3
        }
        public static string[] subject_names = {"Matematyka", "Polski", "Angielski", "WF" };
        
        public double grade { get; set; }
        public ushort weight { get; set; }
        public string subject_name { get; set; }
    }
}