using System;
using System.Collections.Generic;

namespace SocialGoal.Web.Helpers
{
    public class Iterator
    {
        private List<string> _private = new List<string>();

        public void Execute(int numberOfStringsToAdd)
        {
            const string formatString = "This is item {0}/{1} with id {2}.";
            
            const string firstAdd = "This is the first string to add.";
            _private.Add(firstAdd);
            
            for (var i = 0; i < numberOfStringsToAdd; i++)
            {
                var strToAdd = string.Format(formatString, i, numberOfStringsToAdd, Guid.NewGuid());
                _private.Add(strToAdd);
            }

            const string lastAdd = "This is the last string to add.";
            _private.Add(lastAdd);
        }
    }
}