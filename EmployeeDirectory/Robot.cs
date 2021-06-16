namespace EmployeeDirectory
{
    public class Robot
    {
        // private string name;

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }


        public string Name { get; set; }
     


        public Robot(int height, string name)
        {
            Name = name;
        }


        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string newName)
        //{
        //    //Validate
        //    name = newName;
        //}
    }
}