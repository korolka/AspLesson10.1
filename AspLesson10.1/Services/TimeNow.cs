namespace AspLesson10._1.Services
{
    public class TimeNow : ITimeNow
    {
        DateTime time;
        public string Time()
        {
            time = DateTime.Now;
            string message ="def";
            switch (time.Hour)
            {
                case int hour when (hour > 4 && hour  <= 12):
                    message = "Morning";               
                    break;                             
                case int hour when (hour > 12 && hour <= 16):
                    message = "Day";                   
                    break;                             
                case int hour when (hour > 16 && hour <= 23):
                    message = "Midlenight";            
                    break;                             
                case int hour when (hour > 23 && hour <= 4):
                    message = "Night";
                    break;
            }
            return message;
        }
    }
}
