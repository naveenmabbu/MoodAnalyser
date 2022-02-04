using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            var result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.TypeOfException.NO_SUCH_CLASS, "no such class is found");
                }
            }
            else
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.TypeOfException.NO_SUCH_METHOD, "no such constructor found");
        }

    }
}
