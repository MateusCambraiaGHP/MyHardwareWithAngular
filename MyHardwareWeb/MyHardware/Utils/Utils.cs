using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyHardware.Utils
{
    public static class Utils
    {
        public static Dictionary<string, string[]> GetModelErrors(this ModelStateDictionary ModelState)
        {
            var errors = ModelState.Where(x => x.Value.Errors.Count > 0)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray());
            return errors;
        }
    }
}