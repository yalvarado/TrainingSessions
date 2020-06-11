namespace TrainingSessions.GoodCode
{
    // Use blank lines sparinly, space is cheap and your eyes would appreciate it.
    public class SpaceExamples
    {
        public void Method1()
        {
            int integer=5;
            string text = "text ";
            string trimmedText = text.Trim();
            trimmedText = trimmedText + integer;
            for(int i=0;i<10;i++)
            {
                integer = integer + i;
            }
            trimmedText = trimmedText + integer;
        }


        public void Method1()
        {
            int integer=5;
            string text = "text ";
            
            string trimmedText = text.Trim() + integer;
            
            for(int i=0;i<10;i++)
                integer = integer + i;
            

            trimmedText = trimmedText + integer;
        }

    }
}