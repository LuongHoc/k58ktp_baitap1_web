using System;
using System.Globalization;
using System.Text;
using StepLib;  // cần StepLib.dll chép vào thư mục /bin

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json; charset=utf-8";
        Response.ContentEncoding = Encoding.UTF8;
        Response.Charset = "utf-8";
        try
        {
            double km = SafeParse.PositiveDouble(Request["distanceKm"]);
            double kg = SafeParse.PositiveDouble(Request["weightKg"]);
            double step = SafeParse.PositiveDouble(Request["stepLengthM"]);

            StepCalculator sc = new StepCalculator();
            sc.DistanceKm = km; sc.WeightKg = kg;
            if (step > 0) sc.StepLengthM = step;
            sc.HocFactor = 1.0; sc.Signature = "by Học";

            long steps = sc.ComputeSteps();
            double kcal = sc.ComputeCalories();

            string json = "{\"ok\":true,\"steps\":" + steps.ToString(CultureInfo.InvariantCulture)
                        + ",\"kcal\":" + kcal.ToString(CultureInfo.InvariantCulture)
                        + ",\"note\":\"by Học\"}";
            Response.Write(json);
        }
        catch (Exception ex)
        {
            Response.StatusCode = 500;
            Response.Write("{\"ok\":false,\"error\":\"" + ex.Message.Replace("\"", "\\\"") + "\"}");
        }
        Response.End();
    }
}
