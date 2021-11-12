using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AwesomeConverter.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double? LengthInMiles { get; set; }

    public double? LengthInMeters { get; set; }

    public void OnPost()
    {
        if (LengthInMiles == null)
            return;

        LengthInMeters = ConvertMilesToMeters(LengthInMiles.Value);
    }

    private static double ConvertMilesToMeters(double lengthInMiles)
    {
        double metersInMiles = 1_600;

        return lengthInMiles * metersInMiles;
    }
}